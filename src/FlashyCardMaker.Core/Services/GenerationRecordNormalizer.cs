namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class GenerationRecordNormalizer
{
    public IReadOnlyList<GenerationRecord> Normalize(IReadOnlyList<IDictionary<string, object?>> inputs)
    {
        return inputs
            .Select((item, index) => new GenerationRecord(
                RecordId: $"record-{index + 1}",
                SourceLanguage: item.TryGetValue("sourceLanguage", out var lang) ? lang?.ToString() ?? "eng" : "eng",
                SourceText: item.TryGetValue("sourceText", out var text) ? text?.ToString() ?? string.Empty : string.Empty,
                TargetValues: new Dictionary<string, string>(),
                AudioArtifacts: new Dictionary<string, string>(),
                ItemStatus: RunStatus.Pending))
            .ToList();
    }
}
