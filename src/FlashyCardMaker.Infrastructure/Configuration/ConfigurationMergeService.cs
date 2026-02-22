namespace FlashyCardMaker.Infrastructure.Configuration;

using FlashyCardMaker.Core.Models;

public sealed class ConfigurationMergeService
{
    public EffectiveConfigurationSnapshot Merge(
        IReadOnlyDictionary<string, object?>? fileConfiguration,
        IReadOnlyDictionary<string, object?>? commandLineConfiguration,
        IReadOnlySet<string>? sensitiveKeys = null)
    {
        var merged = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
        var origins = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        if (fileConfiguration is not null)
        {
            foreach (var kvp in fileConfiguration)
            {
                merged[kvp.Key] = kvp.Value;
                origins[kvp.Key] = "file";
            }
        }

        if (commandLineConfiguration is not null)
        {
            foreach (var kvp in commandLineConfiguration)
            {
                merged[kvp.Key] = kvp.Value;
                origins[kvp.Key] = "command-line";
            }
        }

        return new EffectiveConfigurationSnapshot(
            SnapshotId: Guid.NewGuid().ToString("N"),
            ResolvedValues: merged,
            ValueOrigins: origins,
            CreatedAtUtc: DateTimeOffset.UtcNow);
    }
}
