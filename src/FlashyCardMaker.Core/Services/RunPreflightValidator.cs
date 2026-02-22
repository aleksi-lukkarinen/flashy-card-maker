namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class RunPreflightValidator
{
    public ValidationResult Validate(IReadOnlyDictionary<string, object?> configuration)
    {
        var errors = new List<ValidationIssue>();

        if (!configuration.ContainsKey("sourceLanguages"))
        {
            errors.Add(new ValidationIssue("CFG001", "Missing source language configuration", "sourceLanguages"));
        }

        if (!configuration.ContainsKey("targetLanguages"))
        {
            errors.Add(new ValidationIssue("CFG002", "Missing target language configuration", "targetLanguages"));
        }

        return errors.Count == 0
            ? ValidationResult.Success()
            : new ValidationResult(false, errors, Array.Empty<ValidationIssue>());
    }
}
