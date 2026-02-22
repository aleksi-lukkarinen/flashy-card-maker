namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Core.Services;

[TestClass]
public sealed class GenerationPipelineIntegrationTests
{
    [TestMethod]
    public void Normalizer_ShouldProduceRecords()
    {
        var records = new GenerationRecordNormalizer().Normalize([new Dictionary<string, object?> { ["sourceText"] = "hello" }]);
        Assert.AreEqual(1, records.Count);
    }
}
