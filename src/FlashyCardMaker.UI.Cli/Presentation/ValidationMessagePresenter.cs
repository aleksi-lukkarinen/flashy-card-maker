namespace FlashyCardMaker.UI.Cli.Presentation;

using FlashyCardMaker.Core.Models;

public sealed class ValidationMessagePresenter
{
    public IReadOnlyList<string> Present(ValidationResult result)
    {
        if (result.IsValid)
        {
            return ["Configuration is valid."];
        }

        return result.Errors.Select(e => $"{e.Code}: {e.Message}").ToList();
    }
}
