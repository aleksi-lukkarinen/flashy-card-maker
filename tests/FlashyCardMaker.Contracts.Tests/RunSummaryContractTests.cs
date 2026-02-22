namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class RunSummaryContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainSummaryPath()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "/flashcard-runs/{runId}/summary:");
    }
}
