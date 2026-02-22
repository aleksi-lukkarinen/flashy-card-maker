# Tasks: CLI/TUI First Interface  **Input**: Design documents from specs/003-cli-tui-interface/ **Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md  **Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory: failing tests first.  ## Phase 1: Setup (Shared Infrastructure)  **Purpose**: Initialize feature module, tests, and pipeline hooks. 
- [ ] T001 Create 003-cli-tui-interface module scaffold in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/CliTuiInterface.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T002 Create 003-cli-tui-interface test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/003-cli-tui-interface/CliTuiInterface.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T003 [P] Add 003-cli-tui-interface registration in src/FlashyCardMaker.Infrastructure/Composition/CliTuiInterface.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T004 [P] Add CI filter stage for 003-cli-tui-interface in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Establish contracts, validation, boundary tests, and observability before story implementation.

- [ ] T005 Define 003-cli-tui-interface contracts in src/FlashyCardMaker.Core/Contracts/003-cli-tui-interface/CliTuiInterface.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T006 [P] Implement 003-cli-tui-interface validation pipeline in src/FlashyCardMaker.Core/Validation/003-cli-tui-interface/CliTuiInterface.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T007 [P] Implement 003-cli-tui-interface result model in src/FlashyCardMaker.Core/Models/003-cli-tui-interface/CliTuiInterface.Result.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T008 Add feature boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/CliTuiInterface.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T009 Configure 003-cli-tui-interface structured logging in src/FlashyCardMaker.Infrastructure/Logging/003-cli-tui-interface/CliTuiInterface.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)

**Checkpoint**: Foundational phase complete; story phases can proceed.

---

## Phase 
3
: User Story 
1
 - 
Run Card Generation from Structured CLI Commands
 (Priority: 
P1
)

**Goal**: Deliver User Story 
1
 functionality for 
Run Card Generation from Structured CLI Commands
.

**Independent Test**: 
Can be tested by invoking supported commands with valid and invalid option combinations and validating behavior and exit codes.

### Tests for User Story 
1
 (REQUIRED)

- [ ] T010 [P] [US1] Write failing unit tests for Run Card Generation from Structured CLI Commands in tests/FlashyCardMaker.Core.UnitTests/Features/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.UnitTests.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T011 [P] [US1] Write failing integration tests for Run Card Generation from Structured CLI Commands in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.IntegrationTests.cs (FR-001, FR-004, FR-007, FR-010, FR-013)

### Implementation for User Story 
1

- [ ] T012 [US1] Create story 1 domain model for Run Card Generation from Structured CLI Commands in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.Model.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T013 [US1] Implement story 1 service workflow for Run Card Generation from Structured CLI Commands in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.Service.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T014 [US1] Implement story 1 adapter mapping for Run Card Generation from Structured CLI Commands in src/FlashyCardMaker.UI.Cli/Features/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.Adapter.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T015 [US1] Add story 1 observability and error mapping for Run Card Generation from Structured CLI Commands in src/FlashyCardMaker.Infrastructure/Observability/003-cli-tui-interface/Story1/RunCardGenerationFromStructuredCliCommands.Observability.cs (FR-001, FR-004, FR-007, FR-010, FR-013)

**Checkpoint**: User Story 
1
 is independently functional and testable.

---

## Phase 
4
: User Story 
2
 - 
Understand Usage Through Hierarchical Help
 (Priority: 
P2
)

**Goal**: Deliver User Story 
2
 functionality for 
Understand Usage Through Hierarchical Help
.

**Independent Test**: 
Can be tested by invoking top-level and command-specific help using all supported help aliases.

### Tests for User Story 
2
 (REQUIRED)

- [ ] T016 [P] [US2] Write failing unit tests for Understand Usage Through Hierarchical Help in tests/FlashyCardMaker.Core.UnitTests/Features/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.UnitTests.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T017 [P] [US2] Write failing integration tests for Understand Usage Through Hierarchical Help in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.IntegrationTests.cs (FR-002, FR-005, FR-008, FR-011, FR-014)

### Implementation for User Story 
2

- [ ] T018 [US2] Create story 2 domain model for Understand Usage Through Hierarchical Help in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.Model.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T019 [US2] Implement story 2 service workflow for Understand Usage Through Hierarchical Help in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.Service.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T020 [US2] Implement story 2 adapter mapping for Understand Usage Through Hierarchical Help in src/FlashyCardMaker.UI.Cli/Features/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.Adapter.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T021 [US2] Add story 2 observability and error mapping for Understand Usage Through Hierarchical Help in src/FlashyCardMaker.Infrastructure/Observability/003-cli-tui-interface/Story2/UnderstandUsageThroughHierarchicalHelp.Observability.cs (FR-002, FR-005, FR-008, FR-011, FR-014)

