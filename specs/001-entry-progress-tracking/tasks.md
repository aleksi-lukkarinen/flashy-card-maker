# Tasks: Entry Progress Tracking

**Input**: Design documents from specs/001-entry-progress-tracking/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/EntryProgressTracking.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-entry-progress-tracking/EntryProgressTracking.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/EntryProgressTracking.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-entry-progress-tracking/EntryProgressTracking.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-entry-progress-tracking/EntryProgressTracking.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/EntryProgressTracking.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-entry-progress-tracking/EntryProgressTracking.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Process Entries Concurrently with Per-Entry Phase Visibility (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Process Entries Concurrently with Per-Entry Phase Visibility in tests/FlashyCardMaker.Core.UnitTests/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T010 [P] [US1] Write failing integration tests for Process Entries Concurrently with Per-Entry Phase Visibility in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Process Entries Concurrently with Per-Entry Phase Visibility in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T012 [US1] Implement validation/error flow for Process Entries Concurrently with Per-Entry Phase Visibility in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T013 [US1] Implement edge-case handler for Process Entries Concurrently with Per-Entry Phase Visibility in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T014 [US1] Implement adapter mapping for Process Entries Concurrently with Per-Entry Phase Visibility in src/FlashyCardMaker.UI.Cli/Features/001-entry-progress-tracking/Story1/ProcessEntriesConcurrentlyWithPerEntryPhaseVisibility.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 4: User Story 2 - Show Progress for Long-Running Operations per Entry (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Show Progress for Long-Running Operations per Entry in tests/FlashyCardMaker.Core.UnitTests/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T016 [P] [US2] Write failing integration tests for Show Progress for Long-Running Operations per Entry in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Show Progress for Long-Running Operations per Entry in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T018 [US2] Implement validation/error flow for Show Progress for Long-Running Operations per Entry in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T019 [US2] Implement edge-case handler for Show Progress for Long-Running Operations per Entry in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T020 [US2] Implement adapter mapping for Show Progress for Long-Running Operations per Entry in src/FlashyCardMaker.UI.Cli/Features/001-entry-progress-tracking/Story2/ShowProgressForLongRunningOperationsPerEntry.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 5: User Story 3 - Display Per-Entry and Total Processing Time (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Display Per-Entry and Total Processing Time in tests/FlashyCardMaker.Core.UnitTests/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T022 [P] [US3] Write failing integration tests for Display Per-Entry and Total Processing Time in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Display Per-Entry and Total Processing Time in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T024 [US3] Implement validation/error flow for Display Per-Entry and Total Processing Time in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T025 [US3] Implement edge-case handler for Display Per-Entry and Total Processing Time in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T026 [US3] Implement adapter mapping for Display Per-Entry and Total Processing Time in src/FlashyCardMaker.UI.Cli/Features/001-entry-progress-tracking/Story3/DisplayPerEntryAndTotalProcessingTime.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/EntryProgressTracking.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/EntryProgressTracking.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-entry-progress-tracking/EntryProgressTracking.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/EntryProgressTracking.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-entry-progress-tracking/EntryProgressTracking.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
