# Guided Lab: Complete the SimpleSIS Student CRUD Application

**Platform:** ASP.NET Core Razor Pages  
**Language:** C#  
**Database:** PostgreSQL through Entity Framework Core and Npgsql  
**Suggested time:** 3–5 focused laboratory blocks  
**Difficulty:** Guided, with independent challenge checkpoints

## Lab overview

You have received a working web application scaffold with its database infrastructure already prepared. Your task is to complete selected Student CRUD and validation sections without rebuilding the entire project from scratch.

This guide begins after the prerequisite individual laboratories and repository setup are complete. See [PREREQUISITE_LABS.md](PREREQUISITE_LABS.md) for the August 20, August 26, September 1, and September 2 readiness sequence.

You will work through the PT implementation in this order:

```text
READ → CREATE → UPDATE → DELETE → Validation → Final Testing
```

Each stage contains:

- a goal;
- files to inspect;
- concepts to recall;
- guided steps;
- hints that do not provide the final code;
- a checkpoint you must demonstrate; and
- a challenge that requires your own reasoning.

> Do not skip directly to later stages. UPDATE and DELETE are easier to test after READ and CREATE work correctly.

## Before starting this guided lab

Complete the prerequisite labs, cloning, PostgreSQL configuration, provided migration, and first-run instructions linked from [README.md](README.md).

Begin Stage 1 only when:

- `dotnet restore` succeeds;
- `dotnet tool restore` succeeds;
- `dotnet ef database update` succeeds;
- `dotnet run` starts the web application; and
- the Home and Students pages open in your browser.

If one of these setup checks fails, return to the README troubleshooting section or ask your teacher for setup assistance. Repository setup is a guided prerequisite; this lab focuses on the Student CRUD and validation work you must complete.

## What you will learn

By completing this lab, you should be able to:

- explain how a Razor Page and its PageModel work together;
- retrieve database records through a provided `DbContext`;
- display a collection with Razor syntax;
- bind form values to a C# object;
- use `ModelState` to prevent invalid data from being saved;
- add, update, and remove records through EF Core;
- explain why `SaveChanges` is required;
- use GET to display pages and POST to change data; and
- prove that PostgreSQL data persists after an application restart.

## Rules of the lab

1. Complete only the assigned `TODO-PT-*` areas unless your teacher approves another change.
2. Do not modify the migration, database context, package versions, or Student entity.
3. Do not place your PostgreSQL password in source code.
4. Test after every checkpoint.
5. Be ready to explain every line you add.
6. A working feature without an explanation may not receive full credit.

---

# Guided PT Lab 1 — READ Students

**Scheduled block:** Monday, September 7, 2026, after the Razor collections and `foreach` lesson

**Checkpoint target:** Seed Students load from PostgreSQL and all required columns display

## Goal

Retrieve all Students through the provided EF Core context and display their five required visible fields in the Razor table.

## TODOs

- `TODO-PT-READ-01`
- `TODO-PT-READ-02`

## Files

```text
Pages/Students/Index.cshtml.cs
Pages/Students/Index.cshtml
```

## Concept review

The PageModel prepares data in C#. The Razor Page displays that prepared data as HTML.

```text
OnGet executes
    ↓
PageModel retrieves Students
    ↓
Students property receives the collection
    ↓
Razor loops through the collection
    ↓
Browser receives an HTML table
```

## Task 1A: Retrieve Students

Open `Pages/Students/Index.cshtml.cs` and locate `TODO-PT-READ-01`.

Your `OnGet` handler must:

1. access the provided context's Student collection;
2. retrieve the records as a list; and
3. assign that list to the PageModel's `Students` property.

### Hint

Look at the declared property type and the EF Core method names discussed in class. The required method turns the database-backed collection into a `List<Student>`.

### Do not

- create a second `AppDbContext`;
- hard-code Juan and Maria in the PageModel;
- read from a JSON file; or
- replace PostgreSQL with an in-memory list.

## Task 1B: Display the fields

Open `Pages/Students/Index.cshtml` and locate `TODO-PT-READ-02`.

The `foreach` loop and current `student` variable are already provided. Inside each row, display one table cell for each field:

1. Student Number
2. Full Name
3. Grade Level
4. Section
5. Strand

### Hint

Use Razor output syntax to display a property from the current loop item. Follow the existing table headers in the same order.

## Checkpoint 1

Run the application and open **Students**.

- [ ] Juan Dela Cruz appears.
- [ ] Maria Santos appears.
- [ ] All five visible fields appear under the correct headers.
- [ ] Edit and Delete buttons still appear on each row.
- [ ] The HTML table remains readable.

### Challenge 1

Explain why retrieving data belongs in `Index.cshtml.cs` while displaying `<td>` elements belongs in `Index.cshtml`. What problem would occur if the database query were placed directly in the markup?

