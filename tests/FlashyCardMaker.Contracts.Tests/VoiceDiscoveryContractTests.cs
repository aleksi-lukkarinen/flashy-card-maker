namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class VoiceDiscoveryContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainProgressSchemaForVoiceWorkflows()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "ProgressSnapshot");
    }
}
