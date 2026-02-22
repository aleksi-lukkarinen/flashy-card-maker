namespace FlashyCardMaker.Contracts.Tests;

[TestClass]
public sealed class ValidateRunContractTests
{
    [TestMethod]
    public void OpenApi_ShouldContainValidatePath()
    {
        var text = File.ReadAllText(Path.Combine("specs", "001-consolidated-flashcard-spec", "contracts", "openapi.yaml"));
        StringAssert.Contains(text, "/flashcard-runs/validate:");
    }
}
