# Feature Specification: Entry Progress Tracking

**Feature Branch**: `001-entry-progress-tracking`  
**Created**: 2026-02-21  
**Status**: Draft  
**Input**: User description: "The application must process each source data entry concurrently and show the current process phase for that entry. In addition, for each entry, the application must show the user the progress of long-standing operations, such as uploads, downloads, and conversions, where possible. The application must also show the current processing time for each entry, as well as the total processing time of all entries."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Process Entries Concurrently with Per-Entry Phase Visibility (Priority: P1)

As a user, I want each source entry processed concurrently and shown with its current phase so I can monitor all work items in real time.

**Why this priority**: Concurrency and per-entry phase visibility are the core feature value and directly affect user trust and throughput.

**Independent Test**: Can be tested by running multiple entries and verifying simultaneous processing with distinct phase states per entry.

**Acceptance Scenarios**:

1. **Given** multiple source entries are queued, **When** processing starts, **Then** entries begin processing concurrently according to configured capacity.
2. **Given** an entry transitions through workflow phases, **When** processing continues, **Then** the UI shows the current phase for that specific entry.
3. **Given** one entry fails during a phase, **When** other entries are still running, **Then** failed status is shown for that entry without stopping unrelated entries.

---

### User Story 2 - Show Progress for Long-Running Operations per Entry (Priority: P2)

As a user, I want progress indicators for long operations such as uploads, downloads, and conversions so I understand that work is advancing.

**Why this priority**: Per-operation progress prevents perceived stalls and improves operational transparency.

**Independent Test**: Can be tested by simulating long uploads/downloads/conversions and verifying progress updates for affected entries.

**Acceptance Scenarios**:

1. **Given** an entry is performing a long-running operation with measurable progress, **When** processing is active, **Then** the UI shows incremental progress updates for that entry.
2. **Given** an operation cannot report quantitative progress, **When** it is active, **Then** the UI still shows active in-progress state and current phase for that entry.
3. **Given** an operation completes, **When** phase transitions to the next step, **Then** entry progress indication reflects completion of the prior operation.

---

### User Story 3 - Display Per-Entry and Total Processing Time (Priority: P3)

As a user, I want elapsed time shown for each entry and for the full run so I can estimate completion and compare workload cost.

**Why this priority**: Timing visibility supports performance insight and operational planning.

**Independent Test**: Can be tested by running a batch, checking entry timers during execution, and validating final per-entry and total elapsed times.

**Acceptance Scenarios**:

1. **Given** a batch run is active, **When** entries are processing, **Then** each entry shows its current elapsed processing time.
2. **Given** the batch run is active, **When** processing continues, **Then** the UI shows total elapsed processing time across all entries.
3. **Given** processing completes, **When** results are displayed, **Then** final per-entry and total processing times are preserved in run summary.

---

### Edge Cases

- An entry finishes so quickly that intermediate progress updates are minimal.
- A long-running operation lacks measurable byte or percent progress.
- One entry is retried after failure while others have already completed.
- System clock adjustments occur during processing.
- Large batches cause high update frequency in progress reporting.

## Requirements *(mandatory)*

### Constitutional Requirements (mandatory)

- System MUST be modular: functional modules separated from UI modules, and each module is self-contained, independently testable, and documented.
- Work MUST follow TDD (tests written and failing before implementation; evidence of red-green-refactor required).
- Integration tests MUST cover all module integrations and any I/O to disk or network, including failure paths.
- Logging MUST support levels `none`, `error`, `warning`, `information`, `debug`, and `verbose`, with user-configurable log rotation and location.
- Program code MUST NOT contain secrets; sensitive values MUST come from user input or secure runtime configuration.

### Functional Requirements

- **FR-001**: System MUST process source data entries concurrently rather than strictly sequentially.
- **FR-002**: System MUST track and expose a current processing phase per entry throughout its lifecycle.
- **FR-003**: System MUST update per-entry phase status on every phase transition.
- **FR-004**: System MUST show progress for long-running per-entry operations when measurable progress data is available.
- **FR-005**: System MUST show an active in-progress indicator for long-running operations even when numeric progress is unavailable.
- **FR-006**: System MUST isolate entry failures so unrelated entries continue processing concurrently.
- **FR-007**: System MUST track and display elapsed processing time per entry while processing is active.
- **FR-008**: System MUST track and display total elapsed processing time for the full batch run.
- **FR-009**: System MUST preserve final per-entry and total elapsed processing times in run results.
- **FR-010**: System MUST provide update events at a cadence that keeps progress and timing information meaningfully current for users.
- **FR-011**: System MUST allow additional operation phases to be added without breaking existing phase/progress reporting behavior.

### Key Entities *(include if feature involves data)*

- **Processing Entry**: One source record moving through the processing pipeline.
- **Entry Phase State**: Current lifecycle phase for a processing entry.
- **Operation Progress Snapshot**: Per-entry status update containing operation type, progress state, and optional numeric progress.
- **Entry Timer Record**: Elapsed-time data for a single entry.
- **Batch Timer Record**: Total elapsed-time data for the complete processing run.
- **Run Progress View Model**: Aggregated structure consumed by UI to render per-entry and total progress/timing.

## Assumptions

- Concurrency limits are controlled by runtime configuration or sensible defaults.
- Progress percentages are shown only when underlying operations can provide reliable measurements.
- Timing display uses monotonic elapsed-time measurement to avoid wall-clock drift impact where available.
- UI can subscribe to periodic or event-driven status updates during processing.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: At least 95% of batches with multiple entries show overlapping entry processing windows, confirming concurrent execution.
- **SC-002**: 100% of processed entries expose a visible current phase throughout execution and terminal status at completion.
- **SC-003**: At least 90% of operations that provide measurable progress display user-visible progress updates during execution.
- **SC-004**: 100% of runs display per-entry elapsed time and total elapsed time while active and after completion.
- **SC-005**: User-reported confusion about whether processing is stalled is reduced by at least 40% in pilot feedback.
