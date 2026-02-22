namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Core.Models;
using FlashyCardMaker.Core.Services;

[TestClass]
public sealed class RunResumeIntegrationTests
{
    [TestMethod]
    public void ResumePlanner_ShouldIncludeFailedJobsOnly()
    {
        var jobs = new Dictionary<string, JobTerminalStatus>
        {
            ["a"] = JobTerminalStatus.Succeeded,
            ["b"] = JobTerminalStatus.Failed
        };

        var result = new RunResumePlanner().SelectJobIdsToResume(jobs);
        CollectionAssert.AreEquivalent(["b"], result.ToList());
    }
}
