namespace FlashyCardMaker.Infrastructure.IntegrationTests;

using FlashyCardMaker.Core.Models;
using FlashyCardMaker.Infrastructure.Persistence;

[TestClass]
public sealed class FileRunStateRepositoryTests
{
    [TestMethod]
    public async Task SaveAndLoad_RoundTripsSnapshot()
    {
        var root = Path.Combine(Path.GetTempPath(), "flashy-card-maker-tests", Guid.NewGuid().ToString("N"));
        var sut = new FileRunStateRepository(root);

        var snapshot = new RunStateSnapshot(
            RunId: "run-1",
            Status: RunStatus.Running,
            UpdatedAtUtc: DateTimeOffset.UtcNow,
            FinalizedArtifacts: ["a.csv"],
            JobStates: new Dictionary<string, JobTerminalStatus> { ["job-1"] = JobTerminalStatus.Succeeded });

        await sut.SaveAsync(snapshot);
        var loaded = await sut.LoadAsync("run-1");

        Assert.IsNotNull(loaded);
        Assert.AreEqual(snapshot.RunId, loaded.RunId);
        Assert.AreEqual(JobTerminalStatus.Succeeded, loaded.JobStates["job-1"]);
    }
}
