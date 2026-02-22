# Tasks: Consolidated Flashcard Workflow

**Input**: Design documents from `/specs/001-consolidated-flashcard-spec/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Tests**: Tests are REQUIRED for all user stories and integrations per the constitution. Include unit, integration, and contract tests as applicable.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Path Conventions

- Core: `src/FlashyCardMaker.Core/`
- Infrastructure: `src/FlashyCardMaker.Infrastructure/`
- CLI UI: `src/FlashyCardMaker.UI.Cli/`
- Tests: `tests/FlashyCardMaker.*`

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Initialize solution skeleton and baseline test/config tooling for consolidated implementation.

- [X] T001 Create project skeleton folders in `src/FlashyCardMaker.Core/`, `src/FlashyCardMaker.Infrastructure/`, and `src/FlashyCardMaker.UI.Cli/`
- [X] T002 Create test project skeleton folders in `tests/FlashyCardMaker.Core.UnitTests/`, `tests/FlashyCardMaker.Infrastructure.IntegrationTests/`, `tests/FlashyCardMaker.Contracts.Tests/`, and `tests/FlashyCardMaker.UI.Cli.Tests/`
- [X] T003 [P] Add solution and project reference manifest in `FlashyCardMaker.sln`
- [X] T004 [P] Add baseline test configuration and run settings in `tests/Directory.Build.props`
- [X] T005 [P] Add baseline logging and redaction config sample in `src/FlashyCardMaker.UI.Cli/appsettings.json`

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure required before user-story slices.

**CRITICAL**: No user story implementation starts before this phase is complete.

- [X] T006 Implement shared domain abstractions for run orchestration in `src/FlashyCardMaker.Core/Abstractions/IRunOrchestrator.cs`
- [X] T007 [P] Implement shared run/result enums and constants in `src/FlashyCardMaker.Core/Models/RunStatus.cs`
- [X] T008 [P] Implement effective configuration and source-origin model in `src/FlashyCardMaker.Core/Models/EffectiveConfigurationSnapshot.cs`
- [X] T009 [P] Implement validation issue and error taxonomy model in `src/FlashyCardMaker.Core/Models/ValidationIssue.cs`
- [X] T010 Implement configuration merge service with deterministic precedence in `src/FlashyCardMaker.Infrastructure/Configuration/ConfigurationMergeService.cs`
- [X] T011 [P] Implement centralized sensitive-value redaction helper in `src/FlashyCardMaker.Infrastructure/Logging/RedactionPolicy.cs`
- [X] T012 [P] Implement logging setup supporting required levels and rotation options in `src/FlashyCardMaker.Infrastructure/Logging/LoggingBootstrapper.cs`
- [X] T013 Implement base run-state repository interface and file-backed repository in `src/FlashyCardMaker.Infrastructure/Persistence/FileRunStateRepository.cs`
- [X] T014 Implement CLI command root, global options, and DI bootstrap in `src/FlashyCardMaker.UI.Cli/Program.cs`
- [X] T015 Add foundational unit tests for configuration precedence in `tests/FlashyCardMaker.Core.UnitTests/ConfigurationMergeServiceTests.cs`
- [X] T016 Add foundational integration tests for file run-state repository in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/FileRunStateRepositoryTests.cs`

**Checkpoint**: Foundation complete; user stories can proceed.

---

## Phase 3: User Story 1 - Run One End-to-End Generation Workflow (Priority: P1) - MVP

**Goal**: Execute one full multilingual generation run from normalized input to exported outputs.

**Independent Test**: Start a run with valid settings and confirm generated records and per-format output outcomes are produced.

### Tests for User Story 1 (REQUIRED)

