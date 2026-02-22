namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class RunProgressTracker
{
    public RunProgressSnapshot Create(string runId, int totalItems, int completedItems, long elapsedMs)
    {
        return new RunProgressSnapshot(runId, RunStatus.Running, totalItems, completedItems, elapsedMs, Array.Empty<ItemProgressSnapshot>());
    }
}
