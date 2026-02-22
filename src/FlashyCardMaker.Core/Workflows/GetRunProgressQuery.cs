namespace FlashyCardMaker.Core.Workflows;

using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;

public sealed class GetRunProgressQuery(IRunOrchestrator orchestrator)
{
    public Task<RunProgressSnapshot?> ExecuteAsync(string runId, CancellationToken cancellationToken = default)
    {
        return orchestrator.GetProgressAsync(runId, cancellationToken);
    }
}
