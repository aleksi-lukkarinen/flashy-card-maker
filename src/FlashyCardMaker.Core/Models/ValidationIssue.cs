namespace FlashyCardMaker.Core.Models;

public enum ValidationSeverity
{
    Error,
    Warning
}

public sealed record ValidationIssue(
    string Code,
    string Message,
    string? Field = null,
    ValidationSeverity Severity = ValidationSeverity.Error);

public sealed record ValidationResult(bool IsValid, IReadOnlyList<ValidationIssue> Errors, IReadOnlyList<ValidationIssue> Warnings)
{
    public static ValidationResult Success() => new(true, Array.Empty<ValidationIssue>(), Array.Empty<ValidationIssue>());
}
