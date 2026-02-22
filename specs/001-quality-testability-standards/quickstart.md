# Quickstart: Quality and Testability Standards

## Prerequisites

- .NET 10 SDK
- Local checkout of repository
- CI pipeline access for quality gate verification

## 1. Build and baseline tests

```bash
dotnet restore
dotnet build -c Release
dotnet test -c Release
```

## 2. Run quality governance checks

```bash
dotnet test tests/FlashyCardMaker.Quality.Tests -c Release
```

Expected outcome:
- Rule catalog loads.
- Rule checks execute for selected scope.
- Report artifact is generated with findings summary.

## 3. Validate external configuration behavior

- Provide alternate configuration inputs for targeted workflows.
- Confirm behavior changes without source modifications.
- Confirm missing required configuration fails fast with actionable errors.

## 4. Validate dependency substitution

- Run unit/integration tests that replace external dependencies with test doubles.
- Confirm deterministic outputs across repeated runs.

## 5. Validate pattern governance

- For each newly introduced non-trivial pattern, create/update pattern justification record.
- Run governance checks and ensure missing justifications are reported.

## 6. CI gate expectations

- Fail pipeline when findings meet fail threshold severity.
- Publish run report artifact and findings list.
- Track trend of high-severity findings over time.