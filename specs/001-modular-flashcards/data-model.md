# Data Model: Modular Flashcard Platform

## Source Import Definition
- Purpose: Describes a supported input format, validation rules, and mapping rules into card fields.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Flashcard Item
- Purpose: Represents one generated card, including source text, optional translated text, optional audio asset reference, and status markers.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Provider Configuration
- Purpose: Stores endpoint and credential references plus user-selected behavior for a translation or audio provider.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Generation Profile
- Purpose: User-owned configuration preset containing source mapping options, provider choices, feature toggles, and output defaults.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Generation Run Record
- Purpose: Captures one execution result, including totals, per-item outcomes, failures, and produced outputs.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Output Package
- Purpose: Represents exported flashcard data in a chosen format with any compatible enriched assets.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
