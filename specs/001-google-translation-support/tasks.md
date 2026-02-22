# Tasks: Google Translation Support

**Input**: Design documents from specs/001-google-translation-support/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-google-translation-support/GoogleTranslationSupport.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/GoogleTranslationSupport.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/GoogleTranslationSupport.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-google-translation-support/GoogleTranslationSupport.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-google-translation-support/GoogleTranslationSupport.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/GoogleTranslationSupport.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-google-translation-support/GoogleTranslationSupport.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Translate Flashcard Text Using Google Service (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Translate Flashcard Text Using Google Service in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T010 [P] [US1] Write failing integration tests for Translate Flashcard Text Using Google Service in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T012 [US1] Implement validation/error flow for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T013 [US1] Implement edge-case handler for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T014 [US1] Implement adapter mapping for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story1/TranslateFlashcardTextUsingGoogleService.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 4: User Story 2 - Configure and Validate Google Translation Access (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Configure and Validate Google Translation Access in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T016 [P] [US2] Write failing integration tests for Configure and Validate Google Translation Access in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Configure and Validate Google Translation Access in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T018 [US2] Implement validation/error flow for Configure and Validate Google Translation Access in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T019 [US2] Implement edge-case handler for Configure and Validate Google Translation Access in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T020 [US2] Implement adapter mapping for Configure and Validate Google Translation Access in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story2/ConfigureAndValidateGoogleTranslationAccess.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 5: User Story 3 - Preserve Run Continuity on Translation Failures (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Preserve Run Continuity on Translation Failures in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T022 [P] [US3] Write failing integration tests for Preserve Run Continuity on Translation Failures in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T024 [US3] Implement validation/error flow for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T025 [US3] Implement edge-case handler for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T026 [US3] Implement adapter mapping for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story3/PreserveRunContinuityOnTranslationFailures.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/GoogleTranslationSupport.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/GoogleTranslationSupport.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/GoogleTranslationSupport.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-google-translation-support/GoogleTranslationSupport.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-google-translation-support/GoogleTranslationSupport.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
