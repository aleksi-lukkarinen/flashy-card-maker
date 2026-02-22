namespace FlashyCardMaker.Core.UnitTests;

using FlashyCardMaker.Core.Services;

[TestClass]
public sealed class GenerationRecordNormalizerTests
{
    [TestMethod]
    public void Normalize_ShouldCreateDeterministicRecordIds()
    {
        var records = new GenerationRecordNormalizer().Normalize([new Dictionary<string, object?> { ["sourceText"] = "hello" }]);
        Assert.AreEqual("record-1", records[0].RecordId);
    }
}
