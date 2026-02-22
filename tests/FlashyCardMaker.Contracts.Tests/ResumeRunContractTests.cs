namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class ResumeRunContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainResumePath()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "/flashcard-runs/{runId}/resume:");
    }
}
