namespace FlashyCardMaker.UI.Cli.Tests;

[TestClass]
public sealed class StatusAndResumeCommandTests
{
    [TestMethod]
    public async Task StatusCommand_WithoutRunId_ShouldReturnValidationError()
    {
        var exitCode = await FlashyCardMaker.UI.Cli.Program.Main(["status"]);
        Assert.AreEqual(2, exitCode);
    }
}
