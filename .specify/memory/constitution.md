<!--
Sync Impact Report
- Version change: 1.0.0 -> 1.0.1
- Modified principles: none (new constitution)
- Added sections: Core Principles (5), Additional Constraints, Development Workflow, Governance
- Removed sections: none
- Templates requiring updates:
  - .specify/templates/plan-template.md (Constitution Check) -> ✅ updated
  - .specify/templates/tasks-template.md (tests mandatory) -> ✅ updated
  - .specify/templates/spec-template.md (reviewed) -> ✅ updated
  - .codex/commands/*.md and .agents/skills/*.md -> ✅ updated
- Follow-up TODOs: none
-->
# Flashy Card Maker Constitution

## Core Principles

### I. Modular Architecture
The application MUST use a modular architecture. Each module MUST be
self-contained, independently testable, and documented. Functional modules MUST
remain separated from user interface modules, and each user interface
implementation MUST be treated as a separate module.

Rationale: Isolation and clear boundaries reduce coupling and make replacement,
testing, and maintenance predictable.

### II. Test-Driven Development (NON-NEGOTIABLE)
TDD is mandatory. Work MUST follow this sequence: tests written, tests reviewed,
tests fail, implementation added, tests pass, refactor, tests pass again.
Feature work MUST NOT be merged without evidence of a red-green-refactor cycle.

Rationale: Enforced test-first workflow prevents regression-driven development
and validates behavior before implementation details solidify.

### III. Integration Testing
Each module MUST include integration tests for every module integration it
depends on. Any input/output behavior that accesses disk or network MUST have
integration test coverage for success and failure paths.

Rationale: Module correctness alone is insufficient when runtime behavior is
dominated by integration boundaries.

### IV. Logging
The application MUST support six log levels: `none`, `error`, `warning`,
`information`, `debug`, and `verbose`. Each module MUST honor log-level
configuration and emit appropriate diagnostics. Log rotation and log file
location MUST be configurable by the user.

Rationale: Consistent observability is required for debugging, supportability,
and production incident response.

### V. No Secrets in Program Code (NON-NEGOTIABLE)
Program code MUST NOT contain secrets or confidential values, including
usernames, passwords, application IDs, API keys, or authorization tokens.
Sensitive values MUST be provided by users or secure runtime configuration.

Rationale: Embedded secrets create immediate compromise risk and operational
breach exposure.

## Additional Constraints

- Modular boundaries MUST be enforced with separate test suites per module.
- Logging configuration MUST be user-configurable at runtime and documented.
- Secret material MUST be sourced from user input or secure configuration.

## Development Workflow

- TDD is mandatory for all feature work; red-green-refactor evidence is required
  for merge approval.
- Integration tests are required for all module integrations and I/O paths,
  including failure conditions.
- Module documentation updates are required when module boundaries or behavior
  change.

## Governance

- This constitution supersedes local conventions and applies to all work in this
  repository.
- Amendments MUST be documented, approved in code review, and recorded with a
  version bump following semantic versioning:
  - MAJOR: Backward-incompatible governance/principle removals or redefinitions.
  - MINOR: New principle/section added or materially expanded guidance.
  - PATCH: Clarifications or non-semantic refinements.
- All PRs and reviews MUST verify constitutional compliance before merge.

**Version**: 1.0.1 | **Ratified**: 2026-02-21 | **Last Amended**: 2026-02-21











