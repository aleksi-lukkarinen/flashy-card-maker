namespace FlashyCardMaker.Core.Abstractions;

using FlashyCardMaker.Core.Models;

public interface IRunStateRepository
{
    Task SaveAsync(RunStateSnapshot snapshot, CancellationToken cancellationToken = default);

    Task<RunStateSnapshot?> LoadAsync(string runId, CancellationToken cancellationToken = default);
}
