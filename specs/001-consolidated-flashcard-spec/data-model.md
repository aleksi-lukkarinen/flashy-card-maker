# Data Model: Consolidated Flashcard Workflow

## 1. GenerationRun

- Purpose: Root aggregate for one user-triggered run.
- Fields:
  - `RunId` (string, required)
  - `RequestedAtUtc` (datetime, required)
  - `Locale` (string, required)
  - `ConfigurationSnapshotId` (string, required)
  - `Status` (enum: `Pending`, `Running`, `Completed`, `PartialSuccess`, `Failed`, `Cancelled`)
  - `StartedAtUtc` (datetime, optional)
  - `CompletedAtUtc` (datetime, optional)
- Validation Rules:
  - Locale must be supported or fall back to default locale.
  - Status transitions must follow defined lifecycle.
- State Transitions:
  - `Pending` -> `Running` -> (`Completed` | `PartialSuccess` | `Failed` | `Cancelled`)

## 2. GenerationRecord

- Purpose: Normalized per-item processing unit.
- Fields:
  - `RecordId` (string, required)
  - `SourceLanguage` (string, required)
  - `SourceText` (string, required)
  - `TargetValues` (collection of target-language translations)
  - `AudioArtifacts` (collection of audio references)
  - `ItemStatus` (enum: `Pending`, `Succeeded`, `Failed`, `Skipped`)
- Validation Rules:
  - Source text cannot be empty after normalization.
  - Target language values must map to configured language assignments.

## 3. LanguagePairAssignment

- Purpose: Connects source/target language pair with service assignments.
- Fields:
  - `SourceLanguage` (string, required)
  - `TargetLanguage` (string, required)
  - `TranslationProviderId` (string, conditional)
  - `AudioProviderId` (string, conditional)
  - `VoiceId` (string, optional)
- Validation Rules:
  - Translation provider required when translation is enabled.
  - Audio provider required when audio generation is enabled.

## 4. ProviderConfiguration

- Purpose: Holds validated provider settings and sensitive references.
- Fields:
  - `ProviderId` (string, required)
  - `ProviderType` (enum: `Translation`, `VoiceDiscovery`, `Audio`)
  - `Settings` (dictionary, required)
  - `IsValid` (bool)
  - `ValidationErrors` (collection)
- Validation Rules:
  - Required settings must be present before request dispatch.
  - Sensitive values must be tagged for redaction.

## 5. EffectiveConfigurationSnapshot

- Purpose: Final merged runtime settings with source attribution.
- Fields:
  - `SnapshotId` (string, required)
  - `ResolvedValues` (dictionary, required)
  - `ValueOrigins` (dictionary key -> source metadata)
  - `CreatedAtUtc` (datetime, required)
- Validation Rules:
  - Conflicting values resolved by deterministic precedence.
  - Required keys must resolve before run start.

## 6. JobStateRecord

- Purpose: Tracks per-item execution, retries, and terminal outcomes.
- Fields:
  - `JobId` (string, required)
  - `RecordId` (string, required)
  - `AttemptCount` (integer, required)
  - `MaxRetries` (integer, required)
  - `TerminalStatus` (enum: `Succeeded`, `Failed`, `RetryExhausted`, `SkippedOnResume`, `Aborted`)
  - `LastErrorCode` (string, optional)
- Validation Rules:
  - Attempt count cannot exceed max retries plus initial attempt.
  - Terminal status required once job exits running state.

## 7. OutputArtifact

- Purpose: Represents emitted run outputs (CSV, audio files, others).
- Fields:
  - `ArtifactId` (string, required)
  - `ArtifactType` (enum: `Csv`, `Audio`, `Other`)
  - `FormatKey` (string, required)
  - `Path` (string, required)
  - `Language` (string, optional)
  - `IsFinalized` (bool, required)
- Validation Rules:
  - Path must resolve to allowed output destination.
  - Finalized artifacts must not be recreated on resume.

## 8. RunSummary

- Purpose: Aggregates run-level outcomes for users and diagnostics.
- Fields:
  - `RunId` (string, required)
  - `TotalItems` (integer, required)
  - `SucceededItems` (integer, required)
  - `FailedItems` (integer, required)
  - `SkippedItems` (integer, required)
  - `DurationMs` (integer, required)
  - `StatusBreakdown` (dictionary, required)
  - `Messages` (collection)
- Validation Rules:
  - Outcome counts must reconcile with total items.
  - Status categories must be explicit and non-overlapping.
