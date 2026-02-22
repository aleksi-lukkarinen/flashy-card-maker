namespace FlashyCardMaker.UI.Cli.Tests;

[TestClass]
public sealed class LocalizationFallbackTests
{
    [TestMethod]
    public void LocalizationMessages_ShouldContainDefaultLocale()
    {
        var text = File.ReadAllText(Path.Combine("src", "FlashyCardMaker.UI.Cli", "Presentation", "Localization", "messages.json"));
        StringAssert.Contains(text, "en-US");
    }
}
