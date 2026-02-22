namespace FlashyCardMaker.Core.Workflows;

using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;

public sealed class ResumeGenerationRunWorkflow(IRunOrchestrator orchestrator)
{
    public Task<RunExecutionResult> ExecuteAsync(string runId, IDictionary<string, object?>? retryOverrides = null, CancellationToken cancellationToken = default)
    {
        return orchestrator.ResumeAsync(runId, retryOverrides, cancellationToken);
    }
}