- [X] T017 [P] [US1] Add contract tests for start run endpoint in `tests/FlashyCardMaker.Contracts.Tests/StartRunContractTests.cs`
- [X] T018 [P] [US1] Add contract tests for run summary endpoint in `tests/FlashyCardMaker.Contracts.Tests/RunSummaryContractTests.cs`
- [X] T019 [P] [US1] Add integration test for end-to-end generation with multiple outputs in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/GenerationPipelineIntegrationTests.cs`
- [X] T020 [P] [US1] Add CLI integration test for `generate` command happy path in `tests/FlashyCardMaker.UI.Cli.Tests/GenerateCommandTests.cs`
- [X] T021 [P] [US1] Add unit tests for generation record normalization in `tests/FlashyCardMaker.Core.UnitTests/GenerationRecordNormalizerTests.cs`

### Implementation for User Story 1

- [X] T022 [P] [US1] Implement generation run aggregate model in `src/FlashyCardMaker.Core/Models/GenerationRun.cs`
- [X] T023 [P] [US1] Implement generation record model in `src/FlashyCardMaker.Core/Models/GenerationRecord.cs`
- [X] T024 [P] [US1] Implement language-pair assignment model in `src/FlashyCardMaker.Core/Models/LanguagePairAssignment.cs`
- [X] T025 [US1] Implement generation record normalizer service in `src/FlashyCardMaker.Core/Services/GenerationRecordNormalizer.cs`
- [X] T026 [US1] Implement canonical run orchestrator for translation/audio/output fan-out in `src/FlashyCardMaker.Core/Workflows/GenerationRunOrchestrator.cs`
- [X] T027 [P] [US1] Implement output format dispatcher in `src/FlashyCardMaker.Infrastructure/Providers/OutputFormatDispatcher.cs`
- [X] T028 [P] [US1] Implement CSV export writer with stable column mapping in `src/FlashyCardMaker.Infrastructure/Providers/CsvExportWriter.cs`
- [X] T029 [US1] Implement audio output destination resolver in `src/FlashyCardMaker.Infrastructure/Providers/AudioOutputPathResolver.cs`
- [X] T030 [US1] Implement deterministic audio filename generator in `src/FlashyCardMaker.Core/Services/AudioFilenameGenerator.cs`
- [X] T031 [US1] Implement `generate` command handler and mapping in `src/FlashyCardMaker.UI.Cli/Commands/GenerateCommand.cs`
- [X] T032 [US1] Implement run summary presenter for output outcomes in `src/FlashyCardMaker.UI.Cli/Presentation/RunSummaryPresenter.cs`

**Checkpoint**: US1 is independently functional and testable (MVP).

---

## Phase 4: User Story 2 - Configure and Discover Services Safely (Priority: P2)

**Goal**: Validate configuration up front and support voice discovery with actionable errors and secret-safe diagnostics.

**Independent Test**: Run validation and voice discovery commands with valid/invalid provider settings and verify blocking behavior plus messages.

### Tests for User Story 2 (REQUIRED)

- [X] T033 [P] [US2] Add contract tests for validate endpoint in `tests/FlashyCardMaker.Contracts.Tests/ValidateRunContractTests.cs`
- [X] T034 [P] [US2] Add contract tests for voice discovery response mapping in `tests/FlashyCardMaker.Contracts.Tests/VoiceDiscoveryContractTests.cs`
- [X] T035 [P] [US2] Add integration tests for provider preflight validation failures in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/ProviderValidationIntegrationTests.cs`
- [X] T036 [P] [US2] Add CLI tests for `validate` and `voices` commands in `tests/FlashyCardMaker.UI.Cli.Tests/ValidationAndVoiceCommandsTests.cs`
- [X] T037 [P] [US2] Add unit tests for secret redaction in validation and diagnostics in `tests/FlashyCardMaker.Core.UnitTests/SensitiveRedactionTests.cs`

### Implementation for User Story 2

- [X] T038 [P] [US2] Implement provider configuration model in `src/FlashyCardMaker.Core/Models/ProviderConfiguration.cs`
- [X] T039 [P] [US2] Implement voice catalog item model in `src/FlashyCardMaker.Core/Models/VoiceCatalogItem.cs`
- [X] T040 [US2] Implement run preflight validator for language/service/output checks in `src/FlashyCardMaker.Core/Services/RunPreflightValidator.cs`
- [X] T041 [US2] Implement voice discovery service interface and coordinator in `src/FlashyCardMaker.Core/Services/VoiceDiscoveryService.cs`
- [X] T042 [P] [US2] Implement translation provider validation adapter in `src/FlashyCardMaker.Infrastructure/Providers/TranslationProviderValidator.cs`
- [X] T043 [P] [US2] Implement audio provider validation adapter in `src/FlashyCardMaker.Infrastructure/Providers/AudioProviderValidator.cs`
- [X] T044 [US2] Implement voice discovery provider client with request contract enforcement in `src/FlashyCardMaker.Infrastructure/Providers/VoiceDiscoveryProviderClient.cs`
- [X] T045 [US2] Implement CLI `validate` command handler in `src/FlashyCardMaker.UI.Cli/Commands/ValidateCommand.cs`
- [X] T046 [US2] Implement CLI `voices` command handler in `src/FlashyCardMaker.UI.Cli/Commands/VoicesCommand.cs`
- [X] T047 [US2] Implement localized validation message mapping in `src/FlashyCardMaker.UI.Cli/Presentation/ValidationMessagePresenter.cs`