### Commit suggestion

If your teacher uses Git checkpoints:

```powershell
git add Pages/Students/Index.cshtml Pages/Students/Index.cshtml.cs
git commit -m "Complete Student READ checkpoint"
```

---

# Guided PT Lab 2 — CREATE a Student

**Scheduled block:** Tuesday, September 8, 2026, after forms, GET/POST, model binding, and `asp-for`

**Checkpoint target:** A valid Student saves and remains after application restart

## Goal

Accept a valid bound Student, reject invalid input, save the valid record through EF Core, and return to the list.

## TODOs

- `TODO-PT-CREATE-01`
- `TODO-PT-CREATE-02`
- `TODO-PT-CREATE-03`

## File

```text
Pages/Students/Create.cshtml.cs
```

## Concept review

The provided `[BindProperty]` connects submitted form values to the PageModel's `Student` property.

The required decision is:

```text
POST received
    ↓
Is the model valid?
    ├── No → show the same page and messages
    └── Yes → add → save → redirect to list
```

## Task 2A: Stop invalid submissions

Locate `TODO-PT-CREATE-01`.

Before adding anything to the database:

1. check whether `ModelState` is valid;
2. when it is invalid, return the current Razor Page; and
3. do not continue to the add/save statements.

### Hint

This requires an `if` condition. Think carefully about whether you return when the model **is valid** or when it **is not valid**.

## Task 2B: Save a valid Student

Locate `TODO-PT-CREATE-02`.

For a valid Student:

1. tell the provided context to track the new Student as an added record;
2. persist the pending change; and
3. allow the existing redirect to return to the list.

### Hint

Adding to the context and saving the database change are two separate operations. If you perform only the first operation, the record will not persist after restart.

## Task 2C: Complete the Create/Edit form controls

Open `Pages/Students/_StudentForm.cshtml` and locate `TODO-PT-CREATE-03`.

StudentNumber is provided as an example. Following the same Bootstrap and Razor Tag Helper pattern, add model-aware label and input groups for:

- FullName
- GradeLevel
- Section
- Strand

The partial is shared by Create and Edit. Completing these controls now makes the valid CREATE checkpoint possible and prepares the form for later UPDATE and validation work.

## Checkpoint 2

Use a clearly fictional test record:

```text
Student Number: 2026-TEST
Full Name: Test Student
Grade Level: 12
Section: Test Section
Strand: ICT
```

- [ ] The valid form returns to the Student list.
- [ ] `2026-TEST` appears in the list.
- [ ] No server error appears.
- [ ] Stop the app with Ctrl+C.
- [ ] Run `dotnet run` again.
- [ ] `2026-TEST` still appears.

The restart check is required evidence of PostgreSQL persistence.

### Challenge 2

Temporarily reason through—not necessarily modify—what would happen if `SaveChanges` were removed. Would the list display the Student before redirect? Would it remain after restart? Explain your prediction using EF Core's role.

---

# Guided PT Lab 3 — UPDATE a Student

**Scheduled block:** Wednesday, September 9, 2026, after UPDATE and persistence concepts

**Checkpoint target:** Existing values load, valid changes save, and changes remain after restart

## Goal

Load an existing Student into the Edit form, reject invalid changes, copy permitted fields to the stored entity, and persist the update.

## TODOs

- `TODO-PT-UPDATE-01`
- `TODO-PT-UPDATE-02`
- `TODO-PT-UPDATE-03`

## File

```text
Pages/Students/Edit.cshtml.cs
```

## Concept review

UPDATE has two separate requests:

```text
GET /Students/Edit/{id}
    → find the Student
    → show current values

POST /Students/Edit/{id}
    → validate submitted values
    → find the stored Student
    → copy allowed changes
    → save
```

## Task 3A: Load the selected Student

Locate `TODO-PT-UPDATE-01` inside `OnGet`.

Your handler must:

1. use the provided `id` to find the Student;
2. return `NotFound()` if no matching record exists;
3. place the found record in the bound `Student` property; and
4. return the page.

### Hint

The provided context has a method intended to find an entity by its primary key. The result may be `null`, so handle that case before assigning it.

## Task 3B: Reject invalid changes

Locate `TODO-PT-UPDATE-02`.

Use the same validation decision as CREATE. Invalid submitted values must redisplay the Edit page without reaching database update logic.

## Task 3C: Persist permitted changes

Locate `TODO-PT-UPDATE-03`.

Your handler must:

1. find the stored Student using the submitted `Student.Id`;
2. return `NotFound()` if the record no longer exists;
3. copy StudentNumber, FullName, GradeLevel, Section, and Strand from the bound form object to the stored object;
4. save the context; and
5. allow the existing redirect to return to the list.

### Why copy fields?

