# Implementation Plan: Consolidated Flashcard Workflow

**Branch**: `001-consolidated-flashcard-spec` | **Date**: 2026-02-22 | **Spec**: `specs/001-consolidated-flashcard-spec/spec.md`
**Input**: Feature specification from `specs/001-consolidated-flashcard-spec/spec.md`

## Summary

Deliver one canonical, modular flashcard workflow that unifies duplicated feature requirements into a single execution path: configurable multilingual generation, provider validation and voice discovery, multi-format output, progress tracking, partial-failure recovery with resume, configurable logging, and localization-ready user messaging.

## Technical Context

**Language/Version**: C# 14 on .NET 10  
**Primary Dependencies**: `System.CommandLine`, `Spectre.Console`, `Microsoft.Extensions.Configuration.*`, `Serilog`, .NET HTTP abstractions  
**Storage**: File system for input data, output artifacts, logs, and run-state snapshots  
**Testing**: MSTest 4 unit, integration, and contract test suites  
**Target Platform**: Windows, macOS, Linux  
**Project Type**: Modular multi-project CLI/TUI application with UI adapter over shared workflow services  
**Performance Goals**: Median startup for non-workload commands under 1 second; stable progress updates at user-visible cadence; successful completion of at least 95% valid runs  
**Constraints**: No secrets in code, all sensitive values redacted in diagnostics, deterministic configuration precedence, resumable run state, graceful partial-failure handling  
**Scale/Scope**: Single-user local execution, thousands of records per run, multiple source/target languages, and multiple output formats per run

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

- [x] Modular architecture defined: UI adapter remains isolated from core workflow, provider, and export modules.
- [x] TDD workflow enforced: plan requires red-green-refactor evidence per story slice before merge.
- [x] Integration tests planned for all module integrations and I/O paths: provider calls, file outputs, and persisted run state.
- [x] Logging plan includes six levels (`none`, `error`, `warning`, `information`, `debug`, `verbose`), and user-configurable rotation/location.
- [x] No secrets in program code; sensitive values sourced from runtime input/configuration and redacted in logs.

## Project Structure

### Documentation (this feature)

```text
specs/001-consolidated-flashcard-spec/
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
|   |-- Models/
|   |-- Services/
|   `-- Workflows/
|-- FlashyCardMaker.Infrastructure/
|   |-- Configuration/
|   |-- Providers/
|   |-- Persistence/
|   `-- Logging/
`-- FlashyCardMaker.UI.Cli/
    |-- Commands/
    |-- Mapping/
    |-- Presentation/
    `-- Program.cs

tests/
|-- FlashyCardMaker.Core.UnitTests/
|-- FlashyCardMaker.Infrastructure.IntegrationTests/
|-- FlashyCardMaker.Contracts.Tests/
`-- FlashyCardMaker.UI.Cli.Tests/
```

**Structure Decision**: Use a modular multi-project structure so consolidated behavior is implemented once in core services and reused by the CLI/TUI adapter without UI-specific coupling.

## Phase Plan

### Phase 0 - Research and Decisions

- Finalize canonical run orchestration model that replaces duplicated legacy flow variants.
- Define provider validation and error taxonomy for translation, voice discovery, and audio generation.
- Define resume-state persistence semantics and retry/threshold interaction behavior.
- Define logging/redaction rules and localization fallback policy for all user-facing messages.

### Phase 1 - Design and Contracts

- Model consolidated entities, state transitions, and validation rules.
- Publish internal workflow contract for run, validation, progress, and resume operations.
- Define output contract for CSV and language-specific audio artifact routing.
- Define structured run summary and status-category result contract.

### Phase 2 - Implementation Planning

1. Implement configuration, validation, and effective-settings visibility slice.
2. Implement generation pipeline slice with provider integration and progress reporting.
3. Implement output/export slice (CSV plus audio destination resolution and filename policy).
4. Implement resilience slice (retry, thresholds, run-state persistence, resume).
5. Implement localization and observability slice with contract and integration verification.

## Test Strategy

- Unit tests: validation rules, configuration precedence, filename policy, summary aggregation, status transitions.
- Integration tests: provider interaction success/failure, file output routing, run-state persistence/resume, logging sink behavior.
- Contract tests: schema conformance to `contracts/openapi.yaml` for workflow request/response payloads.
- Security tests: secret redaction in logs, blocked execution on missing required sensitive config, no credential leakage in errors.
- Resilience tests: partial failure continuation, retry exhaustion behavior, threshold stop policy, deterministic resume after interruption.

## Risks and Mitigations

- Risk: Consolidation introduces requirement conflicts hidden in legacy specs.  
  Mitigation: One canonical contract with explicit status and validation taxonomy.
- Risk: Resume semantics may produce duplicate outputs.  
  Mitigation: Persist finalized artifact references and skip completed jobs deterministically.
- Risk: Provider-specific failures degrade user trust.  
  Mitigation: Preflight validation, categorized errors, and per-item outcome reporting.
- Risk: Large runs overwhelm progress rendering/logging.  
  Mitigation: Bounded update cadence and structured, level-aware diagnostics.

## Post-Design Constitution Check

- [x] Modular architecture preserved in data model and contract boundaries.
- [x] TDD-first delivery remains required for each Phase 2 implementation slice.
- [x] Integration test obligations are explicitly mapped for file/network paths and failure behavior.
- [x] Logging requirements (six levels, rotation, location) remain represented in contracts and quickstart validation.
- [x] Secret-handling requirements remain enforced through validation and centralized redaction.

## Complexity Tracking

No constitution violations identified at planning time.
