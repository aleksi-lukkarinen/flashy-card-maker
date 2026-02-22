namespace FlashyCardMaker.UI.Cli.Commands;

using FlashyCardMaker.Core.Workflows;
using FlashyCardMaker.Core.Models;

public sealed class StatusCommand(GetRunProgressQuery query)
{
    public Task<RunProgressSnapshot?> ExecuteAsync(string runId, CancellationToken cancellationToken = default) => query.ExecuteAsync(runId, cancellationToken);
}