Copying the approved fields makes it clear which values the application allows the form to change. Do not replace this beginner-level pattern with AutoMapper, a repository, or another abstraction.

## Checkpoint 3

Edit `2026-TEST`:

```text
Section: Updated Section
```

- [ ] The Edit page initially displays the existing values.
- [ ] Saving returns to the list.
- [ ] The list displays `Updated Section`.
- [ ] Restart the application.
- [ ] `Updated Section` remains.

### Challenge 3

Why does UPDATE need to find the stored Student again during POST instead of assuming that the browser contains a trusted database object? Discuss what the browser actually sends.

---

# Guided PT Lab 4 — DELETE with Confirmation

**Scheduled block:** Wednesday, September 9, 2026, after DELETE confirmation is taught

**Checkpoint target:** GET displays confirmation only; confirmed POST deletion persists

## Goal

Display the selected Student without deleting it during GET, then remove and save only after an explicit POST confirmation.

## TODOs

- `TODO-PT-DELETE-01`
- `TODO-PT-DELETE-02`

## File

```text
Pages/Students/Delete.cshtml.cs
```

## Concept review

```text
GET Delete page
    → retrieve and display only

POST Delete page
    → retrieve → remove → save
```

Opening a link should not silently destroy data.

## Task 4A: Display confirmation safely

Locate `TODO-PT-DELETE-01` inside `OnGet`.

Your handler must:

1. find the selected Student using `id`;
2. return `NotFound()` when it does not exist;
3. assign it to the bound `Student` property; and
4. return the page without removing or saving anything.

## Task 4B: Delete after confirmation

Locate `TODO-PT-DELETE-02` inside `OnPost`.

Your handler must:

1. find the stored Student using `Student.Id`;
2. return `NotFound()` when it does not exist;
3. mark the found entity for removal;
4. save the context; and
5. allow the existing redirect to return to the list.

### Hint

The sequence is similar to CREATE, but the context operation represents removal instead of addition.

## Checkpoint 4

- [ ] Open Delete for `2026-TEST`.
- [ ] The confirmation page displays the correct Student.
- [ ] Return to the list without confirming; the Student still exists.
- [ ] Open Delete again and confirm.
- [ ] The Student disappears.
- [ ] Restart the application.
- [ ] The Student remains absent.

### Challenge 4

Explain why deletion belongs in `OnPost` rather than `OnGet`. Include one example of how accidental deletion could occur if simply visiting a URL deleted data.

---

# Guided PT Lab 5 — Validation and Feedback

**Scheduled block:** Wednesday, September 9, 2026, after validation and `ModelState` are taught

**Checkpoint target:** Invalid input is rejected with useful feedback and is not saved

## Goal

Verify the shared form controls, show useful field-level messages, and prove that invalid input is not saved.

## TODO

- `TODO-PT-VALIDATE-02`

## File

```text
Pages/Students/_StudentForm.cshtml
```

This partial is shared by Create and Edit. A correction here affects both pages.

## Task 5A: Display validation feedback

Add:

1. a model-only validation summary near the top of the partial; and
2. a field-level validation message beside every input, including StudentNumber.

Use the provided `text-danger` styling so errors are visible.

The five controls were completed in Guided PT Lab 2 under `TODO-PT-CREATE-03`. Confirm that each one is still bound to the correct property before testing its message.

### Important connection

The validation attributes already exist in `Models/Student.cs`. Your job is to make the handlers honor validation and make the Razor form display the resulting messages.

## Checkpoint 5

Submit a form using:

```text
Student Number: blank
Full Name: blank
Grade Level: 13
Section: blank
Strand: blank
```

- [ ] Student Number required message appears.
- [ ] Full Name required message appears.
- [ ] Grade Level range message appears.
- [ ] Section required message appears.
- [ ] Strand required message appears.
- [ ] The application remains on the form.
- [ ] No invalid Student appears in the list.
- [ ] A valid Student can still be saved afterward.

### Challenge 5

Inspect `Models/Student.cs`. Explain the different responsibilities of:

- validation attributes in the model;
- the `ModelState` check in the PageModel; and
- `asp-validation-for` in the Razor Page.

---

# Final PT Completion Lab — Integration and persistence testing

**Scheduled block:** Thursday, September 10, 2026

**Purpose:** Combine the five passed lab checkpoints into the complete PT, run the formal test matrix, repair integration failures, and prepare the application for teacher checking

## Goal

Prove that the completed features work together and that PostgreSQL—not temporary memory—stores the records.

This is not a new-feature laboratory. Finish incomplete earlier TODOs first, then use this block for integration, testing, cleanup, and explanation readiness.

## Clean test sequence

Use a new fictional record and record your observed result for every item.

### READ

- [ ] Both seed Students display.
- [ ] All required fields display correctly.

### CREATE and restart

