# Tasks: Runtime Error Recovery for Parallel Jobs  **Input**: Design documents from specs/001-runtime-error-recovery/ **Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md  **Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory: failing tests first.  ## Phase 1: Setup (Shared Infrastructure)  **Purpose**: Initialize feature module, tests, and pipeline hooks. 
- [ ] T001 Create 001-runtime-error-recovery module scaffold in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/RuntimeErrorRecovery.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T002 Create 001-runtime-error-recovery test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-runtime-error-recovery/RuntimeErrorRecovery.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T003 [P] Add 001-runtime-error-recovery registration in src/FlashyCardMaker.Infrastructure/Composition/RuntimeErrorRecovery.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T004 [P] Add CI filter stage for 001-runtime-error-recovery in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Establish contracts, validation, boundary tests, and observability before story implementation.

- [ ] T005 Define 001-runtime-error-recovery contracts in src/FlashyCardMaker.Core/Contracts/001-runtime-error-recovery/RuntimeErrorRecovery.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T006 [P] Implement 001-runtime-error-recovery validation pipeline in src/FlashyCardMaker.Core/Validation/001-runtime-error-recovery/RuntimeErrorRecovery.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T007 [P] Implement 001-runtime-error-recovery result model in src/FlashyCardMaker.Core/Models/001-runtime-error-recovery/RuntimeErrorRecovery.Result.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T008 Add feature boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/RuntimeErrorRecovery.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T009 Configure 001-runtime-error-recovery structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-runtime-error-recovery/RuntimeErrorRecovery.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)

**Checkpoint**: Foundational phase complete; story phases can proceed.

---

## Phase 
3
: User Story 
1
 - 
Continue Processing Despite Per-Job Failures
 (Priority: 
P1
)

**Goal**: Deliver User Story 
1
 functionality for 
Continue Processing Despite Per-Job Failures
.

**Independent Test**: 
Can be tested by running a batch where selected jobs fail repeatedly while other jobs should complete.

### Tests for User Story 
1
 (REQUIRED)

- [ ] T010 [P] [US1] Write failing unit tests for Continue Processing Despite Per-Job Failures in tests/FlashyCardMaker.Core.UnitTests/Features/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.UnitTests.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T011 [P] [US1] Write failing integration tests for Continue Processing Despite Per-Job Failures in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.IntegrationTests.cs (FR-001, FR-004, FR-007, FR-010, FR-013)

### Implementation for User Story 
1

- [ ] T012 [US1] Create story 1 domain model for Continue Processing Despite Per-Job Failures in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.Model.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T013 [US1] Implement story 1 service workflow for Continue Processing Despite Per-Job Failures in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.Service.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T014 [US1] Implement story 1 adapter mapping for Continue Processing Despite Per-Job Failures in src/FlashyCardMaker.UI.Cli/Features/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.Adapter.cs (FR-001, FR-004, FR-007, FR-010, FR-013)
- [ ] T015 [US1] Add story 1 observability and error mapping for Continue Processing Despite Per-Job Failures in src/FlashyCardMaker.Infrastructure/Observability/001-runtime-error-recovery/Story1/ContinueProcessingDespitePerJobFailures.Observability.cs (FR-001, FR-004, FR-007, FR-010, FR-013)

**Checkpoint**: User Story 
1
 is independently functional and testable.

---

## Phase 
4
: User Story 
2
 - 
Understand Final Outcome of Every Job
 (Priority: 
P2
)

**Goal**: Deliver User Story 
2
 functionality for 
Understand Final Outcome of Every Job
.

**Independent Test**: 
Can be tested by injecting mixed success, partial success, and failure cases and verifying run summaries and per-job details.

### Tests for User Story 
2
 (REQUIRED)

- [ ] T016 [P] [US2] Write failing unit tests for Understand Final Outcome of Every Job in tests/FlashyCardMaker.Core.UnitTests/Features/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.UnitTests.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T017 [P] [US2] Write failing integration tests for Understand Final Outcome of Every Job in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.IntegrationTests.cs (FR-002, FR-005, FR-008, FR-011, FR-014)

### Implementation for User Story 
2

- [ ] T018 [US2] Create story 2 domain model for Understand Final Outcome of Every Job in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.Model.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T019 [US2] Implement story 2 service workflow for Understand Final Outcome of Every Job in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.Service.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T020 [US2] Implement story 2 adapter mapping for Understand Final Outcome of Every Job in src/FlashyCardMaker.UI.Cli/Features/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.Adapter.cs (FR-002, FR-005, FR-008, FR-011, FR-014)
- [ ] T021 [US2] Add story 2 observability and error mapping for Understand Final Outcome of Every Job in src/FlashyCardMaker.Infrastructure/Observability/001-runtime-error-recovery/Story2/UnderstandFinalOutcomeOfEveryJob.Observability.cs (FR-002, FR-005, FR-008, FR-011, FR-014)

