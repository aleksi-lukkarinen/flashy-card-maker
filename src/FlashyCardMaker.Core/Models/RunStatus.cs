namespace FlashyCardMaker.Core.Models;

public enum RunStatus
{
    Pending,
    Running,
    Completed,
    PartialSuccess,
    Failed,
    Cancelled
}

public enum JobTerminalStatus
{
    Succeeded,
    Failed,
    RetryExhausted,
    SkippedOnResume,
    Aborted
}

public static class RunExitCodes
{
    public const int Success = 0;
    public const int ValidationError = 2;
    public const int ConfigurationError = 3;
    public const int RuntimeError = 4;
    public const int Cancelled = 130;
}
