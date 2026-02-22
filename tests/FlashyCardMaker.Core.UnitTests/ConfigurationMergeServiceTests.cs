namespace FlashyCardMaker.Core.UnitTests;

using FlashyCardMaker.Infrastructure.Configuration;

[TestClass]
public sealed class ConfigurationMergeServiceTests
{
    [TestMethod]
    public void Merge_CommandLineOverridesFileValues()
    {
        var file = new Dictionary<string, object?>
        {
            ["logLevel"] = "information",
            ["outputPath"] = "from-file"
        };

        var cli = new Dictionary<string, object?>
        {
            ["logLevel"] = "debug"
        };

        var sut = new ConfigurationMergeService();
        var merged = sut.Merge(file, cli);

        Assert.AreEqual("debug", merged.ResolvedValues["logLevel"]);
        Assert.AreEqual("from-file", merged.ResolvedValues["outputPath"]);
        Assert.AreEqual("command-line", merged.ValueOrigins["logLevel"]);
        Assert.AreEqual("file", merged.ValueOrigins["outputPath"]);
    }
}
