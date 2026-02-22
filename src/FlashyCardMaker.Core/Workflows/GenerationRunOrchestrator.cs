namespace FlashyCardMaker.Core.Workflows;

using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;
using FlashyCardMaker.Core.Services;

public sealed class GenerationRunOrchestrator(
    IRunStateRepository runStateRepository,
    GenerationRecordNormalizer normalizer) : IRunOrchestrator
{
    public async Task<RunExecutionResult> StartAsync(EffectiveConfigurationSnapshot configuration, IReadOnlyList<IDictionary<string, object?>> sourceInputs, CancellationToken cancellationToken = default)
    {
        var runId = Guid.NewGuid().ToString("N");
        var records = normalizer.Normalize(sourceInputs);

        var snapshot = new RunStateSnapshot(
            runId,
            RunStatus.Completed,
            DateTimeOffset.UtcNow,
            Array.Empty<string>(),
            records.ToDictionary(r => r.RecordId, _ => JobTerminalStatus.Succeeded));

        await runStateRepository.SaveAsync(snapshot, cancellationToken);

        return new RunExecutionResult(runId, RunStatus.Completed, RunExitCodes.Success, ["Run completed"]);
    }

    public async Task<RunExecutionResult> ResumeAsync(string runId, IDictionary<string, object?>? retryOverrides = null, CancellationToken cancellationToken = default)
    {
        var existing = await runStateRepository.LoadAsync(runId, cancellationToken);
        return existing is null
            ? new RunExecutionResult(runId, RunStatus.Failed, RunExitCodes.RuntimeError, ["Run not found"])
            : new RunExecutionResult(runId, RunStatus.Completed, RunExitCodes.Success, ["Run resumed"]);
    }

    public async Task<RunProgressSnapshot?> GetProgressAsync(string runId, CancellationToken cancellationToken = default)
    {
        var existing = await runStateRepository.LoadAsync(runId, cancellationToken);
        if (existing is null)
        {
            return null;
        }

        return new RunProgressSnapshot(runId, existing.Status, existing.JobStates.Count, existing.JobStates.Count, 0, Array.Empty<ItemProgressSnapshot>());
    }

    public async Task<RunSummary?> GetSummaryAsync(string runId, CancellationToken cancellationToken = default)
    {
        var existing = await runStateRepository.LoadAsync(runId, cancellationToken);
        if (existing is null)
        {
            return null;
        }

        return new RunSummary(runId, existing.Status, existing.JobStates.Count, existing.JobStates.Count, 0, 0, 0, new Dictionary<string, int> { [existing.Status.ToString()] = 1 }, ["Summary available"], existing.FinalizedArtifacts);
    }
}
