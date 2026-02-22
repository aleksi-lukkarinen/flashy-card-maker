# Tasks: CSV Output Export

**Input**: Design documents from specs/001-csv-output-export/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-csv-output-export/CsvOutputExport.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-csv-output-export/CsvOutputExport.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/CsvOutputExport.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-csv-output-export/CsvOutputExport.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-csv-output-export/CsvOutputExport.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/CsvOutputExport.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-csv-output-export/CsvOutputExport.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Export Full Flashcard Dataset to CSV (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Export Full Flashcard Dataset to CSV in tests/FlashyCardMaker.Core.UnitTests/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T010 [P] [US1] Write failing integration tests for Export Full Flashcard Dataset to CSV in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Export Full Flashcard Dataset to CSV in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T012 [US1] Implement validation/error flow for Export Full Flashcard Dataset to CSV in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T013 [US1] Implement edge-case handler for Export Full Flashcard Dataset to CSV in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T014 [US1] Implement adapter mapping for Export Full Flashcard Dataset to CSV in src/FlashyCardMaker.UI.Cli/Features/001-csv-output-export/Story1/ExportFullFlashcardDatasetToCsv.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 4: User Story 2 - Include Clear Header and Required Language Columns (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Include Clear Header and Required Language Columns in tests/FlashyCardMaker.Core.UnitTests/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T016 [P] [US2] Write failing integration tests for Include Clear Header and Required Language Columns in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Include Clear Header and Required Language Columns in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T018 [US2] Implement validation/error flow for Include Clear Header and Required Language Columns in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T019 [US2] Implement edge-case handler for Include Clear Header and Required Language Columns in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T020 [US2] Implement adapter mapping for Include Clear Header and Required Language Columns in src/FlashyCardMaker.UI.Cli/Features/001-csv-output-export/Story2/IncludeClearHeaderAndRequiredLanguageColumns.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Phase 5: User Story 3 - Preserve Consistent CSV Structure Across Runs (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Preserve Consistent CSV Structure Across Runs in tests/FlashyCardMaker.Core.UnitTests/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T022 [P] [US3] Write failing integration tests for Preserve Consistent CSV Structure Across Runs in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Preserve Consistent CSV Structure Across Runs in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T024 [US3] Implement validation/error flow for Preserve Consistent CSV Structure Across Runs in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T025 [US3] Implement edge-case handler for Preserve Consistent CSV Structure Across Runs in src/FlashyCardMaker.Core/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T026 [US3] Implement adapter mapping for Preserve Consistent CSV Structure Across Runs in src/FlashyCardMaker.UI.Cli/Features/001-csv-output-export/Story3/PreserveConsistentCsvStructureAcrossRuns.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/CsvOutputExport.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/CsvOutputExport.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-csv-output-export/CsvOutputExport.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-csv-output-export/CsvOutputExport.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-csv-output-export/CsvOutputExport.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
