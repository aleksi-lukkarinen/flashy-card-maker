namespace FlashyCardMaker.Infrastructure.Providers;

using FlashyCardMaker.Core.Models;

public sealed class TranslationProviderValidator
{
    public ValidationResult Validate(IReadOnlyDictionary<string, object?> settings)
    {
        if (!settings.ContainsKey("provider"))
        {
            return new ValidationResult(false, [new ValidationIssue("TR001", "Missing translation provider", "provider")], Array.Empty<ValidationIssue>());
        }

        return ValidationResult.Success();
    }
}
