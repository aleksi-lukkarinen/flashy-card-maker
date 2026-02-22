namespace FlashyCardMaker.Core.Models;

public sealed record JobStateRecord(
    string JobId,
    string RecordId,
    int AttemptCount,
    int MaxRetries,
    JobTerminalStatus TerminalStatus,
    string? LastErrorCode);