**Checkpoint**: US2 is independently functional and testable.

---

## Phase 5: User Story 3 - Monitor, Recover, and Resume Long Runs (Priority: P3)

**Goal**: Provide progress tracking, partial-failure continuation, and deterministic resume without duplicate outputs.

**Independent Test**: Trigger failures/interruption in a run, verify unaffected jobs continue, then resume and confirm completed jobs are skipped.

### Tests for User Story 3 (REQUIRED)

- [X] T048 [P] [US3] Add contract tests for progress endpoint in `tests/FlashyCardMaker.Contracts.Tests/ProgressContractTests.cs`
- [X] T049 [P] [US3] Add contract tests for resume endpoint in `tests/FlashyCardMaker.Contracts.Tests/ResumeRunContractTests.cs`
- [X] T050 [P] [US3] Add integration tests for retry and threshold stop policies in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/RetryThresholdPolicyTests.cs`
- [X] T051 [P] [US3] Add integration tests for resume skip and non-duplication behavior in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/RunResumeIntegrationTests.cs`
- [X] T052 [P] [US3] Add CLI tests for `status` and `resume` commands in `tests/FlashyCardMaker.UI.Cli.Tests/StatusAndResumeCommandTests.cs`
- [X] T053 [P] [US3] Add unit tests for run summary aggregation and status categories in `tests/FlashyCardMaker.Core.UnitTests/RunSummaryAggregatorTests.cs`

### Implementation for User Story 3

- [X] T054 [P] [US3] Implement job state record model in `src/FlashyCardMaker.Core/Models/JobStateRecord.cs`
- [X] T055 [P] [US3] Implement run summary model in `src/FlashyCardMaker.Core/Models/RunSummary.cs`
- [X] T056 [US3] Implement progress tracker and per-item phase reporting in `src/FlashyCardMaker.Core/Services/RunProgressTracker.cs`
- [X] T057 [US3] Implement retry policy evaluator and failure-threshold policy logic in `src/FlashyCardMaker.Core/Services/RetryAndThresholdPolicy.cs`
- [X] T058 [US3] Implement resume planner that skips completed jobs and selects resumable work in `src/FlashyCardMaker.Core/Services/RunResumePlanner.cs`
- [X] T059 [US3] Extend file run-state repository for interruption-safe snapshot persistence in `src/FlashyCardMaker.Infrastructure/Persistence/FileRunStateRepository.cs`
- [X] T060 [US3] Implement status endpoint/query service in `src/FlashyCardMaker.Core/Workflows/GetRunProgressQuery.cs`
- [X] T061 [US3] Implement resume command workflow service in `src/FlashyCardMaker.Core/Workflows/ResumeGenerationRunWorkflow.cs`
- [X] T062 [US3] Implement CLI `status` command in `src/FlashyCardMaker.UI.Cli/Commands/StatusCommand.cs`
- [X] T063 [US3] Implement CLI `resume` command in `src/FlashyCardMaker.UI.Cli/Commands/ResumeCommand.cs`

**Checkpoint**: US3 is independently functional and testable.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Complete cross-story requirements and release-quality checks.

