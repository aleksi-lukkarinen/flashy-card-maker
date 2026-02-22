# Tasks: Modular Configuration Sources

**Input**: Design documents from specs/001-config-sources-modular/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-config-sources-modular/ConfigSourcesModular.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-config-sources-modular/ConfigSourcesModular.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/ConfigSourcesModular.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-config-sources-modular/ConfigSourcesModular.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-config-sources-modular/ConfigSourcesModular.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/ConfigSourcesModular.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-config-sources-modular/ConfigSourcesModular.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Load Configuration from File and Command Line (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Load Configuration from File and Command Line in tests/FlashyCardMaker.Core.UnitTests/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T010 [P] [US1] Write failing integration tests for Load Configuration from File and Command Line in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Load Configuration from File and Command Line in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T012 [US1] Implement validation/error flow for Load Configuration from File and Command Line in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T013 [US1] Implement edge-case handler for Load Configuration from File and Command Line in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T014 [US1] Implement adapter mapping for Load Configuration from File and Command Line in src/FlashyCardMaker.UI.Cli/Features/001-config-sources-modular/Story1/LoadConfigurationFromFileAndCommandLine.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 4: User Story 2 - Understand Effective Configuration and Errors (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Understand Effective Configuration and Errors in tests/FlashyCardMaker.Core.UnitTests/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T016 [P] [US2] Write failing integration tests for Understand Effective Configuration and Errors in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Understand Effective Configuration and Errors in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T018 [US2] Implement validation/error flow for Understand Effective Configuration and Errors in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T019 [US2] Implement edge-case handler for Understand Effective Configuration and Errors in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T020 [US2] Implement adapter mapping for Understand Effective Configuration and Errors in src/FlashyCardMaker.UI.Cli/Features/001-config-sources-modular/Story2/UnderstandEffectiveConfigurationAndErrors.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 5: User Story 3 - Extend with New Configuration Sources (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Extend with New Configuration Sources in tests/FlashyCardMaker.Core.UnitTests/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T022 [P] [US3] Write failing integration tests for Extend with New Configuration Sources in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Extend with New Configuration Sources in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T024 [US3] Implement validation/error flow for Extend with New Configuration Sources in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T025 [US3] Implement edge-case handler for Extend with New Configuration Sources in src/FlashyCardMaker.Core/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T026 [US3] Implement adapter mapping for Extend with New Configuration Sources in src/FlashyCardMaker.UI.Cli/Features/001-config-sources-modular/Story3/ExtendWithNewConfigurationSources.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/ConfigSourcesModular.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/ConfigSourcesModular.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-config-sources-modular/ConfigSourcesModular.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-config-sources-modular/ConfigSourcesModular.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-config-sources-modular/ConfigSourcesModular.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
