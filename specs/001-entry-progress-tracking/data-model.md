# Data Model: Entry Progress Tracking

## Processing Entry
- Purpose: One source record moving through the processing pipeline.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Entry Phase State
- Purpose: Current lifecycle phase for a processing entry.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Operation Progress Snapshot
- Purpose: Per-entry status update containing operation type, progress state, and optional numeric progress.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Entry Timer Record
- Purpose: Elapsed-time data for a single entry.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Batch Timer Record
- Purpose: Total elapsed-time data for the complete processing run.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Run Progress View Model
- Purpose: Aggregated structure consumed by UI to render per-entry and total progress/timing.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
