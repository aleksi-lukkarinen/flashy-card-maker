# Data Model: Quality and Testability Standards

## 1. QualityRule

- Purpose: Represents one enforceable governance rule.
- Fields:
  - `RuleId` (string, unique)
  - `Title` (string)
  - `Category` (enum: Maintainability, Testability, Configuration, PatternUsage, Security)
  - `Severity` (enum: Info, Warning, Error)
  - `Description` (string)
  - `DetectionMethod` (string)
  - `RemediationGuidance` (string)
  - `Enabled` (bool)
- Validation:
  - `RuleId` must be unique.
  - `Severity` and `Category` must be valid enum values.

## 2. QualityFinding

- Purpose: Captures one rule violation or observation in a scan.
- Fields:
  - `FindingId` (string, unique)
  - `RuleId` (string, foreign key to QualityRule)
  - `TargetPath` (string)
  - `TargetSymbol` (string, optional)
  - `Severity` (enum)
  - `Message` (string)
  - `Evidence` (string)
  - `DetectedAtUtc` (datetime)
  - `Status` (enum: Open, Waived, Resolved)
- Validation:
  - `RuleId` must exist in rule catalog.
  - `Waived` status requires linked waiver record.

## 3. DependencyContractRecord

- Purpose: Tracks explicit dependency boundary declarations per component.
- Fields:
  - `ComponentId` (string)
  - `DeclaredDependencies` (list)
  - `SubstitutableDependencies` (list)
  - `ContractVersion` (string)
- Validation:
  - Component must declare at least one boundary type.

## 4. ConfigurationItemRecord

- Purpose: Defines externally configurable runtime value.
- Fields:
  - `ConfigKey` (string, unique)
  - `ValueType` (string)
  - `Required` (bool)
  - `DefaultAllowed` (bool)
  - `Sensitivity` (enum: Public, Internal, Secret)
  - `ValidationRules` (list)
- Validation:
  - Keys must be unique.
  - Secret values must never be emitted in clear text.

## 5. PatternJustificationRecord

- Purpose: Documents why a design pattern is used.
- Fields:
  - `RecordId` (string, unique)
  - `PatternName` (string)
  - `ProblemStatement` (string)
  - `ChosenApproach` (string)
  - `AlternativesConsidered` (list)
  - `DecisionDate` (date)
  - `Approver` (string)
- Validation:
  - Must include at least one alternative.
  - Problem statement cannot be empty.

## 6. QualityRunReport

- Purpose: Aggregated result of a governance check run.
- Fields:
  - `RunId` (string, unique)
  - `Scope` (string)
  - `StartedAtUtc` (datetime)
  - `CompletedAtUtc` (datetime)
  - `Findings` (list of QualityFinding)
  - `Summary` (counts by severity/status)
  - `Result` (enum: Pass, Fail)
- State transitions:
  - `Created` -> `Running` -> (`Pass` | `Fail`)