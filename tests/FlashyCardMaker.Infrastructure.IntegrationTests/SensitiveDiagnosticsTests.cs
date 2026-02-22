namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Infrastructure.Logging;

[TestClass]
public sealed class SensitiveDiagnosticsTests
{
    [TestMethod]
    public void RedactionPolicy_ShouldDetectSensitiveKeys()
    {
        Assert.IsTrue(RedactionPolicy.IsSensitiveKey("apiKey"));
    }
}
