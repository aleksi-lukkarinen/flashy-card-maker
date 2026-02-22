namespace FlashyCardMaker.UI.Cli.Commands;

using FlashyCardMaker.Core.Services;
using FlashyCardMaker.Core.Models;

public sealed class ValidateCommand(RunPreflightValidator validator)
{
    public ValidationResult Execute(IReadOnlyDictionary<string, object?> configuration) => validator.Validate(configuration);
}
