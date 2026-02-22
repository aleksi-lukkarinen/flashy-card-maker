# Quickstart: Audio Filename Format

## Prerequisites

- .NET 10 SDK
- Repository checkout

## 1. Build and baseline tests

`ash
dotnet restore
dotnet build -c Release
dotnet test -c Release
`

## 2. Run feature-specific validation tests

`ash
dotnet test -c Release --filter "001-audio-filename-format"
`

## 3. Execute feature workflow

- Provide required inputs/configuration per spec.md.
- Run workflow through the designated interface/entrypoint.
- Verify outputs and logs match success criteria.

## 4. Validate failure paths

- Execute with invalid inputs and unavailable dependencies.
- Confirm deterministic error messages and preserved outputs where applicable.
