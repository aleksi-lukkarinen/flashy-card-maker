namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class RetryAndThresholdPolicy
{
    public bool ShouldRetry(int attemptCount, int maxRetries, bool isRecoverableError) => isRecoverableError && attemptCount <= maxRetries;

    public bool ShouldStopRun(int currentFailures, int threshold) => threshold > 0 && currentFailures >= threshold;
}
