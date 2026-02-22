# Tasks: Google Translation Support

**Input**: Design documents from specs/001-google-translation-support/
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/openapi.yaml, quickstart.md

**Tests**: Tests are REQUIRED for every user story and integration. TDD is mandatory: write failing tests first.

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Initialize project and test scaffolding for the feature.

- [ ] T001 Create feature workspace structure in src/FlashyCardMaker.Core/Features/001-google-translation-support/.gitkeep
- [ ] T002 Create feature test folders in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/.gitkeep
- [ ] T003 [P] Add feature execution scaffold registration in src/FlashyCardMaker.Infrastructure/Composition/FeatureRegistration.cs
- [ ] T004 [P] Add CI placeholder for feature test filtering in .github/workflows/ci.yml

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Complete shared contracts, validation, and observability required before story work.

- [ ] T005 Define shared feature contracts in src/FlashyCardMaker.Core/Contracts/001-google-translation-support/FeatureContracts.cs
- [ ] T006 [P] Define feature validation primitives in src/FlashyCardMaker.Core/Validation/001-google-translation-support/FeatureValidation.cs
- [ ] T007 [P] Implement shared feature result model in src/FlashyCardMaker.Core/Models/001-google-translation-support/FeatureResult.cs
- [ ] T008 Add foundational integration tests for feature I/O boundaries in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/FeatureBoundaryTests.cs
- [ ] T009 Configure structured logging events for feature lifecycle in src/FlashyCardMaker.Infrastructure/Logging/001-google-translation-support/FeatureLogging.cs

**Checkpoint**: Foundation complete; user story phases can start.

---

## Phase 3: User Story 1 - Translate Flashcard Text Using Google Service (Priority: P1)

**Goal**: Deliver User Story 1 functionality for Translate Flashcard Text Using Google Service.

**Independent Test**: Can be tested by selecting a source language and target language, requesting translation, and verifying returned text in generated cards.

### Tests for User Story 1 (REQUIRED)

- [ ] T010 [P] [US1] Write failing unit tests for Translate Flashcard Text Using Google Service in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story1/Story1UnitTests.cs
- [ ] T011 [P] [US1] Write failing integration tests for Translate Flashcard Text Using Google Service in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story1/Story1IntegrationTests.cs

### Implementation for User Story 1

- [ ] T012 [US1] Create story 1 domain model for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story1/Story1Model.cs
- [ ] T013 [US1] Implement story 1 service workflow for Translate Flashcard Text Using Google Service in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story1/Story1Service.cs
- [ ] T014 [US1] Implement story 1 adapter endpoint or command mapping in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story1/Story1Adapter.cs
- [ ] T015 [US1] Add story 1 observability and error mapping in src/FlashyCardMaker.Infrastructure/Observability/001-google-translation-support/Story1Observability.cs

**Checkpoint**: User Story 1 is independently functional and testable.

---

## Phase 4: User Story 2 - Configure and Validate Google Translation Access (Priority: P2)

**Goal**: Deliver User Story 2 functionality for Configure and Validate Google Translation Access.

**Independent Test**: Can be tested by running configuration checks with valid and invalid credentials and confirming clear pass/fail feedback.

### Tests for User Story 2 (REQUIRED)

- [ ] T016 [P] [US2] Write failing unit tests for Configure and Validate Google Translation Access in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story2/Story2UnitTests.cs
- [ ] T017 [P] [US2] Write failing integration tests for Configure and Validate Google Translation Access in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story2/Story2IntegrationTests.cs

### Implementation for User Story 2

- [ ] T018 [US2] Create story 2 domain model for Configure and Validate Google Translation Access in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story2/Story2Model.cs
- [ ] T019 [US2] Implement story 2 service workflow for Configure and Validate Google Translation Access in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story2/Story2Service.cs
- [ ] T020 [US2] Implement story 2 adapter endpoint or command mapping in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story2/Story2Adapter.cs
- [ ] T021 [US2] Add story 2 observability and error mapping in src/FlashyCardMaker.Infrastructure/Observability/001-google-translation-support/Story2Observability.cs

**Checkpoint**: User Story 2 is independently functional and testable.

---

## Phase 5: User Story 3 - Preserve Run Continuity on Translation Failures (Priority: P3)

**Goal**: Deliver User Story 3 functionality for Preserve Run Continuity on Translation Failures.

**Independent Test**: Can be tested by simulating translation failures for part of a dataset and confirming successful items are retained in output.

### Tests for User Story 3 (REQUIRED)

- [ ] T022 [P] [US3] Write failing unit tests for Preserve Run Continuity on Translation Failures in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/Story3/Story3UnitTests.cs
- [ ] T023 [P] [US3] Write failing integration tests for Preserve Run Continuity on Translation Failures in tests/FlashyCardMaker.Infrastructure.IntegrationTests/Features/001-google-translation-support/Story3/Story3IntegrationTests.cs

### Implementation for User Story 3

- [ ] T024 [US3] Create story 3 domain model for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story3/Story3Model.cs
- [ ] T025 [US3] Implement story 3 service workflow for Preserve Run Continuity on Translation Failures in src/FlashyCardMaker.Core/Features/001-google-translation-support/Story3/Story3Service.cs
- [ ] T026 [US3] Implement story 3 adapter endpoint or command mapping in src/FlashyCardMaker.UI.Cli/Features/001-google-translation-support/Story3/Story3Adapter.cs
- [ ] T027 [US3] Add story 3 observability and error mapping in src/FlashyCardMaker.Infrastructure/Observability/001-google-translation-support/Story3Observability.cs

**Checkpoint**: User Story 3 is independently functional and testable.

---

## Final Phase: Polish & Cross-Cutting Concerns

**Purpose**: Apply quality checks and hardening across all completed stories.

- [ ] T028 [P] Run quickstart validation and update steps in specs/001-google-translation-support/quickstart.md
- [ ] T029 [P] Add cross-story regression test coverage in tests/FlashyCardMaker.Core.UnitTests/Features/001-google-translation-support/CrossStoryRegressionTests.cs
- [ ] T030 Perform performance and reliability tuning for feature workflows in src/FlashyCardMaker.Core/Features/001-google-translation-support/PerformanceTuning.md
- [ ] T031 Update feature implementation notes and decisions in specs/001-google-translation-support/research.md

---

## Dependencies & Execution Order

- Setup (Phase 1) has no dependencies.
- Foundational (Phase 2) depends on Setup and blocks all user stories.
- User story phases depend on Foundational and can proceed in priority order or in parallel by team capacity.
- Final Phase depends on completion of selected user stories.

### User Story Completion Order

- US1 (P1): Translate Flashcard Text Using Google Service
- US2 (P2): Configure and Validate Google Translation Access
- US3 (P3): Preserve Run Continuity on Translation Failures

### Parallel Opportunities

- Tasks marked [P] can run in parallel when they touch different files and have no unmet dependencies.
- Within each story, failing test tasks can run in parallel first.
- After Foundational phase, user stories can be implemented concurrently.

## Parallel Example: User Story 1

```bash
Task: "Write failing unit tests for User Story 1"
Task: "Write failing integration tests for User Story 1"
```

## Implementation Strategy

### MVP First
1. Complete Phase 1 and Phase 2.
2. Deliver User Story 1 and validate it independently.
3. Continue with lower-priority stories incrementally.
