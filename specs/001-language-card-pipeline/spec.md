# Feature Specification: Language Card Pipeline

**Feature Branch**: `001-language-card-pipeline`  
**Created**: 2026-02-21  
**Status**: Draft  
**Input**: User description: "The primary use of the application is to create flash cards for language learning. The user interface allows the user to configure 1) source languages and target languages; 2) sources for reading source data; 3) one remote service for producing translations per target language; 4) one remote service per unique source and target language for converting text to audio; and 5) several output formats, to which the application produces the resulting flash card data."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Configure and Generate Multilingual Flashcards (Priority: P1)

As a language learner, I want to select source and target languages plus data sources so I can generate flashcards for my selected language pairs.

**Why this priority**: This is the primary product outcome and core learning value.

**Independent Test**: Can be fully tested by selecting at least one source language and one target language, running generation, and verifying created cards.

**Acceptance Scenarios**:

1. **Given** a valid source dataset and chosen source and target languages, **When** the user starts generation, **Then** the system creates flashcards for each selected language pair.
2. **Given** multiple source data sources are configured, **When** generation runs, **Then** the system processes all selected sources into one coherent flashcard result set.
3. **Given** no valid language pair is selected, **When** the user attempts generation, **Then** the system blocks the run and explains what must be configured.

---

### User Story 2 - Assign Translation and Audio Services by Language Pair (Priority: P2)

As a language learner, I want to assign one translation service per target language and one text-to-audio service per source-target pair so generated cards include the right translation and pronunciation assets.

**Why this priority**: Enrichment with translation and audio strongly improves learning effectiveness after core card generation is available.

**Independent Test**: Can be tested by configuring two target languages and verifying that selected services are used correctly for each target and each language pair.

**Acceptance Scenarios**:

1. **Given** a configured target language, **When** generation requests translation, **Then** the system uses the assigned translation service for that target language.
2. **Given** a configured source-target language pair, **When** generation requests audio, **Then** the system uses the assigned text-to-audio service for that specific pair.
3. **Given** a required service assignment is missing for an enabled language pair, **When** generation starts, **Then** the system prevents execution and reports missing assignments.

---

### User Story 3 - Export Results in Multiple Output Formats (Priority: P3)

As a learner, I want to export resulting flashcard data to multiple output formats so I can study with different tools.

**Why this priority**: Export flexibility supports downstream usage but depends on successful card generation and enrichment.

**Independent Test**: Can be tested by generating one dataset and exporting it to each supported output format, then validating output completeness.

**Acceptance Scenarios**:

1. **Given** generated flashcard data exists, **When** the user selects one output format, **Then** the system produces export data in that format.
2. **Given** multiple output formats are selected, **When** export runs, **Then** the system produces all selected outputs from the same generation result.
3. **Given** one output target fails, **When** export runs for multiple formats, **Then** successful outputs are still produced and failures are reported clearly.

---

### Edge Cases

- A target language is selected without a translation service assignment.
- A source-target pair is valid for translation but has no audio service assignment.
- Different source data inputs contain duplicate records for the same language pair.
- A selected output format cannot represent optional audio fields.
- One remote service times out while other configured services remain available.

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST be modular: functional modules separated from UI modules, and each module is self-contained, independently testable, and documented.
- Work MUST follow TDD (tests written and failing before implementation; evidence of red-green-refactor required).
- Integration tests MUST cover all module integrations and any I/O to disk or network, including failure paths.
- Logging MUST support levels `none`, `error`, `warning`, `information`, `debug`, and `verbose`, with user-configurable log rotation and location.
- Program code MUST NOT contain secrets; sensitive values MUST come from user input or secure runtime configuration.

### Functional Requirements

- **FR-001**: Users MUST be able to configure one or more source languages and one or more target languages per run.
- **FR-002**: Users MUST be able to configure one or more source data providers for reading flashcard input content.
- **FR-003**: System MUST require exactly one translation service assignment per configured target language when translation is enabled.
- **FR-004**: System MUST require exactly one text-to-audio service assignment per unique source-target language pair when audio generation is enabled for that pair.
- **FR-005**: System MUST validate language, source, and service assignments before generation begins.
- **FR-006**: System MUST generate flashcard content from all selected source data providers for all valid language pairs.
- **FR-007**: System MUST request translations using the assigned service for each target language.
- **FR-008**: System MUST request audio generation using the assigned service for each configured source-target pair.
- **FR-009**: Users MUST be able to select one or more output formats for generated flashcard results.
- **FR-010**: System MUST export generated results to all selected output formats in a single run.
- **FR-011**: System MUST continue producing successful outputs if one output format fails and MUST report per-format failures.
- **FR-012**: System MUST allow new source-data providers, translation services, audio services, and output formats to be added without modifying unrelated provider modules.
- **FR-013**: System MUST present a clear run summary including selected languages, assigned services, processed sources, and export outcomes.

### Key Entities *(include if feature involves data)*

- **Language Pair**: A mapping of one source language to one target language, used for translation and audio assignment.
- **Source Data Provider**: A configured source that supplies candidate flashcard content for generation.
- **Translation Service Assignment**: A rule that links one target language to one translation service.
- **Audio Service Assignment**: A rule that links one source-target language pair to one text-to-audio service.
- **Flashcard Record**: A generated card containing source text, translated text, optional audio reference, and metadata.
- **Output Format Job**: A unit of export work that writes generated flashcard records to one chosen output format.
- **Generation Run Summary**: Result record describing processed inputs, service usage, successes, and failures.

## Assumptions

- Users configure service credentials before starting generation runs.
- Translation and audio generation can be enabled or disabled independently.
- If multiple source providers return overlapping content, deduplication follows a deterministic rule defined by product policy.
- Initial scope is single-user run configuration, not collaborative multi-user editing.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: 95% of valid configured generation runs complete with at least one successful output format.
- **SC-002**: Users can configure a new language-learning run (languages, sources, services, outputs) in under 8 minutes on first attempt.
- **SC-003**: 100% of generated translations and audio outputs in acceptance tests match the configured per-language and per-pair service assignments.
- **SC-004**: At least 90% of pilot users successfully export one run to two or more output formats without support.
- **SC-005**: Adding one new provider type in each category (source, translation, audio, output) does not introduce regressions in existing acceptance scenarios.
