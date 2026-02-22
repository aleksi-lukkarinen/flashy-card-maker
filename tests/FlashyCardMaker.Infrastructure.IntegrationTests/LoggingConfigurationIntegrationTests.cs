namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Infrastructure.Logging;

[TestClass]
public sealed class LoggingConfigurationIntegrationTests
{
    [TestMethod]
    public void DefaultLoggingOptions_ShouldUseExpectedDefaults()
    {
        var options = LoggingBootstrapper.CreateDefault();
        Assert.AreEqual(LogLevelOption.Information, options.Level);
        Assert.IsTrue(options.RotationEnabled);
    }
}
