# Feature Specification: Flashcard Data Generator

**Feature Branch**: `001-flashcard-data-generator`  
**Created**: February 21, 2026  
**Status**: Draft  
**Input**: User description: "The application does not offer features for using flashcards. Instead, it is a utility for creating flashcard data to be imported into other flashcard applications, such as Anki. The main workflow that the application provides is as follows: 1) The user configures the application, including requesting available voices and choosing what they want. 2) The user specifies lists of words and phrases, of which they want flashcards to be made. Those lists can be in various languages. 3) From those lists, all items are translated to each of the target languages, converted from text into speech audio files. 4) The related data (e.g., source and target phrases and the file names of the audio files) is outputted in a format choosen by the user."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Configure Voices and Targets (Priority: P1)

As a user preparing flashcard data, I want to view available voices and select voices and target languages so that audio generation uses my preferred speech settings.

**Why this priority**: Without configuration, the system cannot generate audio in the desired languages or voices, blocking the core workflow.

**Independent Test**: Can be fully tested by requesting available voices, selecting choices, saving the configuration, and reloading it without running any translation or export.

**Acceptance Scenarios**:

1. **Given** no prior configuration, **When** the user requests available voices, **Then** the system presents a list of voices grouped by language.
2. **Given** the voice list, **When** the user selects target languages and voices and saves, **Then** the configuration is persisted and can be reloaded accurately.

---

### User Story 2 - Provide Word and Phrase Lists (Priority: P2)

As a user, I want to provide lists of words and phrases with a defined source language so that the system knows what to translate and how to process each list.

**Why this priority**: The system cannot create translations or audio without knowing what content to process and the source language for each list.

**Independent Test**: Can be fully tested by entering or importing a list, validating it, and confirming it is ready for processing without generating any translations or audio.

**Acceptance Scenarios**:

1. **Given** a list with a declared source language, **When** the user submits it, **Then** the system validates the entries and marks the list as ready or reports specific validation errors.

---

### User Story 3 - Generate Translations, Audio, and Export (Priority: P3)

As a user, I want the system to translate each item into my selected target languages, generate audio files, and export the data in my chosen format so that I can import it into a flashcard app.

**Why this priority**: This is the primary outcome of the product: producing importable flashcard data.

**Independent Test**: Can be fully tested by running a generation job for a prepared list and confirming that translations, audio files, and export output are produced with correct mappings.

**Acceptance Scenarios**:

1. **Given** a configured set of voices and a validated list, **When** the user runs generation, **Then** the system produces translations and audio for each item in each target language.
2. **Given** successful generation, **When** the user selects an export format, **Then** the system outputs data that includes source text, target text, and corresponding audio file names for each item.

---

### Edge Cases

- What happens when a list is empty or contains only whitespace entries?
- How does the system handle items that cannot be translated to a target language?
- What happens when a selected voice is unavailable for a target language?
- How does the system handle duplicate entries within a list?
- What happens when audio generation fails for a specific item?

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST be modular: functional modules separated from UI modules, and each
  module is self-contained, independently testable, and documented.
- Work MUST follow TDD (tests written and failing before implementation; evidence
  of red-green-refactor required).
- Integration tests MUST cover all module integrations and any I/O to disk or
  network, including failure paths.
- Logging MUST support levels `none`, `error`, `warning`, `information`, `debug`,
  and `verbose`, with user-configurable log rotation and location.
- Program code MUST NOT contain secrets; sensitive values MUST come from user
  input or secure runtime configuration.

### Functional Requirements

- **FR-001**: System MUST allow users to request and view available voices grouped by language.
- **FR-002**: System MUST allow users to select target languages and a preferred voice for each target language.
- **FR-003**: System MUST allow users to provide lists of words and phrases with an explicit source language per list.
- **FR-004**: System MUST validate lists for empty entries and unsupported languages, and report validation errors clearly.
- **FR-005**: System MUST translate each list item into each selected target language.
- **FR-006**: System MUST generate a speech audio file for each translated item in each target language.
- **FR-007**: System MUST associate each translated item with its corresponding audio file name in the exported data.
- **FR-008**: System MUST allow users to choose an export format from the supported formats.
- **FR-009**: System MUST export data that includes source text, target text, target language, and audio file name for each item.
- **FR-010**: System MUST provide a summary of processing results, including counts of successes and failures per target language.
- **FR-011**: System MUST surface partial failures and allow the export of successfully processed items with clear error reporting for failures.

### Key Entities *(include if feature involves data)*

- **Word/Phrase List**: A user-provided collection of text entries with a single declared source language.
- **List Item**: A single word or phrase within a list, including its original text and validation status.
- **Target Language**: A language selected for translation and audio generation.
- **Voice Selection**: The chosen voice associated with a specific target language.
- **Translation**: The translated text for a list item in a target language.
- **Audio Asset**: The generated speech audio file associated with a translation.
- **Export Row**: A record containing source text, target text, target language, and audio file name.
- **Generation Run**: A processing session that produces translations, audio assets, and export output for a list.

## Assumptions

- Each list has exactly one declared source language.
- Audio is generated for target-language translations; source-language audio is only generated if the user explicitly chooses to include it.
- Export formats are predefined by the application and chosen by the user at export time.
- Users provide any required credentials or access settings during configuration.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Users can complete configuration (voice discovery and selection) in under 5 minutes on first use.
- **SC-002**: For a list of 1,000 items and 3 target languages, at least 98% of items complete translation and audio generation in a single run.
- **SC-003**: 95% of users can produce an export file that imports successfully into their chosen flashcard application on the first attempt.
- **SC-004**: Users can identify and resolve validation errors for a list in under 10 minutes using the system’s error reporting.
