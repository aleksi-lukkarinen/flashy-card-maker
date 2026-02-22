namespace FlashyCardMaker.Core.Models;

public sealed record EffectiveConfigurationSnapshot(
    string SnapshotId,
    IReadOnlyDictionary<string, object?> ResolvedValues,
    IReadOnlyDictionary<string, string> ValueOrigins,
    DateTimeOffset CreatedAtUtc);
