namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Core.Services;

[TestClass]
public sealed class RetryThresholdPolicyTests
{
    [TestMethod]
    public void ShouldStopRun_WhenFailureThresholdReached()
    {
        var sut = new RetryAndThresholdPolicy();
        Assert.IsTrue(sut.ShouldStopRun(3, 3));
    }
}
