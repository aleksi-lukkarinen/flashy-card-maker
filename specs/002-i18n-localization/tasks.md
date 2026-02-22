# Tasks: Internationalization & Localization Readiness

**Input**: Design documents from specs/002-i18n-localization/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for all user stories and integrations. TDD is mandatory.

## Phase 1: Setup (Shared Infrastructure)

- [ ] T001 Create feature module scaffold in src/FlashyCardMaker.Core/Features/002-i18n-localization/I18nLocalization.Module.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T002 Create feature test scaffold in tests/FlashyCardMaker.Core.UnitTests/Features/002-i18n-localization/I18nLocalization.ModuleTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T003 [P] Add registration hook in src/FlashyCardMaker.Infrastructure/Composition/I18nLocalization.Registration.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T004 [P] Add CI feature test filter in .github/workflows/ci.yml (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

---

## Phase 2: Foundational (Blocking Prerequisites)

- [ ] T005 Define feature contracts in src/FlashyCardMaker.Core/Contracts/002-i18n-localization/I18nLocalization.Contracts.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T006 [P] Define validation pipeline in src/FlashyCardMaker.Core/Validation/002-i18n-localization/I18nLocalization.Validation.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T007 Add boundary integration tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/I18nLocalization.BoundaryTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T008 Configure structured logging in src/FlashyCardMaker.Infrastructure/Logging/002-i18n-localization/I18nLocalization.Logging.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

**Checkpoint**: Foundational phase complete.

---

## Phase 3: User Story 1 - Use Default US English (Priority: P1)

### Tests (REQUIRED)

- [ ] T009 [P] [US1] Write failing unit tests for Use Default US English in tests/FlashyCardMaker.Core.UnitTests/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T010 [P] [US1] Write failing integration tests for Use Default US English in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

### Implementation

- [ ] T011 [US1] Implement happy-path flow for Use Default US English in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T012 [US1] Implement validation/error flow for Use Default US English in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T013 [US1] Implement edge-case handler for Use Default US English in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T014 [US1] Implement adapter mapping for Use Default US English in src/FlashyCardMaker.UI.Cli/Features/002-i18n-localization/Story1/UseDefaultUsEnglish.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

---

## Phase 4: User Story 2 - Switch to Another Locale (Priority: P2)

### Tests (REQUIRED)

- [ ] T015 [P] [US2] Write failing unit tests for Switch to Another Locale in tests/FlashyCardMaker.Core.UnitTests/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T016 [P] [US2] Write failing integration tests for Switch to Another Locale in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

### Implementation

- [ ] T017 [US2] Implement happy-path flow for Switch to Another Locale in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T018 [US2] Implement validation/error flow for Switch to Another Locale in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T019 [US2] Implement edge-case handler for Switch to Another Locale in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T020 [US2] Implement adapter mapping for Switch to Another Locale in src/FlashyCardMaker.UI.Cli/Features/002-i18n-localization/Story2/SwitchToAnotherLocale.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

---

## Phase 5: User Story 3 - Localization-Ready Content (Priority: P3)

### Tests (REQUIRED)

- [ ] T021 [P] [US3] Write failing unit tests for Localization-Ready Content in tests/FlashyCardMaker.Core.UnitTests/Features/002-i18n-localization/Story3/LocalizationReadyContent.UnitTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T022 [P] [US3] Write failing integration tests for Localization-Ready Content in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/Story3/LocalizationReadyContent.IntegrationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

### Implementation

- [ ] T023 [US3] Implement happy-path flow for Localization-Ready Content in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story3/LocalizationReadyContent.HappyPathService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T024 [US3] Implement validation/error flow for Localization-Ready Content in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story3/LocalizationReadyContent.ValidationService.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T025 [US3] Implement edge-case handler for Localization-Ready Content in src/FlashyCardMaker.Core/Features/002-i18n-localization/Story3/LocalizationReadyContent.EdgeCasePolicy.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T026 [US3] Implement adapter mapping for Localization-Ready Content in src/FlashyCardMaker.UI.Cli/Features/002-i18n-localization/Story3/LocalizationReadyContent.Adapter.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

---

## Final Phase: Polish & Cross-Cutting Concerns

- [ ] T027 [P] Add measurable performance threshold tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/I18nLocalization.PerformanceThresholdTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, SC-001, SC-002, SC-003, SC-004)
- [ ] T028 [P] Add measurable security validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/I18nLocalization.SecurityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, SC-001, SC-002, SC-003, SC-004)
- [ ] T029 [P] Add measurable observability validation tests in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/002-i18n-localization/I18nLocalization.ObservabilityValidationTests.cs (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007, SC-001, SC-002, SC-003, SC-004)
- [ ] T030 Mitigate integration failure risk in src/FlashyCardMaker.Core/Features/002-i18n-localization/I18nLocalization.IntegrationRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)
- [ ] T031 Mitigate cross-module drift risk in src/FlashyCardMaker.Core/Features/002-i18n-localization/I18nLocalization.DriftRiskMitigation.md (FR-001, FR-002, FR-003, FR-004, FR-005, FR-006, FR-007)

---

## Dependencies & Execution Order

- Setup -> Foundational -> User Stories -> Final Phase.
- Tasks marked [P] are parallelizable.
