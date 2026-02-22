# Quickstart: Consolidated Flashcard Workflow

## Prerequisites

- .NET 10 SDK installed
- PowerShell 7+ or shell capable of running `dotnet`
- Supported OS: Windows, macOS, Linux

## 1. Restore and Build

```bash
dotnet restore
dotnet build -c Release
```

## 2. Run Tests (TDD order)

```bash
dotnet test -c Release
```

Required suites for this feature:
- `FlashyCardMaker.Core.UnitTests`
- `FlashyCardMaker.Infrastructure.IntegrationTests`
- `FlashyCardMaker.Contracts.Tests`
- `FlashyCardMaker.UI.Cli.Tests`

## 3. Validate Configuration Before Execution

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- validate --config ./settings.json
```

Expected result: actionable validation output for required languages, provider settings, and output destinations.

## 4. Start a Generation Run

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- generate --config ./settings.json --input ./input/phrases.csv --output ./out
```

## 5. Observe Progress and Summary

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- status --run-id <RUN_ID>
dotnet run --project src/FlashyCardMaker.UI.Cli -- summary --run-id <RUN_ID>
```

## 6. Resume Interrupted or Partial Runs

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- resume --run-id <RUN_ID>
```

Expected behavior: previously successful jobs are skipped and only eligible unfinished/failed jobs are retried.

## 7. Security and Logging Validation

- Confirm logs honor configured level: `none`, `error`, `warning`, `information`, `debug`, `verbose`.
- Confirm log location and rotation follow runtime configuration.
- Confirm no secrets appear in logs, validation messages, or run summaries.
- Confirm localized user-facing output falls back to default locale when translations are missing.
