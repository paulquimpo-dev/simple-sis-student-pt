# SimpleSIS PT Checklist

## Checkpoints

### Prerequisite individual laboratories

- [ ] Individual Lab 1: a console project restores, builds, and runs after its prerequisite lessons.
- [ ] Individual Lab 2: a Razor Pages web app runs through localhost after its prerequisite demonstration.
- [ ] Practice work remains outside the SimpleSIS repository and does not complete PT TODOs early.

### Guided PT Lab 0 — Setup (September 1)

- [ ] Packages restore.
- [ ] Repository-local tools restore.
- [ ] Local PostgreSQL settings are configured safely.
- [ ] The provided migration applies.
- [ ] The starter web application launches.

### Final prerequisite individual laboratory

- [ ] Individual Lab 3: `OnGet` data appears through a PageModel and Razor Page after the Module 4 prerequisites.
- [ ] The practice page remains separate from the SimpleSIS Student TODO files.

### Guided PT Lab 1 — READ Students (September 7)

- [ ] `TODO-PT-READ-01` retrieves Students through `AppDbContext`.
- [ ] `TODO-PT-READ-02` displays Student Number, Full Name, Grade Level, Section, and Strand.
- [ ] Both seed Students display.

### Guided PT Lab 2 — CREATE a Student (September 8–9 target; September 10 recovery)

- [ ] `TODO-PT-CREATE-02` adds and saves a valid Student.
- [ ] `TODO-PT-CREATE-03` provides all five form controls needed to enter a valid Student.
- [ ] The application returns to the list after saving.
- [ ] The created Student remains after restart.

### Guided PT Lab 3 — UPDATE a Student (September 9–10 target; September 14 recovery)

- [ ] `TODO-PT-UPDATE-01` loads the selected Student.
- [ ] `TODO-PT-UPDATE-03` updates the stored fields and saves.
- [ ] The updated values remain after restart.

### Guided PT Lab 4 — DELETE with Confirmation (September 10 target; September 14 recovery)

- [ ] `TODO-PT-DELETE-01` loads the selected Student for confirmation.
- [ ] Opening confirmation does not delete anything.
- [ ] `TODO-PT-DELETE-02` removes and saves only after confirmation POST.
- [ ] The Student remains absent after restart.

### Guided PT Lab 5 — Validation and Feedback (September 10 target; September 14 recovery)

- [ ] `TODO-PT-VALIDATE-02` displays field-level validation messages.
- [ ] `TODO-PT-CREATE-01` prevents an invalid Create form from saving.
- [ ] `TODO-PT-UPDATE-02` prevents invalid Edit changes from saving.
- [ ] Empty Student Number is rejected.
- [ ] Empty Full Name is rejected.
- [ ] Grade Level below 7 or above 12 is rejected.
- [ ] Empty Section is rejected.
- [ ] Empty Strand is rejected.
- [ ] Invalid input is not saved.

## Final PT Completion Lab (September 10 readiness check; September 14 completion/retest)

The five guided labs build the application incrementally. Complete the following integrated matrix before the PT is considered functionally complete.

### Full observable test matrix

- [ ] Application starts.
- [ ] READ displays seed records.
- [ ] CREATE saves a valid Student.
- [ ] Restart: created Student remains.
- [ ] UPDATE saves changes.
- [ ] Restart: changes remain.
- [ ] DELETE requires confirmation.
- [ ] Restart: deleted Student remains absent.
- [ ] Required-field validation works.
- [ ] Invalid Grade Level is rejected.

### Completion and readiness

- [ ] All assigned `TODO-PT-*` areas are complete.
- [ ] The project builds successfully.
- [ ] No real credentials are tracked.
- [ ] Teacher completes the September 10 readiness check or the September 14 final readiness check, as applicable.
- [ ] Repair items are recorded for September 14 when needed.
- [ ] Student is prepared for the September 15–16 individual demonstration.
- [ ] Final source is ready for the September 17 submission.

## Scoring categories

| Category | Points |
| --- | ---: |
| Setup and required structure | 5 |
| READ | 10 |
| CREATE | 15 |
| UPDATE | 15 |
| DELETE | 15 |
| Validation | 10 |
| Razor/C# integration | 10 |
| Testing and reliability | 10 |
| Readability and following the scaffold | 5 |
| Individual explanation | 5 |
| **Total** | **100** |

Teacher-provided infrastructure is not awarded as student-written work.
