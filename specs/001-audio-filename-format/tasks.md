# Tasks: Audio Filename Format

**Input**: Design documents from specs/001-audio-filename-format/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-audio-filename-format/AudioFilenameFormat.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-audio-filename-format/AudioFilenameFormat.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/AudioFilenameFormat.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-audio-filename-format/AudioFilenameFormat.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-audio-filename-format/AudioFilenameFormat.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/AudioFilenameFormat.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-audio-filename-format/AudioFilenameFormat.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Generate Deterministic Human-Readable Audio Filenames (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Generate Deterministic Human-Readable Audio Filenames in tests/FlashyCardMaker.Core.UnitTests/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T010 [P] [US1] Write failing integration tests for Generate Deterministic Human-Readable Audio Filenames in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Generate Deterministic Human-Readable Audio Filenames in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T012 [US1] Implement validation/error flow for Generate Deterministic Human-Readable Audio Filenames in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T013 [US1] Implement edge-case handler for Generate Deterministic Human-Readable Audio Filenames in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T014 [US1] Implement adapter mapping for Generate Deterministic Human-Readable Audio Filenames in src/FlashyCardMaker.UI.Cli/Features/001-audio-filename-format/Story1/GenerateDeterministicHumanReadableAudioFilenames.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 4: User Story 2 - Produce Valid Slug from Spoken Text (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Produce Valid Slug from Spoken Text in tests/FlashyCardMaker.Core.UnitTests/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T016 [P] [US2] Write failing integration tests for Produce Valid Slug from Spoken Text in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Produce Valid Slug from Spoken Text in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T018 [US2] Implement validation/error flow for Produce Valid Slug from Spoken Text in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T019 [US2] Implement edge-case handler for Produce Valid Slug from Spoken Text in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T020 [US2] Implement adapter mapping for Produce Valid Slug from Spoken Text in src/FlashyCardMaker.UI.Cli/Features/001-audio-filename-format/Story2/ProduceValidSlugFromSpokenText.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Phase 5: User Story 3 - Preserve Uniqueness Across Languages and Formats (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Preserve Uniqueness Across Languages and Formats in tests/FlashyCardMaker.Core.UnitTests/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T022 [P] [US3] Write failing integration tests for Preserve Uniqueness Across Languages and Formats in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Preserve Uniqueness Across Languages and Formats in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T024 [US3] Implement validation/error flow for Preserve Uniqueness Across Languages and Formats in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T025 [US3] Implement edge-case handler for Preserve Uniqueness Across Languages and Formats in src/FlashyCardMaker.Core/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T026 [US3] Implement adapter mapping for Preserve Uniqueness Across Languages and Formats in src/FlashyCardMaker.UI.Cli/Features/001-audio-filename-format/Story3/PreserveUniquenessAcrossLanguagesAndFormats.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/AudioFilenameFormat.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/AudioFilenameFormat.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-audio-filename-format/AudioFilenameFormat.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-audio-filename-format/AudioFilenameFormat.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-audio-filename-format/AudioFilenameFormat.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, FR-011, FR-012)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
