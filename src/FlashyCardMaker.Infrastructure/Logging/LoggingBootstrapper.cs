namespace FlashyCardMaker.Infrastructure.Logging;

public enum LogLevelOption
{
    None,
    Error,
    Warning,
    Information,
    Debug,
    Verbose
}

public sealed record LoggingOptions(
    LogLevelOption Level,
    string LogDirectory,
    bool RotationEnabled,
    int MaxFileCount,
    int MaxFileSizeMb);

public static class LoggingBootstrapper
{
    public static LoggingOptions CreateDefault() => new(
        Level: LogLevelOption.Information,
        LogDirectory: Path.Combine(Environment.CurrentDirectory, "logs"),
        RotationEnabled: true,
        MaxFileCount: 10,
        MaxFileSizeMb: 20);
}
