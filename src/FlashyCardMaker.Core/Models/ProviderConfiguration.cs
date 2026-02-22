namespace FlashyCardMaker.Core.Models;

public sealed record ProviderConfiguration(
    string ProviderId,
    string ProviderType,
    IReadOnlyDictionary<string, object?> Settings,
    bool IsValid,
    IReadOnlyList<ValidationIssue> ValidationErrors);
