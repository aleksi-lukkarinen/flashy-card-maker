namespace FlashyCardMaker.Core.Models;

public sealed record GenerationRecord(
    string RecordId,
    string SourceLanguage,
    string SourceText,
    IReadOnlyDictionary<string, string> TargetValues,
    IReadOnlyDictionary<string, string> AudioArtifacts,
    RunStatus ItemStatus);
