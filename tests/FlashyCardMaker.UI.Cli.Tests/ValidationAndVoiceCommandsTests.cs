namespace FlashyCardMaker.UI.Cli.Tests;

[TestClass]
public sealed class ValidationAndVoiceCommandsTests
{
    [TestMethod]
    public async Task ValidateCommand_ShouldReturnConfigurationErrorForMissingValues()
    {
        var exitCode = await FlashyCardMaker.UI.Cli.Program.Main(["validate"]);
        Assert.AreEqual(3, exitCode);
    }
}
