namespace FlashyCardMaker.Core.Models;

public sealed record RunSummary(
    string RunId,
    RunStatus Status,
    int TotalItems,
    int SucceededItems,
    int FailedItems,
    int SkippedItems,
    long DurationMs,
    IReadOnlyDictionary<string, int> StatusBreakdown,
    IReadOnlyList<string> Messages,
    IReadOnlyList<string> Artifacts);
