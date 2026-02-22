namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class ProgressContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainProgressPath()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "/flashcard-runs/{runId}/progress:");
    }
}
