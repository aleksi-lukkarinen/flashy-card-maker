namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Core.Services;

[TestClass]
public sealed class ProviderValidationIntegrationTests
{
    [TestMethod]
    public void PreflightValidator_ShouldReturnErrorsWhenMissingRequiredFields()
    {
        var result = new RunPreflightValidator().Validate(new Dictionary<string, object?>());
        Assert.IsFalse(result.IsValid);
    }
}
