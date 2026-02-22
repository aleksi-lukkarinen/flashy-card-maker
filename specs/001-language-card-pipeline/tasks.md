# Tasks: Language Card Pipeline

**Input**: Design documents from specs/001-language-card-pipeline/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/LanguageCardPipeline.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-card-pipeline/LanguageCardPipeline.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/LanguageCardPipeline.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-language-card-pipeline/LanguageCardPipeline.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-language-card-pipeline/LanguageCardPipeline.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/LanguageCardPipeline.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-language-card-pipeline/LanguageCardPipeline.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Configure and Generate Multilingual Flashcards (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Configure and Generate Multilingual Flashcards in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T010 [P] [US1] Write failing integration tests for Configure and Generate Multilingual Flashcards in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Configure and Generate Multilingual Flashcards in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T012 [US1] Implement validation/error flow for Configure and Generate Multilingual Flashcards in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T013 [US1] Implement edge-case handler for Configure and Generate Multilingual Flashcards in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T014 [US1] Implement adapter mapping for Configure and Generate Multilingual Flashcards in src/FlashyCardMaker.UI.Cli/Features/001-language-card-pipeline/Story1/ConfigureAndGenerateMultilingualFlashcards.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

---

## Phase 4: User Story 2 - Assign Translation and Audio Services by Language Pair (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Assign Translation and Audio Services by Language Pair in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T016 [P] [US2] Write failing integration tests for Assign Translation and Audio Services by Language Pair in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Assign Translation and Audio Services by Language Pair in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T018 [US2] Implement validation/error flow for Assign Translation and Audio Services by Language Pair in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T019 [US2] Implement edge-case handler for Assign Translation and Audio Services by Language Pair in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T020 [US2] Implement adapter mapping for Assign Translation and Audio Services by Language Pair in src/FlashyCardMaker.UI.Cli/Features/001-language-card-pipeline/Story2/AssignTranslationAndAudioServicesByLanguagePair.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

---

## Phase 5: User Story 3 - Export Results in Multiple Output Formats (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Export Results in Multiple Output Formats in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T022 [P] [US3] Write failing integration tests for Export Results in Multiple Output Formats in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Export Results in Multiple Output Formats in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T024 [US3] Implement validation/error flow for Export Results in Multiple Output Formats in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T025 [US3] Implement edge-case handler for Export Results in Multiple Output Formats in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T026 [US3] Implement adapter mapping for Export Results in Multiple Output Formats in src/FlashyCardMaker.UI.Cli/Features/001-language-card-pipeline/Story3/ExportResultsInMultipleOutputFormats.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/LanguageCardPipeline.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/LanguageCardPipeline.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-card-pipeline/LanguageCardPipeline.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/LanguageCardPipeline.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-language-card-pipeline/LanguageCardPipeline.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, FR-013)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
