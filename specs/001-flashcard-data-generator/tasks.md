# Tasks: Flashcard Data Generator

**Input**: Design documents from specs/001-flashcard-data-generator/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/FlashcardDataGenerator.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-flashcard-data-generator/FlashcardDataGenerator.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/FlashcardDataGenerator.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-flashcard-data-generator/FlashcardDataGenerator.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-flashcard-data-generator/FlashcardDataGenerator.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/FlashcardDataGenerator.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-flashcard-data-generator/FlashcardDataGenerator.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Configure Voices and Targets (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Configure Voices and Targets in tests/FlashyCardMaker.Core.UnitTests/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T010 [P] [US1] Write failing integration tests for Configure Voices and Targets in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Configure Voices and Targets in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T012 [US1] Implement validation/error flow for Configure Voices and Targets in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T013 [US1] Implement edge-case handler for Configure Voices and Targets in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T014 [US1] Implement adapter mapping for Configure Voices and Targets in src/FlashyCardMaker.UI.Cli/Features/001-flashcard-data-generator/Story1/ConfigureVoicesAndTargets.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 4: User Story 2 - Provide Word and Phrase Lists (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Provide Word and Phrase Lists in tests/FlashyCardMaker.Core.UnitTests/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T016 [P] [US2] Write failing integration tests for Provide Word and Phrase Lists in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Provide Word and Phrase Lists in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T018 [US2] Implement validation/error flow for Provide Word and Phrase Lists in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T019 [US2] Implement edge-case handler for Provide Word and Phrase Lists in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T020 [US2] Implement adapter mapping for Provide Word and Phrase Lists in src/FlashyCardMaker.UI.Cli/Features/001-flashcard-data-generator/Story2/ProvideWordAndPhraseLists.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 5: User Story 3 - Generate Translations, Audio, and Export (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Generate Translations, Audio, and Export in tests/FlashyCardMaker.Core.UnitTests/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T022 [P] [US3] Write failing integration tests for Generate Translations, Audio, and Export in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Generate Translations, Audio, and Export in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T024 [US3] Implement validation/error flow for Generate Translations, Audio, and Export in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T025 [US3] Implement edge-case handler for Generate Translations, Audio, and Export in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T026 [US3] Implement adapter mapping for Generate Translations, Audio, and Export in src/FlashyCardMaker.UI.Cli/Features/001-flashcard-data-generator/Story3/GenerateTranslationsAudioAndExport.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/FlashcardDataGenerator.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/FlashcardDataGenerator.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-flashcard-data-generator/FlashcardDataGenerator.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/FlashcardDataGenerator.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-flashcard-data-generator/FlashcardDataGenerator.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