**Checkpoint**: User Story 
2
 is independently functional and testable.

---

## Phase 
5
: User Story 
3
 - 
Combine File and CLI Configuration Safely
 (Priority: 
P3
)

**Goal**: Deliver User Story 
3
 functionality for 
Combine File and CLI Configuration Safely
.

**Independent Test**: 
Can be tested by supplying configuration values from file only, command line only, and both with overlap.

### Tests for User Story 
3
 (REQUIRED)

- [ ] T022 [P] [US3] Write failing unit tests for Combine File and CLI Configuration Safely in tests/FlashyCardMaker.Core.UnitTests/Features/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.UnitTests.cs (FR-003, FR-006, FR-009, FR-012, FR-015)
- [ ] T023 [P] [US3] Write failing integration tests for Combine File and CLI Configuration Safely in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.IntegrationTests.cs (FR-003, FR-006, FR-009, FR-012, FR-015)

### Implementation for User Story 
3

- [ ] T024 [US3] Create story 3 domain model for Combine File and CLI Configuration Safely in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.Model.cs (FR-003, FR-006, FR-009, FR-012, FR-015)
- [ ] T025 [US3] Implement story 3 service workflow for Combine File and CLI Configuration Safely in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.Service.cs (FR-003, FR-006, FR-009, FR-012, FR-015)
- [ ] T026 [US3] Implement story 3 adapter mapping for Combine File and CLI Configuration Safely in src/FlashyCardMaker.UI.Cli/Features/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.Adapter.cs (FR-003, FR-006, FR-009, FR-012, FR-015)
- [ ] T027 [US3] Add story 3 observability and error mapping for Combine File and CLI Configuration Safely in src/FlashyCardMaker.Infrastructure/Observability/003-cli-tui-interface/Story3/CombineFileAndCliConfigurationSafely.Observability.cs (FR-003, FR-006, FR-009, FR-012, FR-015)

**Checkpoint**: User Story 
3
 is independently functional and testable.

---

## Final Phase: Polish & Cross-Cutting Concerns

**Purpose**: Validate NFRs and close top risks before implementation handoff.

- [ ] T028 [P] Add performance threshold validation tests for 003-cli-tui-interface in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/CliTuiInterface.PerformanceTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T029 [P] Add security validation tests for 003-cli-tui-interface in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/CliTuiInterface.SecurityTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T030 [P] Add observability validation tests for 003-cli-tui-interface logging and metrics in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/003-cli-tui-interface/CliTuiInterface.ObservabilityTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T031 Mitigate top feature risk: Parser alias collisions in deep command hierarchies. in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/CliTuiInterface.RiskMitigation1.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T032 Mitigate top feature risk: TUI rendering inconsistencies by terminal. in src/FlashyCardMaker.Core/Features/003-cli-tui-interface/CliTuiInterface.RiskMitigation2.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T033 Run quickstart validation and update evidence in specs/003-cli-tui-interface/quickstart.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014, FR-015)
- [ ] T034 [P] Add command-help alias parity tests for --help, -h, and /? in tests/FlashyCardMaker.UI.Cli.Tests/Help/HelpAliasParityTests.cs (FR-004, FR-015)
- [ ] T035 [P] Add switch alias coverage tests to verify long/short aliases for every switch in tests/FlashyCardMaker.UI.Cli.Tests/Parsing/SwitchAliasCoverageTests.cs (FR-003, FR-015)
- [ ] T036 [P] Add nested-command help hierarchy validation tests in tests/FlashyCardMaker.UI.Cli.Tests/Help/NestedHelpStructureTests.cs (FR-002, FR-004, FR-015)
- [ ] T037 Implement CLI help manifest validator in src/FlashyCardMaker.UI.Cli/Help/HelpManifestValidator.cs (FR-003, FR-004, FR-015)

---

## Dependencies & Execution Order

- Setup (Phase 1) has no dependencies.
- Foundational (Phase 2) depends on Setup and blocks all stories.
- User stories start after Foundational and may run in priority order or parallel.
- Final phase runs after selected stories are complete.

### User Story Completion Order

- US1 (P1): Run Card Generation from Structured CLI Commands
- US2 (P2): Understand Usage Through Hierarchical Help
- US3 (P3): Combine File and CLI Configuration Safely

### Parallel Opportunities

- Tasks marked [P] may run in parallel if file-level dependencies do not conflict.
- Per-story failing tests can run in parallel first to enforce TDD cadence.
- NFR validation tasks in final phase are parallelizable.

## Parallel Example: User Story 1

```bash
Task: "Write failing unit tests for User Story 1"
Task: "Write failing integration tests for User Story 1"
```

## Implementation Strategy

### MVP First
1. Complete Setup and Foundational phases.
2. Deliver User Story 1 and validate independently.
3. Add remaining stories incrementally with NFR gates.
