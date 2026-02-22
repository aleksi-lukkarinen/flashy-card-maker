namespace FlashyCardMaker.UI.Cli.Commands;

using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;

public sealed class GenerateCommand(IRunOrchestrator orchestrator)
{
    public Task<RunExecutionResult> ExecuteAsync(EffectiveConfigurationSnapshot config, IReadOnlyList<IDictionary<string, object?>> inputs, CancellationToken cancellationToken = default)
        => orchestrator.StartAsync(config, inputs, cancellationToken);
}
