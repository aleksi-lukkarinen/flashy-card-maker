namespace FlashyCardMaker.Core.Abstractions;

using FlashyCardMaker.Core.Models;

public interface IRunOrchestrator
{
    Task<RunExecutionResult> StartAsync(EffectiveConfigurationSnapshot configuration, IReadOnlyList<IDictionary<string, object?>> sourceInputs, CancellationToken cancellationToken = default);

    Task<RunExecutionResult> ResumeAsync(string runId, IDictionary<string, object?>? retryOverrides = null, CancellationToken cancellationToken = default);

    Task<RunProgressSnapshot?> GetProgressAsync(string runId, CancellationToken cancellationToken = default);

    Task<RunSummary?> GetSummaryAsync(string runId, CancellationToken cancellationToken = default);
}
