# Tasks: Language Audio Folders

**Input**: Design documents from specs/001-language-audio-folders/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-language-audio-folders/LanguageAudioFolders.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-audio-folders/LanguageAudioFolders.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/LanguageAudioFolders.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-language-audio-folders/LanguageAudioFolders.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-language-audio-folders/LanguageAudioFolders.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/LanguageAudioFolders.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-language-audio-folders/LanguageAudioFolders.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Configure Folder per Language (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Configure Folder per Language in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T010 [P] [US1] Write failing integration tests for Configure Folder per Language in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Configure Folder per Language in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T012 [US1] Implement validation/error flow for Configure Folder per Language in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T013 [US1] Implement edge-case handler for Configure Folder per Language in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T014 [US1] Implement adapter mapping for Configure Folder per Language in src/FlashyCardMaker.UI.Cli/Features/001-language-audio-folders/Story1/ConfigureFolderPerLanguage.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 4: User Story 2 - Validate Folder Configuration Before Save (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Validate Folder Configuration Before Save in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T016 [P] [US2] Write failing integration tests for Validate Folder Configuration Before Save in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Validate Folder Configuration Before Save in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T018 [US2] Implement validation/error flow for Validate Folder Configuration Before Save in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T019 [US2] Implement edge-case handler for Validate Folder Configuration Before Save in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T020 [US2] Implement adapter mapping for Validate Folder Configuration Before Save in src/FlashyCardMaker.UI.Cli/Features/001-language-audio-folders/Story2/ValidateFolderConfigurationBeforeSave.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 5: User Story 3 - Keep Output Traceable Across Languages (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Keep Output Traceable Across Languages in tests/FlashyCardMaker.Core.UnitTests/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T022 [P] [US3] Write failing integration tests for Keep Output Traceable Across Languages in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Keep Output Traceable Across Languages in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T024 [US3] Implement validation/error flow for Keep Output Traceable Across Languages in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T025 [US3] Implement edge-case handler for Keep Output Traceable Across Languages in src/FlashyCardMaker.Core/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T026 [US3] Implement adapter mapping for Keep Output Traceable Across Languages in src/FlashyCardMaker.UI.Cli/Features/001-language-audio-folders/Story3/KeepOutputTraceableAcrossLanguages.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/LanguageAudioFolders.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/LanguageAudioFolders.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-language-audio-folders/LanguageAudioFolders.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-language-audio-folders/LanguageAudioFolders.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-language-audio-folders/LanguageAudioFolders.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
