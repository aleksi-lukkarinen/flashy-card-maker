namespace FlashyCardMaker.UI.Cli;

using FlashyCardMaker.Core.Abstractions;
using FlashyCardMaker.Core.Models;
using FlashyCardMaker.Core.Services;
using FlashyCardMaker.Core.Workflows;
using FlashyCardMaker.Infrastructure.Persistence;
using FlashyCardMaker.UI.Cli.Commands;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var parsed = ParseArgs(args);
        var command = parsed.Command;

        IRunStateRepository repository = new FileRunStateRepository();
        var orchestrator = new GenerationRunOrchestrator(repository, new GenerationRecordNormalizer());

        return command switch
        {
            "generate" => await ExecuteGenerateAsync(orchestrator),
            "validate" => ExecuteValidate(),
            "status" => await ExecuteStatusAsync(orchestrator, parsed.RunId),
            "resume" => await ExecuteResumeAsync(orchestrator, parsed.RunId),
            _ => PrintHelp()
        };
    }

    private static async Task<int> ExecuteGenerateAsync(IRunOrchestrator orchestrator)
    {
        var config = new EffectiveConfigurationSnapshot(
            Guid.NewGuid().ToString("N"),
            new Dictionary<string, object?>(),
            new Dictionary<string, string>(),
            DateTimeOffset.UtcNow);

        var command = new GenerateCommand(orchestrator);
        var result = await command.ExecuteAsync(config, Array.Empty<IDictionary<string, object?>>());
        Console.WriteLine(result.Messages.FirstOrDefault() ?? "Run executed.");
        return result.ExitCode;
    }

    private static int ExecuteValidate()
    {
        var command = new ValidateCommand(new RunPreflightValidator());
        var result = command.Execute(new Dictionary<string, object?>());
        var presenter = new Presentation.ValidationMessagePresenter();
        foreach (var line in presenter.Present(result))
        {
            Console.WriteLine(line);
        }

        return result.IsValid ? RunExitCodes.Success : RunExitCodes.ConfigurationError;
    }

    private static async Task<int> ExecuteStatusAsync(IRunOrchestrator orchestrator, string? runId)
    {
        if (string.IsNullOrWhiteSpace(runId))
        {
            Console.WriteLine("Missing --run-id for status command.");
            return RunExitCodes.ValidationError;
        }

        var progress = await new StatusCommand(new GetRunProgressQuery(orchestrator)).ExecuteAsync(runId);
        Console.WriteLine(progress is null ? "Run not found." : $"Run {progress.RunId}: {progress.RunStatus}");
        return progress is null ? RunExitCodes.RuntimeError : RunExitCodes.Success;
    }

    private static async Task<int> ExecuteResumeAsync(IRunOrchestrator orchestrator, string? runId)
    {
        if (string.IsNullOrWhiteSpace(runId))
        {
            Console.WriteLine("Missing --run-id for resume command.");
            return RunExitCodes.ValidationError;
        }

        var result = await new ResumeCommand(new ResumeGenerationRunWorkflow(orchestrator)).ExecuteAsync(runId);
        Console.WriteLine(result.Messages.FirstOrDefault() ?? "Resume executed.");
        return result.ExitCode;
    }

    private static (string Command, string? RunId) ParseArgs(string[] args)
    {
        var command = args.FirstOrDefault()?.ToLowerInvariant() ?? "help";
        string? runId = null;
        for (var i = 0; i < args.Length - 1; i++)
        {
            if (args[i].Equals("--run-id", StringComparison.OrdinalIgnoreCase))
            {
                runId = args[i + 1];
            }
        }

        return (command, runId);
    }

    private static int PrintHelp()
    {
        Console.WriteLine("FlashyCardMaker CLI commands: generate, validate, status, resume");
        Console.WriteLine("Use --help for command-specific options.");
        return 0;
    }
}
