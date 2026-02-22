# Feature Specification: Audio Filename Format

**Feature Branch**: `001-audio-filename-format`  
**Created**: 2026-02-21  
**Status**: Draft  
**Input**: User description: "The file names of generated audio files are to be unique but still human-readable. This must be achieved by using a form <lang>_<slug>_<hash>.<ext>, in which <lang> is a three-letter language code, slug is the beginning of the spoken text, and the hash is a base 64 -encoded SHA-256 hash over the language code and the full spoken text that the file represents. The slug must be at least 50 characters in length, must not break words, must be in lower case, must retain all the original Unicode characters except punctuation and repetitive white space, and must replace all white space characters with underscores. <ext> is the file extension according to the file format."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Generate Deterministic Human-Readable Audio Filenames (Priority: P1)

As a user, I want generated audio file names to be readable and consistent so I can identify files and avoid duplicates.

**Why this priority**: Filename generation is fundamental to storing and reusing generated audio.

**Independent Test**: Can be tested by generating filenames from fixed inputs and confirming exact output format and repeatability.

**Acceptance Scenarios**:

1. **Given** language code, spoken text, and output format, **When** a filename is generated, **Then** it follows `<lang>_<slug>_<hash>.<ext>`.
2. **Given** the same language code and full spoken text, **When** filename generation runs repeatedly, **Then** the generated hash and full filename are identical.
3. **Given** different spoken text with the same language code, **When** filenames are generated, **Then** the hash component differs.

---

### User Story 2 - Produce Valid Slug from Spoken Text (Priority: P2)

As a user, I want the slug part to stay readable and language-aware so filename text remains understandable.

**Why this priority**: Slug readability drives manual traceability of audio files.

**Independent Test**: Can be tested with multilingual input strings containing punctuation, mixed casing, and repeated whitespace.

**Acceptance Scenarios**:

1. **Given** spoken text with punctuation and repeated whitespace, **When** slug is created, **Then** punctuation is removed, repeated whitespace is normalized, and all whitespace becomes underscores.
2. **Given** spoken text containing Unicode letters, **When** slug is created, **Then** Unicode letters are retained and converted to lower case where applicable.
3. **Given** long spoken text, **When** slug is created, **Then** slug length is at least 50 characters and truncation does not split words.

---

### User Story 3 - Preserve Uniqueness Across Languages and Formats (Priority: P3)

As a user, I want filename uniqueness to account for language and full spoken text while preserving format-specific file extensions.

**Why this priority**: Distinguishing by language and text prevents collisions in multilingual datasets.

**Independent Test**: Can be tested by generating filenames for same text across multiple languages and output formats.

**Acceptance Scenarios**:

1. **Given** the same spoken text in two different language codes, **When** filenames are generated, **Then** hash values differ because language is part of hash input.
2. **Given** the same language and text but different audio formats, **When** filenames are generated, **Then** base name is unchanged and extension reflects format.
3. **Given** very short spoken text, **When** slug is generated, **Then** output remains valid and readable while following minimum-length rule using available text content rules.

---

### Edge Cases

- Spoken text includes only punctuation and whitespace.
- Spoken text contains non-Latin scripts, combining marks, or emoji.
- Input contains multiple consecutive whitespace characters including tabs and line breaks.
- Language code is not exactly three letters.
- Base64 output includes characters that may be unsafe in some file systems.

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST be modular: functional modules separated from UI modules, and each module is self-contained, independently testable, and documented.
- Work MUST follow TDD (tests written and failing before implementation; evidence of red-green-refactor required).
- Integration tests MUST cover all module integrations and any I/O to disk or network, including failure paths.
- Logging MUST support levels `none`, `error`, `warning`, `information`, `debug`, and `verbose`, with user-configurable log rotation and location.
- Program code MUST NOT contain secrets; sensitive values MUST come from user input or secure runtime configuration.

### Functional Requirements

- **FR-001**: System MUST generate audio filenames using `<lang>_<slug>_<hash>.<ext>`.
- **FR-002**: `<lang>` MUST be a three-letter language code.
- **FR-003**: `<slug>` MUST be derived from the beginning of spoken text and remain human-readable.
- **FR-004**: `<slug>` MUST be lower case.
- **FR-005**: `<slug>` MUST retain original Unicode text characters except punctuation.
- **FR-006**: `<slug>` MUST normalize repetitive whitespace and replace all whitespace characters with single underscores.
- **FR-007**: `<slug>` MUST be at least 50 characters long when sufficient non-punctuation content is available.
- **FR-008**: `<slug>` truncation MUST not split words.
- **FR-009**: `<hash>` MUST be computed from language code plus full spoken text using SHA-256 and encoded in base64 representation.
- **FR-010**: Filename generation MUST be deterministic for identical inputs.
- **FR-011**: `<ext>` MUST reflect the selected audio file format extension.
- **FR-012**: System MUST prevent filename collisions for differing language/text inputs under normal operation.

### Key Entities *(include if feature involves data)*

- **Filename Input Record**: Source object containing language code, full spoken text, and output audio format.
- **Slug Segment**: Human-readable normalized text fragment derived from spoken content.
- **Hash Segment**: Base64-encoded SHA-256 digest built from language code and full spoken text.
- **Audio Filename**: Final composed value `<lang>_<slug>_<hash>.<ext>`.

## Assumptions

- Hash encoding uses a filesystem-safe base64 variant to preserve portability while honoring the base64 requirement.
- If spoken text has less than 50 usable characters after normalization, the slug uses all available usable content.
- Word boundaries are defined by whitespace-separated tokens after normalization.
- File extension mapping is predefined by selected output audio format.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: 100% of generated filenames in validation tests match the required structural pattern.
- **SC-002**: 100% of repeated generations for identical input produce identical filenames.
- **SC-003**: At least 99.9% of tested differing language/text input pairs produce distinct filenames.
- **SC-004**: 100% of slug validation tests pass for lowercasing, whitespace normalization, punctuation removal, and word-safe truncation.
- **SC-005**: At least 95% of sampled filenames are rated readable by reviewers for quick manual identification.
