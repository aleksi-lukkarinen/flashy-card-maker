# Data Model: Language Card Pipeline

## Language Pair
- Purpose: A mapping of one source language to one target language, used for translation and audio assignment.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Source Data Provider
- Purpose: A configured source that supplies candidate flashcard content for generation.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Translation Service Assignment
- Purpose: A rule that links one target language to one translation service.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Audio Service Assignment
- Purpose: A rule that links one source-target language pair to one text-to-audio service.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Flashcard Record
- Purpose: A generated card containing source text, translated text, optional audio reference, and metadata.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Output Format Job
- Purpose: A unit of export work that writes generated flashcard records to one chosen output format.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Generation Run Summary
- Purpose: Result record describing processed inputs, service usage, successes, and failures.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
