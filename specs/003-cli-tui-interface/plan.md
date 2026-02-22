# Implementation Plan: CLI/TUI First Interface

**Branch**: `003-cli-tui-interface` | **Date**: 2026-02-22 | **Spec**: `F:\dev\C#\flashy-card-maker\specs\003-cli-tui-interface\spec.md`  
**Input**: Feature specification from `F:\dev\C#\flashy-card-maker\specs\003-cli-tui-interface\spec.md`

## Summary

Deliver the first production-grade CLI/TUI interface as a separate UI adapter project over shared business logic. The implementation uses hierarchical commands, dual short/long aliases, comprehensive hierarchical help, deterministic configuration merging from file plus command line, Serilog-based structured logging, and cross-platform support on Windows/macOS/Linux. The design enforces modular boundaries so future UIs can reuse the same application core unchanged.

## Technical Context

**Language/Version**: C# 14 on .NET 10  
**Primary Dependencies**: `System.CommandLine` (hierarchical parser/help), `Spectre.Console` (modern TUI rendering), `Microsoft.Extensions.Configuration.*` (configuration pipeline), `Serilog` + file/console sinks  
**Storage**: Local file system for configuration and logs; no database for this feature  
**Testing**: MSTest 4 with unit, integration, and contract tests  
**Target Platform**: Windows, macOS, Linux (x64/arm64 where supported by .NET 10)  
**Project Type**: Multi-project solution (`core/application` + `ui/cli`)  
**Performance Goals**: Help command startup median < 500 ms; non-help command startup median < 1 s before workload execution on CI baseline  
**Constraints**: No secrets in code; logs redact sensitive fields; all switches support long+short aliases; help aliases include `--help`, `-h`, `/?`  
**Scale/Scope**: Single-user local CLI execution, one primary workflow slice plus extensible command architecture

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

- [x] Modular architecture defined: CLI/TUI adapter project depends on application services/contracts only; business logic stays UI-agnostic.
- [x] TDD workflow enforced: every feature increment starts with failing MSTest coverage; red-green-refactor evidence required in PR.
- [x] Integration tests planned for module boundaries and I/O paths: config loading, CLI parsing, logging sink behavior, signal handling, and end-to-end command execution.
- [x] Logging plan includes six levels (`none`, `error`, `warning`, `information`, `debug`, `verbose`), with runtime-configurable sink path and rotation.
- [x] No secrets in program code; sensitive values injected from config/input and redacted in output.

## Project Structure

### Documentation (this feature)

```text
specs/003-cli-tui-interface/
|-- plan.md
|-- research.md
|-- data-model.md
|-- quickstart.md
|-- contracts/
|   `-- openapi.yaml
`-- tasks.md
```

### Source Code (repository root)

```text
src/
|-- FlashyCardMaker.Core/
|   |-- Abstractions/
|   |-- UseCases/
|   `-- Models/
|-- FlashyCardMaker.Infrastructure/
|   |-- Configuration/
|   |-- Logging/
|   `-- Providers/
`-- FlashyCardMaker.UI.Cli/
    |-- Commands/
    |-- Help/
    |-- Tui/
    |-- Mapping/
    `-- Program.cs

tests/
|-- FlashyCardMaker.Core.UnitTests/
|-- FlashyCardMaker.Infrastructure.IntegrationTests/
`-- FlashyCardMaker.UI.Cli.Tests/
```

**Structure Decision**: Use a modular multi-project structure to enforce UI/application separation and keep future UI adapters additive.

## Phase Plan

### Phase 0 - Research and Decisions

- Finalize parser/TUI stack and document rationale (`System.CommandLine` + `Spectre.Console`).
- Define alias policy (all options must include exactly one short alias and one long alias unless reserved by parser).
- Define precedence and redaction policy for configuration keys.
- Define terminal compatibility/fallback behavior for limited-capability shells.

### Phase 1 - Design and Contracts

- Define command tree contract and normalized execution request model.
- Define effective configuration model and merge pipeline with source attribution.
- Define internal application service contract for command execution.
- Define exit-code map and error classification.
- Publish contracts in `contracts/openapi.yaml` for workflow service boundary.

### Phase 2 - Implementation Planning

- Build in vertical slices:
1. Command parser + help system.
2. Configuration providers + validation + effective config rendering.
3. TUI presentation + non-interactive fallback + cancellation.
4. Logging/observability + security redaction.
5. Cross-platform integration tests and performance guardrails.

## Test Strategy

- Unit tests: command option binding, alias uniqueness, precedence, validation rules, exit-code mapping, redaction logic.
- Integration tests: full command invocation, config file + CLI merge, help rendering, Serilog sink behavior, cancellation signal handling.
- Contract tests: request/response schema checks against `contracts/openapi.yaml`.
- Security tests: secret leakage checks for logs/help/error messages, path traversal handling for config file paths.
- Cross-platform CI matrix: Windows latest, Ubuntu latest, macOS latest.
- Performance tests: startup-time benchmark for help and minimal command execution.

## Risks and Mitigations

- Risk: Parser alias collisions in deep command hierarchies.  
  Mitigation: static alias uniqueness test and build-time validation.
- Risk: TUI rendering inconsistencies by terminal.  
  Mitigation: capability detection and deterministic fallback rendering mode.
- Risk: Sensitive data leakage in diagnostics.  
  Mitigation: centralized redaction policy with deny-by-default sensitive key patterns.
- Risk: Future UI coupling to CLI-specific models.  
  Mitigation: mapper layer and shared UI-agnostic request contracts in core.

## Complexity Tracking

No constitution violations identified at planning time.