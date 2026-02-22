namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class StartRunContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainStartRunPath()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "/flashcard-runs:");
    }
}
