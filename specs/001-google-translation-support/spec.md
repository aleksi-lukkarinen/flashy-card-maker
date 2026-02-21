# Feature Specification: Google Translation Support

**Feature Branch**: `001-google-translation-support`  
**Created**: 2026-02-21  
**Status**: Draft  
**Input**: User description: "For translating text from a language to another, the application supports Google's Translation API."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Translate Flashcard Text Using Google Service (Priority: P1)

As a learner, I want flashcard text translated between selected languages using Google translation so I can study with reliable target-language content.

**Why this priority**: Translation is the primary value described for this feature.

**Independent Test**: Can be tested by selecting a source language and target language, requesting translation, and verifying returned text in generated cards.

**Acceptance Scenarios**:

1. **Given** source text and valid language selections, **When** the user runs translation, **Then** the system returns translated text for each eligible item using the configured Google translation service.
2. **Given** mixed valid and invalid source items, **When** translation runs, **Then** valid items are translated and invalid items are reported without stopping the entire run.
3. **Given** translation is disabled for a run, **When** card generation executes, **Then** the system does not request translation and preserves source text only.

---

### User Story 2 - Configure and Validate Google Translation Access (Priority: P2)

As a user, I want clear configuration and validation for Google translation access so I can detect setup issues before running large jobs.

**Why this priority**: Reliable setup prevents failed runs and user frustration.

**Independent Test**: Can be tested by running configuration checks with valid and invalid credentials and confirming clear pass/fail feedback.

**Acceptance Scenarios**:

1. **Given** required Google translation credentials are configured correctly, **When** validation is executed, **Then** the system confirms translation is ready for use.
2. **Given** credentials are missing or invalid, **When** translation is requested, **Then** the system blocks translation processing and returns actionable error details.
3. **Given** translation configuration is updated, **When** the next run starts, **Then** the system uses the updated configuration values.

---

### User Story 3 - Preserve Run Continuity on Translation Failures (Priority: P3)

As a user, I want translation failures to be isolated and reported so I still receive usable output from successful items.

**Why this priority**: Partial failure handling keeps the workflow productive in real-world remote-service conditions.

**Independent Test**: Can be tested by simulating translation failures for part of a dataset and confirming successful items are retained in output.

**Acceptance Scenarios**:

1. **Given** transient service failure for some requests, **When** translation runs, **Then** the system records failed items and continues processing remaining items.
2. **Given** translation requests exceed provider limits, **When** processing continues, **Then** the system reports rate-limit impacts and run completion status.
3. **Given** the run finishes with partial translation failures, **When** results are reviewed, **Then** the system shows translated count, failed count, and failure reasons.

---

### Edge Cases

- Source and target languages are the same, resulting in no-op translations.
- Unsupported language code is provided for either source or target.
- Input text exceeds service limits for a single request.
- Remote translation service is temporarily unavailable during batch processing.
- Response content is empty or malformed for a subset of items.

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST be modular: functional modules separated from UI modules, and each module is self-contained, independently testable, and documented.
- Work MUST follow TDD (tests written and failing before implementation; evidence of red-green-refactor required).
- Integration tests MUST cover all module integrations and any I/O to disk or network, including failure paths.
- Logging MUST support levels `none`, `error`, `warning`, `information`, `debug`, and `verbose`, with user-configurable log rotation and location.
- Program code MUST NOT contain secrets; sensitive values MUST come from user input or secure runtime configuration.

### Functional Requirements

- **FR-001**: System MUST support translation using Google's translation service for configured language pairs.
- **FR-002**: Users MUST be able to configure source and target languages for translation runs.
- **FR-003**: System MUST validate language selections before sending translation requests.
- **FR-004**: System MUST validate required Google translation credentials before processing translation requests.
- **FR-005**: System MUST translate each eligible input text item and attach translated text to output records.
- **FR-006**: System MUST skip translation for ineligible or invalid input items and report the reason for each skipped item.
- **FR-007**: System MUST continue processing remaining items when individual translation requests fail.
- **FR-008**: System MUST provide per-run translation metrics, including total items, translated items, skipped items, and failed items.
- **FR-009**: System MUST provide user-readable error messages for credential, language, request-limit, and service-availability failures.
- **FR-010**: System MUST allow translation support modules to be extended with additional providers in the future without changing unrelated modules.

### Key Entities *(include if feature involves data)*

- **Translation Request Item**: One source text entry with source language, target language, and translation eligibility state.
- **Translation Configuration**: User-provided settings including language choices and Google credential references.
- **Translation Result Item**: One processed item including translated text or structured failure details.
- **Translation Run Summary**: Aggregate run-level metrics and outcome statuses for reporting.

## Assumptions

- Users provide valid Google translation account access outside of application code.
- Translation may be optional per run depending on user configuration.
- Flashcard generation can proceed with partial translation coverage if some items fail.
- Existing output formats can store translated text fields.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: At least 95% of eligible items in normal runs are translated successfully.
- **SC-002**: Users can configure and validate translation access in under 5 minutes on first setup.
- **SC-003**: 100% of translation failures surface actionable error details tied to affected items or run-level conditions.
- **SC-004**: At least 90% of runs with partial translation failures still complete and produce usable flashcard output.
- **SC-005**: Pilot users report at least 85% confidence that translated output is suitable for language-learning review.
