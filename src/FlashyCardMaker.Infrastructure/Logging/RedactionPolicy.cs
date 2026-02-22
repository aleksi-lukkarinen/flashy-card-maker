namespace FlashyCardMaker.Infrastructure.Logging;

public static class RedactionPolicy
{
    private static readonly string[] SensitiveMarkers = ["token", "key", "password", "secret", "authorization"];

    public static bool IsSensitiveKey(string key)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            return false;
        }

        return SensitiveMarkers.Any(marker => key.Contains(marker, StringComparison.OrdinalIgnoreCase));
    }

    public static string Redact(string value) => string.IsNullOrEmpty(value) ? value : "***REDACTED***";
}
