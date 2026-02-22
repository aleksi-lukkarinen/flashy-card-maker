namespace FlashyCardMaker.Core.Models;

public sealed record LanguagePairAssignment(
    string SourceLanguage,
    string TargetLanguage,
    string? TranslationProviderId,
    string? AudioProviderId,
    string? VoiceId);
