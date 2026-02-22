namespace FlashyCardMaker.Core.Models;

public sealed record GenerationRun(
    string RunId,
    DateTimeOffset RequestedAtUtc,
    string Locale,
    string ConfigurationSnapshotId,
    RunStatus Status,
    DateTimeOffset? StartedAtUtc,
    DateTimeOffset? CompletedAtUtc);
