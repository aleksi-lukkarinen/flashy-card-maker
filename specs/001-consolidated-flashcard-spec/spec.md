# Feature Specification: Consolidated Flashcard Workflow

**Feature Branch**: `001-consolidated-flashcard-spec`  
**Created**: 2026-02-22  
**Status**: Draft  
**Input**: User description: "If there is duplication between the specifications, couldn't you combine the original user's specifications and make a new specification of them?"

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Run One End-to-End Generation Workflow (Priority: P1)

A learner or content creator configures a flashcard run with source text, languages, provider choices, and output preferences, then executes a single workflow that returns usable flashcard results.

**Why this priority**: This is the core product value and consolidates duplicate pipeline requirements spread across previous specs.

**Independent Test**: Can be fully tested by creating one multilingual run from input to exported output and verifying resulting records.

**Acceptance Scenarios**:

1. **Given** valid source content, language selections, and required provider settings, **When** the user starts generation, **Then** the system produces flashcard records with expected source and translated text and reports run outcomes.
2. **Given** multiple selected output formats, **When** generation completes, **Then** the system attempts each selected format and reports per-format success or failure.

---

### User Story 2 - Configure and Discover Services Safely (Priority: P2)

A user configures translation and text-to-speech services, discovers available voices by language, and sees actionable validation messages before work starts.

**Why this priority**: Service configuration quality determines whether generated content is reliable and avoids repeated failures.

**Independent Test**: Can be fully tested by configuring service credentials and language settings, discovering voices, and validating the effective run configuration without generating cards.

**Acceptance Scenarios**:

1. **Given** required service fields are missing or invalid, **When** the user validates configuration, **Then** the system blocks execution and shows actionable field-level errors.
2. **Given** valid voice discovery settings, **When** the user requests voice options for a language, **Then** the system returns selectable voice entries and masks sensitive values in diagnostics.

---

### User Story 3 - Monitor, Recover, and Resume Long Runs (Priority: P3)

A user can monitor run progress in real time, understand partial failures, and resume interrupted runs without duplicating already completed work.

**Why this priority**: Large multilingual runs are long-running and failure-prone, so visibility and recovery are required for trust and operational continuity.

**Independent Test**: Can be fully tested by injecting failures and interruption events during a batch run and confirming continuation, resume behavior, and final summary accuracy.

**Acceptance Scenarios**:

1. **Given** one or more job failures during a multi-job run, **When** unaffected jobs continue, **Then** successful jobs finish and failed jobs are reported with terminal status and error reason.
2. **Given** an interrupted run with saved state, **When** the user triggers resume, **Then** previously completed jobs are skipped and only resumable or failed jobs are retried according to configured policy.

### Edge Cases

- A run includes unsupported or conflicting language assignments across translation, voice, and output settings.
- A provider request succeeds for some items but fails for others in the same run.
- A target output location is missing, invalid, or not writable for one language while other languages are valid.
- Source content contains punctuation-heavy, whitespace-heavy, or non-Latin text that affects audio filename generation.
- The run is canceled or interrupted while jobs are in progress, then resumed with changed retry or threshold settings.
- Localization text for a selected locale is incomplete and must fall back to default language resources.

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST remain modular so user-interface concerns and core workflow concerns are independently testable and replaceable.
- Work MUST be verified through tests that prove behavior for both happy paths and failure paths.
- Integration behavior MUST include external I/O boundaries and cover error handling.
- Logging MUST support configurable verbosity and configurable log retention behavior.
- Sensitive values MUST never be hardcoded and MUST be redacted from diagnostics.

### Functional Requirements

- **FR-001**: System MUST allow users to configure one or more source languages and one or more target languages per run.
- **FR-002**: System MUST allow users to provide source content from supported source-provider types and normalize it into a single generation record model.
- **FR-003**: System MUST allow users to enable or disable translation and audio generation independently for each run.
- **FR-004**: System MUST require valid translation-service assignments for enabled target languages before execution.
- **FR-005**: System MUST require valid audio-service assignments for enabled language pairs before execution.
- **FR-006**: System MUST provide voice discovery by language and expose selectable voice identifiers and display names.
- **FR-007**: System MUST validate required service configuration values before outbound requests and block requests when validation fails.
- **FR-008**: System MUST generate translations and optional audio outputs for eligible records according to configured assignments.
- **FR-009**: System MUST support exporting generated records to one or more selected output formats in the same run.
- **FR-010**: System MUST support CSV export with consistent header structure, full configured language columns, and valid row alignment.
- **FR-011**: System MUST support language-specific audio output destinations and route files to the configured destination for each language.
- **FR-012**: System MUST generate deterministic, human-readable, collision-resistant audio filenames from language, content-derived slug, and uniqueness component.
- **FR-013**: System MUST support configuration loading from file and command-line inputs with deterministic precedence and effective-configuration visibility.
- **FR-014**: System MUST provide progress visibility for batch and per-item execution, including active state when numeric progress is unavailable.
- **FR-015**: System MUST continue unaffected work when individual jobs fail and report per-item and per-run outcomes.
- **FR-016**: System MUST support retry policy and failure-threshold policy for recoverable errors.
- **FR-017**: System MUST persist run state and support resume behavior that skips already completed work and avoids duplicate finalized outputs.
- **FR-018**: System MUST provide user-facing run summaries that include counts, timing, status categories, and actionable failure details.
- **FR-019**: System MUST write rotating diagnostic logs with configurable level and include request/response context without storing sensitive secrets.
- **FR-020**: System MUST source user-facing text from localizable resources, use a defined default locale, and support runtime locale selection with fallback behavior.

### Key Entities *(include if feature involves data)*

- **Generation Run**: A user-initiated processing session with selected sources, languages, providers, and outputs.
- **Generation Record**: A normalized item containing source text, translated text values, optional audio references, and per-item status.
- **Language Pair Assignment**: Mapping of source language and target language to translation/audio behavior and selected services.
- **Provider Configuration**: User-managed settings for translation, voice discovery, and audio generation providers, including validation state.
- **Effective Configuration Snapshot**: Final merged run configuration showing resolved values and source origin for non-sensitive settings.
- **Job State Record**: Execution state for a unit of work including attempts, progress, terminal status, and error details.
- **Output Artifact**: Produced file or data export generated by one output-format job.
- **Run Summary**: Aggregated completion metrics and categorized outcomes for the run.

## Assumptions

- Existing feature specs remain as historical references and are not auto-deleted by this consolidation.
- Consolidation scope is functional alignment of overlapping product behavior; detailed implementation choices are deferred to planning.
- Existing command/help and interface expectations are preserved as user-facing behavior, regardless of internal UI technology choices.
- Resume behavior uses the latest persisted run snapshot as the baseline for determining completed versus pending work.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: At least 95% of valid end-to-end runs complete with at least one successful output artifact.
- **SC-002**: 100% of invalid required configuration inputs are detected before run execution begins.
- **SC-003**: At least 90% of interrupted runs are resumable without reprocessing previously completed work.
- **SC-004**: 100% of completed runs provide per-item and aggregate outcome summaries with explicit status categories.
- **SC-005**: 100% of security validation checks confirm sensitive credential values are absent from persisted diagnostics.
- **SC-006**: At least 95% of users can complete a first successful generation run using built-in guidance without external assistance.
