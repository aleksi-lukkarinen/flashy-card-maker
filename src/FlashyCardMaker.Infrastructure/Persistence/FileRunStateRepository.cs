namespace FlashyCardMaker.Infrastructure.Persistence;

using System.Text.Json;
using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;

public sealed class FileRunStateRepository : IRunStateRepository
{
    private readonly string _stateDirectory;

    public FileRunStateRepository(string? stateDirectory = null)
    {
        _stateDirectory = stateDirectory ?? Path.Combine(Environment.CurrentDirectory, "run-state");
    }

    public async Task SaveAsync(RunStateSnapshot snapshot, CancellationToken cancellationToken = default)
    {
        Directory.CreateDirectory(_stateDirectory);
        var path = GetPath(snapshot.RunId);
        await using var stream = File.Create(path);
        await JsonSerializer.SerializeAsync(stream, snapshot, cancellationToken: cancellationToken);
    }

    public async Task<RunStateSnapshot?> LoadAsync(string runId, CancellationToken cancellationToken = default)
    {
        var path = GetPath(runId);
        if (!File.Exists(path))
        {
            return null;
        }

        await using var stream = File.OpenRead(path);
        return await JsonSerializer.DeserializeAsync<RunStateSnapshot>(stream, cancellationToken: cancellationToken);
    }

    private string GetPath(string runId) => Path.Combine(_stateDirectory, $"{runId}.json");
}
