# Tasks: VBee GetVoices Support

**Input**: Design documents from specs/001-vbee-getvoices-support/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/VbeeGetvoicesSupport.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-vbee-getvoices-support/VbeeGetvoicesSupport.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-vbee-getvoices-support/VbeeGetvoicesSupport.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-vbee-getvoices-support/VbeeGetvoicesSupport.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Fetch VBee Voices for TTS Selection (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Fetch VBee Voices for TTS Selection in tests/FlashyCardMaker.Core.UnitTests/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T010 [P] [US1] Write failing integration tests for Fetch VBee Voices for TTS Selection in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Fetch VBee Voices for TTS Selection in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T012 [US1] Implement validation/error flow for Fetch VBee Voices for TTS Selection in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T013 [US1] Implement edge-case handler for Fetch VBee Voices for TTS Selection in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T014 [US1] Implement adapter mapping for Fetch VBee Voices for TTS Selection in src/FlashyCardMaker.UI.Cli/Features/001-vbee-getvoices-support/Story1/FetchVbeeVoicesForTtsSelection.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 4: User Story 2 - Enforce Required VBee Request Contract (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Enforce Required VBee Request Contract in tests/FlashyCardMaker.Core.UnitTests/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T016 [P] [US2] Write failing integration tests for Enforce Required VBee Request Contract in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Enforce Required VBee Request Contract in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T018 [US2] Implement validation/error flow for Enforce Required VBee Request Contract in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T019 [US2] Implement edge-case handler for Enforce Required VBee Request Contract in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T020 [US2] Implement adapter mapping for Enforce Required VBee Request Contract in src/FlashyCardMaker.UI.Cli/Features/001-vbee-getvoices-support/Story2/EnforceRequiredVbeeRequestContract.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 5: User Story 3 - Handle VBee Errors with Actionable Feedback (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Handle VBee Errors with Actionable Feedback in tests/FlashyCardMaker.Core.UnitTests/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T022 [P] [US3] Write failing integration tests for Handle VBee Errors with Actionable Feedback in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Handle VBee Errors with Actionable Feedback in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T024 [US3] Implement validation/error flow for Handle VBee Errors with Actionable Feedback in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T025 [US3] Implement edge-case handler for Handle VBee Errors with Actionable Feedback in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T026 [US3] Implement adapter mapping for Handle VBee Errors with Actionable Feedback in src/FlashyCardMaker.UI.Cli/Features/001-vbee-getvoices-support/Story3/HandleVbeeErrorsWithActionableFeedback.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-vbee-getvoices-support/VbeeGetvoicesSupport.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
