# Data Model: CLI/TUI First Interface

## 1. CommandNode

- Purpose: Represents a command or subcommand in the hierarchical CLI tree.
- Fields:
  - `Name` (string, required)
  - `Aliases` (collection, required, includes canonical long form)
  - `Description` (string, required)
  - `ParentCommand` (nullable reference)
  - `Options` (collection of `OptionNode`)
  - `Subcommands` (collection of `CommandNode`)
- Validation Rules:
  - Command name must be unique among siblings.
  - Aliases must be unique across command scope.

## 2. OptionNode

- Purpose: Represents one command-line option/switch.
- Fields:
  - `LongAlias` (string, required, format `--name`)
  - `ShortAlias` (string, required, format `-n`)
  - `ValueType` (enum/string, required)
  - `IsRequired` (bool)
  - `DefaultValue` (optional)
  - `IsSensitive` (bool)
  - `HelpText` (string, required)
- Validation Rules:
  - Must provide both long and short aliases.
  - Alias pair must be unique in command scope.
  - Sensitive options must be redacted in diagnostics.

## 3. ConfigValueEntry

- Purpose: Captures one setting value with source attribution.
- Fields:
  - `Key` (string, required)
  - `RawValue` (string/object, optional)
  - `SourceType` (enum: `File`, `CommandLine`)
  - `SourceIdentifier` (string, e.g., path or argument token)
  - `IsSensitive` (bool)
- Validation Rules:
  - SourceType must be known.
  - Key must map to declared setting definition.

## 4. EffectiveConfiguration

- Purpose: Final merged and validated configuration used by execution.
- Fields:
  - `Values` (dictionary of normalized typed values)
  - `Origins` (dictionary key -> source metadata)
  - `ValidationErrors` (collection)
  - `Warnings` (collection)
- State Transitions:
  - `Unresolved` -> `Merged` -> `Validated` -> (`Ready` | `Rejected`)

## 5. ExecutionRequest

- Purpose: UI-agnostic request passed from CLI adapter to application core.
- Fields:
  - `Operation` (string)
  - `Parameters` (typed payload object)
  - `CorrelationId` (string)
  - `RequestedAtUtc` (datetime)
  - `RequestedBy` (string, optional)
- Validation Rules:
  - Operation must map to supported use case.
  - Parameters must satisfy operation schema.

## 6. ExecutionResult

- Purpose: Normalized application response returned to CLI adapter.
- Fields:
  - `Status` (enum: `Success`, `ValidationError`, `ConfigError`, `RuntimeError`, `Cancelled`)
  - `ExitCode` (int)
  - `Messages` (collection)
  - `Metrics` (duration/counts)
  - `Artifacts` (references to generated outputs)
- State Transitions:
  - `Running` -> (`Success` | `ValidationError` | `ConfigError` | `RuntimeError` | `Cancelled`)

## 7. LogEventModel

- Purpose: Structured event for Serilog sink emission.
- Fields:
  - `TimestampUtc` (datetime)
  - `Level` (enum: `none/error/warning/information/debug/verbose`)
  - `Category` (string)
  - `MessageTemplate` (string)
  - `Properties` (map, with redaction policy)
- Validation Rules:
  - Level must map from CLI/config level choice.
  - Sensitive property keys must be redacted before sink write.