namespace FlashyCardMaker.Core.UnitTests;

using FlashyCardMaker.Core.Models;
using FlashyCardMaker.UI.Cli.Presentation;

[TestClass]
public sealed class RunSummaryAggregatorTests
{
    [TestMethod]
    public void Presenter_ShouldRenderSummary()
    {
        var summary = new RunSummary("run", RunStatus.Completed, 1, 1, 0, 0, 10, new Dictionary<string, int>(), ["ok"], ["a.csv"]);
        var text = new RunSummaryPresenter().Present(summary);
        StringAssert.Contains(text, "Run run");
    }
}
