# Research: CLI/TUI First Interface

## Decision 1: Command parsing and hierarchical help

- Decision: Use `System.CommandLine` with explicit command tree definitions and aliases for every option.
- Rationale: Native support for hierarchical command models, typed binding, validation middleware, and rich help generation aligns with strict help/alias requirements.
- Alternatives considered:
  - `Spectre.Console.Cli`: strong command model but weaker built-in parity for custom help aliases and deep parser customization.
  - `McMaster.Extensions.CommandLineUtils`: mature but less aligned with modern .NET first-party conventions.

## Decision 2: Modern TUI rendering

- Decision: Use `Spectre.Console` for interactive progress rendering, prompts, and rich text formatting.
- Rationale: Cross-platform terminal rendering with graceful degradation and minimal ceremony; integrates well with non-interactive CLI mode.
- Alternatives considered:
  - `Terminal.Gui`: richer full-screen model but heavier architecture for first release.
  - Plain ANSI rendering: simpler but lower usability and maintainability.

## Decision 3: Configuration pipeline

- Decision: Use layered `Microsoft.Extensions.Configuration` providers (JSON file + command line) with deterministic precedence where CLI overrides file values.
- Rationale: Standardized, testable, extensible pipeline supporting future configuration sources.
- Alternatives considered:
  - Custom parser/merger: higher maintenance and validation burden.
  - Environment-variable-first design: useful later, but not part of required scope.

## Decision 4: Logging and diagnostics

- Decision: Use `Serilog` with console and rolling-file sinks, level mapping for `none/error/warning/information/debug/verbose`, and centralized redaction middleware.
- Rationale: Structured logging with robust sink ecosystem and explicit level control.
- Alternatives considered:
  - `Microsoft.Extensions.Logging` only: viable baseline but less direct for rolling file management and formatting consistency.

## Decision 5: Security posture for CLI/config

- Decision: Enforce sensitive-key classification (`password`, `token`, `secret`, `apiKey`, etc.) and redact in logs/errors/help effective-config views.
- Rationale: Meets constitutional no-secrets and secure diagnostics requirements.
- Alternatives considered:
  - Allowlist-only output without classification: safer but too restrictive for diagnostics.

## Decision 6: Cross-platform support strategy

- Decision: Maintain OS-agnostic file/path abstractions and execute integration tests in CI matrix (Windows/macOS/Linux).
- Rationale: Ensures behavior consistency across supported .NET platforms.
- Alternatives considered:
  - Local-only platform validation: insufficient confidence for release quality.

## Decision 7: Exit code contract

- Decision: Standardize exit codes: `0` success, `2` validation/usage error, `3` configuration error, `4` runtime processing error, `130` cancellation/interrupted.
- Rationale: Predictable automation behavior and easier troubleshooting.
- Alternatives considered:
  - Single non-zero error code: lower clarity for scripts and operators.