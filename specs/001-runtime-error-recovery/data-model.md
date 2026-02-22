# Data Model: Runtime Error Recovery for Parallel Jobs

## Run Record
- Purpose: Metadata for a single batch execution including configuration snapshot, start/end times, and aggregate outcome.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Job Record
- Purpose: State for one parallel job including attempts, terminal status, output references, and last error.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Retry Policy
- Purpose: User-defined limits for retry count and retry-eligible error categories.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Failure Threshold Policy
- Purpose: User-defined threshold mapping that stops a run after repeated specific errors.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Output Artifact
- Purpose: Completed or partial produced result tied to a job and its finalization state.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## Resume Plan
- Purpose: Derived execution plan that selects only resumable/failed jobs from the latest run.
- Fields: NEEDS REFINEMENT DURING IMPLEMENTATION

## ValidationSummary

- Rules derived from functional requirements are validated before execution.
- Failure states are explicit and machine-readable.
- Sensitive values are redacted in logs and reports.
