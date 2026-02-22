# Tasks: Modular Flashcard Platform

**Input**: Design documents from specs/001-modular-flashcards/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-modular-flashcards/ModularFlashcards.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-modular-flashcards/ModularFlashcards.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/ModularFlashcards.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-modular-flashcards/ModularFlashcards.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-modular-flashcards/ModularFlashcards.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/ModularFlashcards.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-modular-flashcards/ModularFlashcards.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Create Flashcards from Any Supported Source (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Create Flashcards from Any Supported Source in tests/FlashyCardMaker.Core.UnitTests/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T010 [P] [US1] Write failing integration tests for Create Flashcards from Any Supported Source in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Create Flashcards from Any Supported Source in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T012 [US1] Implement validation/error flow for Create Flashcards from Any Supported Source in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T013 [US1] Implement edge-case handler for Create Flashcards from Any Supported Source in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T014 [US1] Implement adapter mapping for Create Flashcards from Any Supported Source in src/FlashyCardMaker.UI.Cli/Features/001-modular-flashcards/Story1/CreateFlashcardsFromAnySupportedSource.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 4: User Story 2 - Enrich Cards with Translation and Audio Services (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Enrich Cards with Translation and Audio Services in tests/FlashyCardMaker.Core.UnitTests/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T016 [P] [US2] Write failing integration tests for Enrich Cards with Translation and Audio Services in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Enrich Cards with Translation and Audio Services in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T018 [US2] Implement validation/error flow for Enrich Cards with Translation and Audio Services in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T019 [US2] Implement edge-case handler for Enrich Cards with Translation and Audio Services in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T020 [US2] Implement adapter mapping for Enrich Cards with Translation and Audio Services in src/FlashyCardMaker.UI.Cli/Features/001-modular-flashcards/Story2/EnrichCardsWithTranslationAndAudioServices.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 5: User Story 3 - Configure and Run Through Preferred Interface and Output (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Configure and Run Through Preferred Interface and Output in tests/FlashyCardMaker.Core.UnitTests/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T022 [P] [US3] Write failing integration tests for Configure and Run Through Preferred Interface and Output in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Configure and Run Through Preferred Interface and Output in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T024 [US3] Implement validation/error flow for Configure and Run Through Preferred Interface and Output in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T025 [US3] Implement edge-case handler for Configure and Run Through Preferred Interface and Output in src/FlashyCardMaker.Core/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T026 [US3] Implement adapter mapping for Configure and Run Through Preferred Interface and Output in src/FlashyCardMaker.UI.Cli/Features/001-modular-flashcards/Story3/ConfigureAndRunThroughPreferredInterfaceAndOutput.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/ModularFlashcards.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/ModularFlashcards.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-modular-flashcards/ModularFlashcards.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-modular-flashcards/ModularFlashcards.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-modular-flashcards/ModularFlashcards.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
