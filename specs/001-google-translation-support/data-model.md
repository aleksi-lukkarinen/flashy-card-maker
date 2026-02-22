# Data Model: Google Translation Support

## Translation Request Item
- Purpose: One source text entry with source language, target language, and translation eligibility state.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Translation Configuration
- Purpose: User-provided settings including language choices and Google credential references.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Translation Result Item
- Purpose: One processed item including translated text or structured failure details.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Translation Run Summary
- Purpose: Aggregate run-level metrics and outcome statuses for reporting.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