- [X] T064 [P] Add localization resource files and fallback defaults in `src/FlashyCardMaker.UI.Cli/Presentation/Localization/`
- [X] T065 Add localization runtime selector wiring in `src/FlashyCardMaker.UI.Cli/Program.cs`
- [X] T066 [P] Add integration tests for localization fallback behavior in `tests/FlashyCardMaker.UI.Cli.Tests/LocalizationFallbackTests.cs`
- [X] T067 Add structured logging integration tests for all six levels and rotation settings in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/LoggingConfigurationIntegrationTests.cs`
- [X] T068 [P] Add security regression tests for credential leakage in diagnostics in `tests/FlashyCardMaker.Infrastructure.IntegrationTests/SensitiveDiagnosticsTests.cs`
- [X] T069 Update feature documentation and command examples in `specs/001-consolidated-flashcard-spec/quickstart.md`
- [X] T070 Run quickstart validation and capture verification notes in `specs/001-consolidated-flashcard-spec/research.md`

---

## Dependencies & Execution Order

### Phase Dependencies

- **Phase 1 (Setup)**: No dependencies.
- **Phase 2 (Foundational)**: Depends on Phase 1 and blocks all user stories.
- **Phase 3 (US1)**: Depends on Phase 2; delivers MVP.
- **Phase 4 (US2)**: Depends on Phase 2; can run in parallel with US1 after foundation, but priority is after MVP.
- **Phase 5 (US3)**: Depends on Phase 2 and foundational orchestration from US1.
- **Phase 6 (Polish)**: Depends on all selected user stories completed.

### User Story Dependencies

- **US1 (P1)**: No dependency on other user stories; first releasable slice.
- **US2 (P2)**: Independent execution path; integrates with shared configuration and provider abstractions.
- **US3 (P3)**: Depends on shared run orchestration and persistence established in US1/foundation.

### Within Each User Story

- Tests MUST be written first and failing before implementation tasks begin.
- Models precede services/workflows.
- Services/workflows precede CLI command wiring.
- Story checkpoint requires passing tests for that story.

### Parallel Opportunities

- Foundational tasks marked [P] can run in parallel after T006 is defined.
- Contract, integration, and unit tests marked [P] within each story can run in parallel.
- Model tasks marked [P] within each story can run in parallel.
- US2 work can proceed in parallel with late US1 work after foundational completion.

---

## Parallel Example: User Story 1

```bash
# Parallel test-first tasks
Task: "T017 [US1] Contract tests for start run endpoint in tests/FlashyCardMaker.Contracts.Tests/StartRunContractTests.cs"
Task: "T018 [US1] Contract tests for run summary endpoint in tests/FlashyCardMaker.Contracts.Tests/RunSummaryContractTests.cs"
Task: "T019 [US1] Integration test in tests/FlashyCardMaker.Infrastructure.IntegrationTests/GenerationPipelineIntegrationTests.cs"

# Parallel model tasks
Task: "T022 [US1] Implement generation run model in src/FlashyCardMaker.Core/Models/GenerationRun.cs"
Task: "T023 [US1] Implement generation record model in src/FlashyCardMaker.Core/Models/GenerationRecord.cs"
Task: "T024 [US1] Implement language-pair assignment model in src/FlashyCardMaker.Core/Models/LanguagePairAssignment.cs"
```

---

## Parallel Example: User Story 2

```bash
# Parallel test-first tasks
Task: "T033 [US2] Validate endpoint contract tests in tests/FlashyCardMaker.Contracts.Tests/ValidateRunContractTests.cs"
Task: "T035 [US2] Provider validation integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/ProviderValidationIntegrationTests.cs"

# Parallel provider adapter tasks
Task: "T042 [US2] Translation provider validation adapter in src/FlashyCardMaker.Infrastructure/Providers/TranslationProviderValidator.cs"
Task: "T043 [US2] Audio provider validation adapter in src/FlashyCardMaker.Infrastructure/Providers/AudioProviderValidator.cs"
```

---

## Parallel Example: User Story 3

```bash
# Parallel test-first tasks
Task: "T048 [US3] Progress contract tests in tests/FlashyCardMaker.Contracts.Tests/ProgressContractTests.cs"
Task: "T051 [US3] Resume non-duplication integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/RunResumeIntegrationTests.cs"

# Parallel model tasks
Task: "T054 [US3] Job state record model in src/FlashyCardMaker.Core/Models/JobStateRecord.cs"
Task: "T055 [US3] Run summary model in src/FlashyCardMaker.Core/Models/RunSummary.cs"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational
3. Complete Phase 3: User Story 1
4. Validate US1 independently via T017-T032 before progressing

### Incremental Delivery

1. Deliver MVP with US1 after foundation.
2. Add US2 for preflight validation and voice discovery.
3. Add US3 for progress, recovery, and resume behavior.
4. Finish with Phase 6 cross-cutting localization/logging/security verification.

### Parallel Team Strategy

1. Team aligns on Phase 1 and Phase 2.
2. After foundation:
   - Dev A: US1 orchestration and output flow
   - Dev B: US2 validation and provider discovery
   - Dev C: US3 progress/recovery/resume
3. Integrate via contract tests and shared model checkpoints.

---

## Notes

- Every task follows strict checklist format: checkbox, ID, optional [P], required [USx] in story phases, and exact file path.
- Tests are explicitly required and placed before implementation tasks in each story phase to enforce TDD.
- MVP scope is US1 (Phase 3).
