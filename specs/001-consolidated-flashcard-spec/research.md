# Research: Consolidated Flashcard Workflow

## Decision 1: Canonical orchestration boundary

- Decision: Implement one canonical `GenerationRun` orchestration contract that all UI commands call instead of feature-specific workflow variants.
- Rationale: Consolidates duplicated requirements and prevents behavioral drift between overlapping implementations.
- Alternatives considered:
  - Keep separate workflow handlers per legacy feature (rejected: duplication and inconsistent failure semantics).

## Decision 2: Validation-first execution gate

- Decision: Enforce preflight validation for language assignments, provider settings, output destinations, and sensitive configuration before any processing starts.
- Rationale: Reduces wasted work, prevents invalid outbound requests, and provides deterministic user feedback.
- Alternatives considered:
  - Lazy validation during execution (rejected: partial side effects before configuration failure).

## Decision 3: Resilience model for long-running runs

- Decision: Use per-item independent job state, configurable retry policy, and threshold-based run stop policy with persisted run snapshots for resume.
- Rationale: Aligns with requirements for continuation, partial success, and deterministic non-duplication on reruns.
- Alternatives considered:
  - Fail-fast run cancellation on first error (rejected: unacceptable throughput loss and poor recovery UX).

## Decision 4: Output and artifact consistency

- Decision: Normalize generated records first, then fan out to output format jobs (including CSV) and language-routed audio artifacts.
- Rationale: Shared normalized record model removes duplicate mapping rules and keeps export behavior consistent.
- Alternatives considered:
  - Per-output independent transformation pipelines (rejected: repeated mapping logic and divergence risk).

## Decision 5: Observability and security policy

- Decision: Apply structured logging with required six levels, runtime-configurable rotation/location, and centralized redaction for sensitive fields.
- Rationale: Supports diagnostics for provider failures and resume behavior while meeting constitution constraints.
- Alternatives considered:
  - Unstructured ad-hoc logging (rejected: weak diagnosability and higher leakage risk).

## Decision 6: Localization strategy

- Decision: Route all user-facing messages through localization resources with default locale fallback for missing entries.
- Rationale: Supports runtime locale switching and avoids string duplication across UI workflows.
- Alternatives considered:
  - Localize only final UI screens/messages (rejected: mixed-language output and inconsistent experience).

## Validation Note 2026-02-22

- Quickstart validation was executed at source and file-structure level.
- Full `dotnet test` execution in this sandbox is currently constrained by environment-level restrictions for restore/temp tooling paths and timed-out execution.
- Implementation artifacts are prepared to run with workspace-local `DOTNET_CLI_HOME`, `TMP`, and `TEMP` in a normal developer shell.
