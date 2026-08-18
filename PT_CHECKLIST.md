# SimpleSIS PT Checklist

## Checkpoints

### Setup

- [ ] Packages restore.
- [ ] Repository-local tools restore.
- [ ] Local PostgreSQL settings are configured safely.
- [ ] The provided migration applies.
- [ ] The starter web application launches.

### READ

- [ ] `TODO-PT-READ-01` retrieves Students through `AppDbContext`.
- [ ] `TODO-PT-READ-02` displays Student Number, Full Name, Grade Level, Section, and Strand.
- [ ] Both seed Students display.

### CREATE

- [ ] `TODO-PT-CREATE-01` prevents an invalid form from saving.
- [ ] `TODO-PT-CREATE-02` adds and saves a valid Student.
- [ ] The application returns to the list after saving.
- [ ] The created Student remains after restart.

### UPDATE

- [ ] `TODO-PT-UPDATE-01` loads the selected Student.
- [ ] `TODO-PT-UPDATE-02` prevents invalid changes from saving.
- [ ] `TODO-PT-UPDATE-03` updates the stored fields and saves.
- [ ] The updated values remain after restart.

### DELETE

- [ ] `TODO-PT-DELETE-01` loads the selected Student for confirmation.
- [ ] Opening confirmation does not delete anything.
- [ ] `TODO-PT-DELETE-02` removes and saves only after confirmation POST.
- [ ] The Student remains absent after restart.

### Validation

- [ ] `TODO-PT-VALIDATE-01` provides the required form controls.
- [ ] `TODO-PT-VALIDATE-02` displays field-level validation messages.
- [ ] Empty Student Number is rejected.
- [ ] Empty Full Name is rejected.
- [ ] Grade Level below 7 or above 12 is rejected.
- [ ] Empty Section is rejected.
- [ ] Empty Strand is rejected.
- [ ] Invalid input is not saved.

## Full observable test matrix

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
