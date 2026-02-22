namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class RunResumePlanner
{
    public IReadOnlyList<string> SelectJobIdsToResume(IReadOnlyDictionary<string, JobTerminalStatus> jobStates)
    {
        return jobStates
            .Where(kvp => kvp.Value is JobTerminalStatus.Failed or JobTerminalStatus.RetryExhausted or JobTerminalStatus.Aborted)
            .Select(kvp => kvp.Key)
            .ToList();
    }
}
