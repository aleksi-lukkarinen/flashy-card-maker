namespace FlashyCardMaker.UI.Cli.Presentation;

using FlashyCardMaker.Core.Models;

public sealed class RunSummaryPresenter
{
    public string Present(RunSummary summary)
    {
        return $"Run {summary.RunId}: {summary.Status} (total: {summary.TotalItems}, failed: {summary.FailedItems})";
    }
}
