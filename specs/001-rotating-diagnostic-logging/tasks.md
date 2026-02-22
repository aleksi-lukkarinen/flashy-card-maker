# Tasks: Rotating Diagnostic Logging

**Input**: Design documents from specs/001-rotating-diagnostic-logging/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/RotatingDiagnosticLogging.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Configure Detailed Rotating Logs (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Configure Detailed Rotating Logs in tests/FlashyCardMaker.Core.UnitTests/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T010 [P] [US1] Write failing integration tests for Configure Detailed Rotating Logs in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Configure Detailed Rotating Logs in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T012 [US1] Implement validation/error flow for Configure Detailed Rotating Logs in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T013 [US1] Implement edge-case handler for Configure Detailed Rotating Logs in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T014 [US1] Implement adapter mapping for Configure Detailed Rotating Logs in src/FlashyCardMaker.UI.Cli/Features/001-rotating-diagnostic-logging/Story1/ConfigureDetailedRotatingLogs.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 4: User Story 2 - Capture Operation Start, End, and Duration (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Capture Operation Start, End, and Duration in tests/FlashyCardMaker.Core.UnitTests/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T016 [P] [US2] Write failing integration tests for Capture Operation Start, End, and Duration in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Capture Operation Start, End, and Duration in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T018 [US2] Implement validation/error flow for Capture Operation Start, End, and Duration in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T019 [US2] Implement edge-case handler for Capture Operation Start, End, and Duration in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T020 [US2] Implement adapter mapping for Capture Operation Start, End, and Duration in src/FlashyCardMaker.UI.Cli/Features/001-rotating-diagnostic-logging/Story2/CaptureOperationStartEndAndDuration.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 5: User Story 3 - Log Remote Request/Response Diagnostics Safely (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Log Remote Request/Response Diagnostics Safely in tests/FlashyCardMaker.Core.UnitTests/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T022 [P] [US3] Write failing integration tests for Log Remote Request/Response Diagnostics Safely in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Log Remote Request/Response Diagnostics Safely in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T024 [US3] Implement validation/error flow for Log Remote Request/Response Diagnostics Safely in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T025 [US3] Implement edge-case handler for Log Remote Request/Response Diagnostics Safely in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T026 [US3] Implement adapter mapping for Log Remote Request/Response Diagnostics Safely in src/FlashyCardMaker.UI.Cli/Features/001-rotating-diagnostic-logging/Story3/LogRemoteRequestResponseDiagnosticsSafely.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-rotating-diagnostic-logging/RotatingDiagnosticLogging.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