**Checkpoint**: User Story 
2
 is independently functional and testable.

---

## Phase 
5
: User Story 
3
 - 
Resume Interrupted or Partially Failed Runs
 (Priority: 
P3
)

**Goal**: Deliver User Story 
3
 functionality for 
Resume Interrupted or Partially Failed Runs
.

**Independent Test**: 
Can be tested by terminating a run mid-flight, then rerunning with resume mode and verifying only incomplete/failed jobs are retried.

### Tests for User Story 
3
 (REQUIRED)

- [ ] T022 [P] [US3] Write failing unit tests for Resume Interrupted or Partially Failed Runs in tests/FlashyCardMaker.Core.UnitTests/Features/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.UnitTests.cs (FR-003, FR-006, FR-009, FR-012)
- [ ] T023 [P] [US3] Write failing integration tests for Resume Interrupted or Partially Failed Runs in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.IntegrationTests.cs (FR-003, FR-006, FR-009, FR-012)

### Implementation for User Story 
3

- [ ] T024 [US3] Create story 3 domain model for Resume Interrupted or Partially Failed Runs in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.Model.cs (FR-003, FR-006, FR-009, FR-012)
- [ ] T025 [US3] Implement story 3 service workflow for Resume Interrupted or Partially Failed Runs in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.Service.cs (FR-003, FR-006, FR-009, FR-012)
- [ ] T026 [US3] Implement story 3 adapter mapping for Resume Interrupted or Partially Failed Runs in src/FlashyCardMaker.UI.Cli/Features/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.Adapter.cs (FR-003, FR-006, FR-009, FR-012)
- [ ] T027 [US3] Add story 3 observability and error mapping for Resume Interrupted or Partially Failed Runs in src/FlashyCardMaker.Infrastructure/Observability/001-runtime-error-recovery/Story3/ResumeInterruptedOrPartiallyFailedRuns.Observability.cs (FR-003, FR-006, FR-009, FR-012)

**Checkpoint**: User Story 
3
 is independently functional and testable.

---

## Final Phase: Polish & Cross-Cutting Concerns

**Purpose**: Validate NFRs and close top risks before implementation handoff.

- [ ] T028 [P] Add performance threshold validation tests for 001-runtime-error-recovery in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/RuntimeErrorRecovery.PerformanceTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T029 [P] Add security validation tests for 001-runtime-error-recovery in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/RuntimeErrorRecovery.SecurityTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T030 [P] Add observability validation tests for 001-runtime-error-recovery logging and metrics in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/RuntimeErrorRecovery.ObservabilityTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T031 Mitigate top feature risk: Unclear edge-case behavior across integrations. in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/RuntimeErrorRecovery.RiskMitigation1.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T032 Mitigate top feature risk: Drift across modules over time. in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/RuntimeErrorRecovery.RiskMitigation2.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T033 Run quickstart validation and update evidence in specs/001-runtime-error-recovery/quickstart.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, FR-014)
- [ ] T034 [P] Add explicit retry-limit enforcement tests in tests/FlashyCardMaker.Core.UnitTests/Features/001-runtime-error-recovery/RetryLimitPolicyTests.cs (FR-002, FR-003, FR-014)
- [ ] T035 [P] Add repeated-error threshold stop-policy tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/FailureThresholdPolicyTests.cs (FR-009, FR-010, FR-011)
- [ ] T036 [P] Add resume idempotency tests to verify successful jobs are skipped and outputs are not duplicated in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-runtime-error-recovery/ResumeIdempotencyTests.cs (FR-007, FR-008, FR-013)
- [ ] T037 Implement deterministic resume state reconciliation in src/FlashyCardMaker.Core/Features/001-runtime-error-recovery/ResumeStateReconciler.cs (FR-007, FR-008, FR-012, FR-013, FR-014)

---

## Dependencies & Execution Order

- Setup (Phase 1) has no dependencies.
- Foundational (Phase 2) depends on Setup and blocks all stories.
- User stories start after Foundational and may run in priority order or parallel.
- Final phase runs after selected stories are complete.

### User Story Completion Order

- US1 (P1): Continue Processing Despite Per-Job Failures
- US2 (P2): Understand Final Outcome of Every Job
- US3 (P3): Resume Interrupted or Partially Failed Runs

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
