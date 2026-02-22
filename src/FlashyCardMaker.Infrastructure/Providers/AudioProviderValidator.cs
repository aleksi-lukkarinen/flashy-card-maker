namespace FlashyCardMaker.Infrastructure.Providers;

using FlashyCardMaker.Core.Models;

public sealed class AudioProviderValidator
{
    public ValidationResult Validate(IReadOnlyDictionary<string, object?> settings)
    {
        if (!settings.ContainsKey("voice"))
        {
            return new ValidationResult(false, [new ValidationIssue("AU001", "Missing voice configuration", "voice")], Array.Empty<ValidationIssue>());
        }

        return ValidationResult.Success();
    }
}
