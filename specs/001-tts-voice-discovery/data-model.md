# Data Model: TTS Voice Discovery

## Voice Query Request
- Purpose: Input object containing language, service identity, credential reference, and optional collection filter.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Voice Catalog Entry
- Purpose: One discovered voice with normalized voice name and unique voice ID.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Voice Query Configuration
- Purpose: Persisted settings for the TTS service, including required parameter rules.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Voice Query Result
- Purpose: Structured query outcome with valid voices, excluded entries, and error details if present.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