- [ ] Create a valid Student.
- [ ] Confirm it appears.
- [ ] Stop and restart the application.
- [ ] Confirm it remains.

### UPDATE and restart

- [ ] Edit that Student.
- [ ] Confirm the changed value appears.
- [ ] Stop and restart the application.
- [ ] Confirm the change remains.

### DELETE and restart

- [ ] Open confirmation and cancel or return; the Student remains.
- [ ] Confirm deletion.
- [ ] Stop and restart the application.
- [ ] Confirm the Student remains absent.

### Validation

- [ ] Empty StudentNumber is rejected.
- [ ] Empty FullName is rejected.
- [ ] GradeLevel below 7 is rejected.
- [ ] GradeLevel above 12 is rejected.
- [ ] Empty Section is rejected.
- [ ] Empty Strand is rejected.
- [ ] Invalid input is not persisted.

## Final challenge — Explain the complete request

Choose either CREATE or UPDATE and explain the full journey:

```text
Browser form
    → HTTP POST
    → model binding
    → validation / ModelState
    → PageModel handler
    → AppDbContext
    → EF Core
    → Npgsql
    → PostgreSQL
    → redirect
    → refreshed Student list
```

Your explanation should identify what data moves between layers and which layer is responsible for storing it permanently.

## Final PT completion checkpoint

- [ ] Every `TODO-PT-*` marker assigned as student work is resolved.
- [ ] `dotnet build` succeeds.
- [ ] The complete observable matrix passes.
- [ ] CREATE, UPDATE, and DELETE persistence are each verified after restart.
- [ ] No real credentials appear in tracked files.
- [ ] The source remains within the assigned scaffold and scope.
- [ ] The student can explain one selected handler and the complete persistence flow.
- [ ] The teacher records the September 10 first formal PT check.

Passing the individual guided labs builds the PT, but the PT is not considered ready until this final integration checkpoint passes.

## After the completion lab

- **Friday, September 11:** online quiz and PT concept review; no required coding.
- **Monday, September 14:** remediation, repair list, and clean retest.
- **Tuesday–Wednesday, September 15–16:** individual demonstrations and final repair.
- **Thursday, September 17:** final source submission before the announced deadline.

---

# Optional extension challenges

Complete these only after the required matrix passes and only with teacher approval. They must not replace the required work.

## Extension A: Empty-list experience

Explain what the Index page displays when there are no Students. Identify the existing Razor condition responsible for that behavior.

## Extension B: Missing record behavior

Test or reason about an Edit/Delete URL containing an ID that does not exist. Explain why returning HTTP 404 is better than displaying a blank form.

## Extension C: Code-reading comparison

Create a small comparison table in your notes showing how CREATE, UPDATE, and DELETE differ in:

- how they locate data;
- which EF Core context operation they use; and
- when they call `SaveChanges`.

Do not add unrelated features such as authentication, grades, subjects, dashboards, APIs, or repository/service layers.

---

# Troubleshooting guide

## The application does not build

1. Read the first compiler error, not only the last one.
2. Confirm braces, parentheses, and semicolons are balanced.
3. Confirm property names match the provided `Student` model exactly.
4. Use `dotnet build` after correcting one group of errors.

## The application builds but seed Students do not appear

Check:

- Was `TODO-PT-READ-01` completed?
- Is the retrieved list assigned to the PageModel property?
- Was `TODO-PT-READ-02` completed inside the existing loop?
- Did `dotnet ef database update` finish successfully?

## CREATE redirects but nothing appears

Check whether you both added the Student and saved the context. These are separate operations.

## Edit displays blank values

Check whether `OnGet` assigns the found database entity to the PageModel's bound `Student` property.

## Changes disappear after restart

The change may not have reached PostgreSQL. Check for the required `SaveChanges` operation in the correct POST handler.

## Validation messages do not appear

Check all three layers:

1. validation attributes exist in `Models/Student.cs`;
2. invalid `ModelState` returns the current page; and
3. the Razor partial contains the correct validation Tag Helpers.

## Database login fails

- Confirm PostgreSQL is running.
- Confirm the database, username, and password match the teacher-assigned local values.
- Confirm the connection string is in ignored `appsettings.Development.json`.
- Do not send your password in chat, screenshots, or source files.

---

# Submission readiness

Before submitting or demonstrating:

- [ ] All required TODOs are complete.
- [ ] `dotnet build` succeeds.
- [ ] The full test matrix passes.
- [ ] Restart persistence is demonstrated.
- [ ] No password appears in tracked files.
- [ ] Your code remains within the assigned scaffold.
- [ ] You can explain READ, CREATE, UPDATE, DELETE, and validation.
- [ ] You reviewed [PT_CHECKLIST.md](PT_CHECKLIST.md).

The goal is not only to make the application work. The goal is to understand and explain how your Razor Pages code works with EF Core and PostgreSQL.
