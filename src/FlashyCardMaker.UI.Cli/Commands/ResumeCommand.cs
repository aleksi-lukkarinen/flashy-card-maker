namespace FlashyCardMaker.UI.Cli.Commands;

using FlashyCardMaker.Core.Models;
using FlashyCardMaker.Core.Workflows;

public sealed class ResumeCommand(ResumeGenerationRunWorkflow workflow)
{
    public Task<RunExecutionResult> ExecuteAsync(string runId, CancellationToken cancellationToken = default)
        => workflow.ExecuteAsync(runId, null, cancellationToken);
}
