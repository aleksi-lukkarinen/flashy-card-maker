namespace FlashyCardMaker.Core.Models;

public sealed record RunExecutionResult(
    string RunId,
    RunStatus Status,
    int ExitCode,
    IReadOnlyList<string> Messages);

public sealed record ItemProgressSnapshot(
    string RecordId,
    string Phase,
    RunStatus Status,
    double? Percent);

public sealed record RunProgressSnapshot(
    string RunId,
    RunStatus RunStatus,
    int TotalItems,
    int CompletedItems,
    long ElapsedMs,
    IReadOnlyList<ItemProgressSnapshot> ItemProgress);

public sealed record RunStateSnapshot(
    string RunId,
    RunStatus Status,
    DateTimeOffset UpdatedAtUtc,
    IReadOnlyList<string> FinalizedArtifacts,
    IReadOnlyDictionary<string, JobTerminalStatus> JobStates);
