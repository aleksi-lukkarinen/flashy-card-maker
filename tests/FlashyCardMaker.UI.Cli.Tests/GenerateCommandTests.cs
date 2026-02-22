namespace FlashyCardMaker.UI.Cli.Tests;

[TestClass]
public sealed class GenerateCommandTests
{
    [TestMethod]
    public async Task GenerateCommand_ShouldReturnSuccessExitCode()
    {
        var exitCode = await FlashyCardMaker.UI.Cli.Program.Main(["generate"]);
        Assert.AreEqual(0, exitCode);
    }
}
