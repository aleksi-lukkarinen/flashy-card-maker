# Tasks: TTS Voice Discovery

**Input**: Design documents from specs/001-tts-voice-discovery/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/TtsVoiceDiscovery.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/001-tts-voice-discovery/TtsVoiceDiscovery.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/TtsVoiceDiscovery.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/001-tts-voice-discovery/TtsVoiceDiscovery.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/001-tts-voice-discovery/TtsVoiceDiscovery.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/TtsVoiceDiscovery.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/001-tts-voice-discovery/TtsVoiceDiscovery.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Query Available Voices by Language (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Query Available Voices by Language in tests/FlashyCardMaker.Core.UnitTests/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T010 [P] [US1] Write failing integration tests for Query Available Voices by Language in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Query Available Voices by Language in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T012 [US1] Implement validation/error flow for Query Available Voices by Language in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T013 [US1] Implement edge-case handler for Query Available Voices by Language in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T014 [US1] Implement adapter mapping for Query Available Voices by Language in src/FlashyCardMaker.UI.Cli/Features/001-tts-voice-discovery/Story1/QueryAvailableVoicesByLanguage.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 4: User Story 2 - Provide Required Query Parameters (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Provide Required Query Parameters in tests/FlashyCardMaker.Core.UnitTests/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T016 [P] [US2] Write failing integration tests for Provide Required Query Parameters in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Provide Required Query Parameters in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T018 [US2] Implement validation/error flow for Provide Required Query Parameters in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T019 [US2] Implement edge-case handler for Provide Required Query Parameters in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T020 [US2] Implement adapter mapping for Provide Required Query Parameters in src/FlashyCardMaker.UI.Cli/Features/001-tts-voice-discovery/Story2/ProvideRequiredQueryParameters.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Phase 5: User Story 3 - Handle Service Failures and Keep Workflow Clear (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Handle Service Failures and Keep Workflow Clear in tests/FlashyCardMaker.Core.UnitTests/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T022 [P] [US3] Write failing integration tests for Handle Service Failures and Keep Workflow Clear in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Handle Service Failures and Keep Workflow Clear in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T024 [US3] Implement validation/error flow for Handle Service Failures and Keep Workflow Clear in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T025 [US3] Implement edge-case handler for Handle Service Failures and Keep Workflow Clear in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T026 [US3] Implement adapter mapping for Handle Service Failures and Keep Workflow Clear in src/FlashyCardMaker.UI.Cli/Features/001-tts-voice-discovery/Story3/HandleServiceFailuresAndKeepWorkflowClear.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/TtsVoiceDiscovery.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/TtsVoiceDiscovery.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-tts-voice-discovery/TtsVoiceDiscovery.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010, SC-001, SC-002, SC-003, SC-004, SC-005)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/TtsVoiceDiscovery.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/001-tts-voice-discovery/TtsVoiceDiscovery.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, FR-008, FR-009, FR-010)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
