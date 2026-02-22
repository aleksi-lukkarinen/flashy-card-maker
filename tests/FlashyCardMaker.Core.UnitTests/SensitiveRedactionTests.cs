namespace FlashyCardMaker.Core.UnitTests;

using FlashyCardMaker.Infrastructure.Logging;

[TestClass]
public sealed class SensitiveRedactionTests
{
    [TestMethod]
    public void Redact_ShouldHideValue()
    {
        Assert.AreEqual("***REDACTED***", RedactionPolicy.Redact("secret"));
    }
}
