# Tasks: Quality and Testability Standards

**Input**: Design documents from `F:\dev\C#\flashy-card-maker\specs\001-quality-testability-standards\`
**Prerequisites**: `plan.md`, `spec.md`, `research.md`, `data-model.md`, `contracts/openapi.yaml`, `quickstart.md`

**Tests**: Tests are REQUIRED for all user stories and integrations per the constitution. Include unit, integration, and contract tests.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Every task includes an exact file path

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Initialize quality-governance project structure and baseline tooling.

- [ ] T001 Create quality module skeleton in `src/FlashyCardMaker.Quality/FlashyCardMaker.Quality.csproj`
- [ ] T002 Create quality test project skeleton in `tests/FlashyCardMaker.Quality.Tests/FlashyCardMaker.Quality.Tests.csproj`
- [ ] T003 [P] Add quality-project references and solution entries in `flashy-card-maker.sln`
- [ ] T004 [P] Add baseline governance configuration file in `src/FlashyCardMaker.Quality/Configuration/quality-rules.json`
- [ ] T005 [P] Add CI quality gate step placeholder in `.github/workflows/ci.yml`

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Build core governance primitives required by all user stories.

**CRITICAL**: No user story implementation begins before this phase is complete.

- [ ] T006 Define core domain models (`QualityRule`, `QualityFinding`, `QualityRunReport`) in `src/FlashyCardMaker.Quality/Models/QualityModels.cs`
- [ ] T007 [P] Define contracts (`IQualityRuleProvider`, `IQualityScanner`, `IQualityReporter`) in `src/FlashyCardMaker.Quality/Abstractions/QualityAbstractions.cs`
- [ ] T008 [P] Implement governance run orchestrator in `src/FlashyCardMaker.Quality/Services/QualityRunService.cs`
- [ ] T009 Implement report persistence abstraction and file adapter in `src/FlashyCardMaker.Quality/Infrastructure/FileQualityReportStore.cs`
- [ ] T010 [P] Add foundational unit tests for model validation/state transitions in `tests/FlashyCardMaker.Quality.Tests/Unit/QualityModelsTests.cs`
- [ ] T011 [P] Add foundational integration test for report persistence in `tests/FlashyCardMaker.Quality.Tests/Integration/FileQualityReportStoreTests.cs`
- [ ] T012 Configure structured logging hooks for quality runs in `src/FlashyCardMaker.Quality/Observability/QualityLogging.cs`

**Checkpoint**: Foundation ready; user story phases can proceed.

---

## Phase 3: User Story 1 - Maintainable Responsibility Boundaries (Priority: P1) (MVP)

**Goal**: Enforce responsibility-focused component boundaries and pattern-usage discipline.

**Independent Test**: Governance scan identifies responsibility violations and missing pattern justification records in pilot modules.

### Tests for User Story 1 (REQUIRED)

- [ ] T013 [P] [US1] Add contract test for `GET /quality/rules` in `tests/FlashyCardMaker.Quality.Tests/Contract/QualityRulesContractTests.cs`
- [ ] T014 [P] [US1] Add integration test for responsibility-boundary rule detection in `tests/FlashyCardMaker.Quality.Tests/Integration/ResponsibilityBoundaryRuleTests.cs`
- [ ] T015 [P] [US1] Add integration test for missing pattern-justification detection in `tests/FlashyCardMaker.Quality.Tests/Integration/PatternJustificationRuleTests.cs`

### Implementation for User Story 1

- [ ] T016 [P] [US1] Implement responsibility-boundary rule evaluator in `src/FlashyCardMaker.Quality/Rules/ResponsibilityBoundaryRule.cs`
- [ ] T017 [P] [US1] Implement pattern-justification rule evaluator in `src/FlashyCardMaker.Quality/Rules/PatternJustificationRule.cs`
- [ ] T018 [US1] Implement rule catalog provider and category registration in `src/FlashyCardMaker.Quality/Services/QualityRuleCatalog.cs`
- [ ] T019 [US1] Implement `GET /quality/rules` endpoint handler in `src/FlashyCardMaker.Quality/Api/QualityRulesEndpoint.cs`
- [ ] T020 [US1] Add pattern-justification template and loader in `docs/architecture/pattern-justifications/template.md`
- [ ] T021 [US1] Wire US1 rules into quality run pipeline in `src/FlashyCardMaker.Quality/Services/QualityRunService.cs`

**Checkpoint**: US1 delivers an MVP governance slice and is independently testable.

---

## Phase 4: User Story 2 - Deterministic Tests via Explicit Dependencies (Priority: P2)

**Goal**: Detect hidden hard-coded dependencies and validate dependency substitution testability.

**Independent Test**: Governance scan flags hidden runtime dependencies and passes when substitution-ready boundaries exist.

### Tests for User Story 2 (REQUIRED)

- [ ] T022 [P] [US2] Add contract test for `POST /quality/runs` in `tests/FlashyCardMaker.Quality.Tests/Contract/StartQualityRunContractTests.cs`
- [ ] T023 [P] [US2] Add integration test for hidden dependency detection in `tests/FlashyCardMaker.Quality.Tests/Integration/HiddenDependencyRuleTests.cs`
- [ ] T024 [P] [US2] Add integration test for dependency substitution evidence validation in `tests/FlashyCardMaker.Quality.Tests/Integration/DependencySubstitutionEvidenceTests.cs`

### Implementation for User Story 2

- [ ] T025 [P] [US2] Implement hidden-dependency rule evaluator in `src/FlashyCardMaker.Quality/Rules/HiddenDependencyRule.cs`
- [ ] T026 [P] [US2] Implement dependency-contract evidence collector in `src/FlashyCardMaker.Quality/Evidence/DependencyContractCollector.cs`
- [ ] T027 [US2] Implement quality run request validator for testability categories in `src/FlashyCardMaker.Quality/Validation/QualityRunRequestValidator.cs`
- [ ] T028 [US2] Implement `POST /quality/runs` endpoint handler in `src/FlashyCardMaker.Quality/Api/StartQualityRunEndpoint.cs`
- [ ] T029 [US2] Integrate US2 rule set into run summary and severity thresholds in `src/FlashyCardMaker.Quality/Services/QualityRunService.cs`

**Checkpoint**: US1 and US2 both pass independently with dedicated tests.

---

## Phase 5: User Story 3 - External Configuration Governance (Priority: P3)

**Goal**: Enforce externalized configuration and validate behavior across environment-specific inputs.

**Independent Test**: Governance scan catches hard-coded runtime values and validates configuration item registration/validation behavior.

### Tests for User Story 3 (REQUIRED)

- [ ] T030 [P] [US3] Add contract test for `GET /quality/runs/{runId}` in `tests/FlashyCardMaker.Quality.Tests/Contract/GetQualityRunReportContractTests.cs`
- [ ] T031 [P] [US3] Add contract test for `POST /quality/findings/{findingId}/waive` in `tests/FlashyCardMaker.Quality.Tests/Contract/WaiveFindingContractTests.cs`
- [ ] T032 [P] [US3] Add integration test for external-configuration rule detection in `tests/FlashyCardMaker.Quality.Tests/Integration/ExternalConfigurationRuleTests.cs`
- [ ] T033 [P] [US3] Add integration test for invalid configuration item handling in `tests/FlashyCardMaker.Quality.Tests/Integration/ConfigurationValidationRuleTests.cs`

### Implementation for User Story 3

- [ ] T034 [P] [US3] Implement external-configuration rule evaluator in `src/FlashyCardMaker.Quality/Rules/ExternalConfigurationRule.cs`
- [ ] T035 [P] [US3] Implement configuration-item registry loader in `src/FlashyCardMaker.Quality/Configuration/ConfigurationItemRegistry.cs`
- [ ] T036 [US3] Implement report retrieval endpoint handler in `src/FlashyCardMaker.Quality/Api/GetQualityRunReportEndpoint.cs`
- [ ] T037 [US3] Implement finding waiver endpoint handler in `src/FlashyCardMaker.Quality/Api/WaiveFindingEndpoint.cs`
- [ ] T038 [US3] Add deterministic conflict-handling policy for configuration sources in `src/FlashyCardMaker.Quality/Validation/ConfigurationConflictPolicy.cs`
- [ ] T039 [US3] Integrate US3 rules and waiver lifecycle into quality run pipeline in `src/FlashyCardMaker.Quality/Services/QualityRunService.cs`

**Checkpoint**: All user stories independently functional and testable.

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final hardening, documentation, and CI tuning across stories.

- [ ] T040 [P] Add end-to-end governance workflow test in `tests/FlashyCardMaker.Quality.Tests/Integration/QualityGovernanceEndToEndTests.cs`
- [ ] T041 [P] Add performance benchmark test for governance runtime budget in `tests/FlashyCardMaker.Quality.Tests/Performance/QualityRunPerformanceTests.cs`
- [ ] T042 Update quickstart with validated commands and expected outputs in `specs/001-quality-testability-standards/quickstart.md`
- [ ] T043 [P] Update governance documentation and review checklist in `docs/quality/quality-governance.md`
- [ ] T044 Finalize CI fail-threshold enforcement and artifact publishing in `.github/workflows/ci.yml`

---

## Dependencies & Execution Order

### Phase Dependencies

- Phase 1 (Setup): no dependencies.
- Phase 2 (Foundational): depends on Phase 1; blocks all user stories.
- Phase 3 (US1): depends on Phase 2; MVP slice.
- Phase 4 (US2): depends on Phase 2; can run in parallel with Phase 3 if staffed.
- Phase 5 (US3): depends on Phase 2; can run in parallel with Phase 3/4 if staffed.
- Phase 6 (Polish): depends on completion of selected user stories.

### User Story Dependencies

- **US1 (P1)**: No dependency on other user stories.
- **US2 (P2)**: No hard dependency on US1; integrates shared foundation.
- **US3 (P3)**: No hard dependency on US1/US2; integrates shared foundation.

### Within Each User Story

- Tests must be written first and fail before implementation (TDD).
- Rule/model additions before service/orchestration integration.
- Endpoint handlers after service contracts and validations exist.
- Story checkpoint requires independent test pass.

### Parallel Opportunities

- Setup tasks marked `[P]` can run together.
- Foundational tests and abstractions marked `[P]` can run in parallel.
- After Phase 2, US1/US2/US3 can proceed concurrently.
- Contract/integration tests within each story marked `[P]` can run concurrently.

---

## Parallel Example: User Story 2

```bash
# Write failing tests in parallel
Task: "T022 [US2] Contract test for POST /quality/runs"
Task: "T023 [US2] Integration test for hidden dependency detection"
Task: "T024 [US2] Integration test for dependency substitution evidence"

# Implement independent rule/evidence components in parallel
Task: "T025 [US2] Hidden-dependency rule evaluator"
Task: "T026 [US2] Dependency-contract evidence collector"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1 and Phase 2.
2. Complete Phase 3 (US1) with failing-first tests.
3. Validate US1 independently via `ResponsibilityBoundaryRuleTests` and `PatternJustificationRuleTests`.
4. Demo/publish MVP governance slice.

### Incremental Delivery

1. Foundation ready (Phases 1-2).
2. Deliver US1 (maintainability/pattern governance).
3. Deliver US2 (dependency/testability governance).
4. Deliver US3 (external configuration governance).
5. Execute Phase 6 hardening and CI tuning.

### Parallel Team Strategy

1. Team completes setup/foundation together.
2. Split by story after Phase 2:
   - Engineer A: US1
   - Engineer B: US2
   - Engineer C: US3
3. Merge at Phase 6 with full integration validation.

---

## Notes

- All tasks use strict checklist format with IDs, optional `[P]`, and `[US#]` labels for story tasks.
- Paths align with the project structure defined in `plan.md`.
- TDD is explicit: tests precede implementation per story.