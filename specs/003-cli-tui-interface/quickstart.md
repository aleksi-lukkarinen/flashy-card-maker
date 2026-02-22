# Quickstart: CLI/TUI First Interface

## Prerequisites

- .NET 10 SDK installed
- PowerShell 7+ or shell capable of invoking `dotnet`
- Supported OS: Windows, macOS, Linux

## 1. Restore and Build

```bash
dotnet restore
dotnet build -c Release
```

## 2. Run Tests (TDD sequence)

```bash
dotnet test --configuration Release
```

Required suites for this feature:
- `FlashyCardMaker.Core.UnitTests`
- `FlashyCardMaker.Infrastructure.IntegrationTests`
- `FlashyCardMaker.UI.Cli.Tests`

## 3. Explore CLI Help

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- --help
dotnet run --project src/FlashyCardMaker.UI.Cli -- -h
dotnet run --project src/FlashyCardMaker.UI.Cli -- /?
```

## 4. Run with Config File and Overrides

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- generate --config ./settings.json --source ./input.csv --output ./out --log-level information
```

Example override behavior (CLI beats file values):

```bash
dotnet run --project src/FlashyCardMaker.UI.Cli -- generate --config ./settings.json --log-level debug
```

## 5. Validate Exit Codes

- `0`: success
- `2`: usage/validation error
- `3`: configuration error
- `4`: runtime processing error
- `130`: cancelled/interrupted

## 6. Cross-Platform Validation

Run the integration suite on each supported OS:

```bash
dotnet test tests/FlashyCardMaker.UI.Cli.Tests -c Release
```

## 7. Security Validation Checklist

- No secrets in source files.
- Sensitive config keys are redacted in logs/errors/effective config output.
- Config file path inputs reject traversal outside allowed roots when policy is enabled.