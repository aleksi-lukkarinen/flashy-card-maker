# Data Model: Flashcard Data Generator

## Word/Phrase List
- Purpose: A user-provided collection of text entries with a single declared source language.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## List Item
- Purpose: A single word or phrase within a list, including its original text and validation status.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Target Language
- Purpose: A language selected for translation and audio generation.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Voice Selection
- Purpose: The chosen voice associated with a specific target language.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Translation
- Purpose: The translated text for a list item in a target language.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Audio Asset
- Purpose: The generated speech audio file associated with a translation.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Export Row
- Purpose: A record containing source text, target text, target language, and audio file name.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Generation Run
- Purpose: A processing session that produces translations, audio assets, and export output for a list.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
