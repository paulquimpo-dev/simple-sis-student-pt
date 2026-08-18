# SimpleSIS Student Performance Task

Complete the missing Student CRUD and validation behavior in this scaffolded ASP.NET Core Razor Pages application.

The project infrastructure is already provided. You are not expected to create the project, database schema, `AppDbContext`, packages, or migration from scratch.

## Objective

Use familiar C# and Razor Pages concepts to complete:

1. READ — retrieve and display Students;
2. CREATE — add and save a valid Student;
3. UPDATE — load and save changes to a Student;
4. DELETE — show confirmation and delete only after confirmation; and
5. VALIDATION — reject invalid input and display useful messages.

Your completed operations must persist in PostgreSQL after the application stops and restarts.

## What is provided

- ASP.NET Core Razor Pages project
- `Student` entity and validation attributes
- `AppDbContext`
- EF Core and Npgsql configuration
- pinned packages and repository-local `dotnet-ef` tool
- provided `InitialCreate` migration
- two fictional seed Students
- safe connection-string example
- Student page and form scaffolds
- searchable `TODO-PT-*` markers

Do not modify `Models/Student.cs`, `Data/AppDbContext.cs`, `Program.cs`, `.config/dotnet-tools.json`, or `Migrations/` unless your teacher instructs you to do so.

## Required Student fields

| Field | Rule |
| --- | --- |
| `Id` | Teacher-provided primary key |
| `StudentNumber` | Required |
| `FullName` | Required |
| `GradeLevel` | Whole number from 7 through 12 |
| `Section` | Required |
| `Strand` | Required |

## Setup

Prerequisites: Git, .NET 9 SDK, and the assigned PostgreSQL database.

```powershell
git clone https://github.com/paulquimpo-dev/simple-sis-student-pt.git
cd simple-sis-student-pt
dotnet restore
dotnet tool restore
Copy-Item appsettings.Development.example.json appsettings.Development.json
```

Open `appsettings.Development.json`, replace the placeholders with the local values given by your teacher, and never commit that file.

Apply the provided migration and run the web application:

```powershell
dotnet ef database update
dotnet run
```

Open the localhost URL printed in the terminal. Stop the server with Ctrl+C.

If Git is unavailable, use the teacher-approved ZIP copy, extract it, open its folder in VS Code, and continue at `dotnet restore`.

## Seed records

After database setup, READ should eventually display:

- `2026-001 | Juan Dela Cruz | 12 | St. Paul | ICT`
- `2026-002 | Maria Santos | 12 | St. Paul | ICT`

The records are fictional and created by the provided migration.

## Laboratory pathway

Before the CRUD Performance Task laboratories, complete the separate practice work in [PREREQUISITE_LABS.md](PREREQUISITE_LABS.md):

| Primary target | Recovery window | Preparation laboratory | Required result |
| --- | --- | --- | --- |
| August 20 | Preferably August 24 | Individual Lab 1 — .NET CLI and Project Structure | A console project restores, builds, and runs |
| August 26 | August 27 or next PC block | Individual Lab 2 — First Razor Pages Web App | A local Razor Pages web app runs in the browser |
| September 1 | September 2–3 or next PC block | Guided PT Lab 0 — SimpleSIS Setup | Scaffold, PostgreSQL, migration, and first run succeed |
| September 2 | September 3 or before PT Lab 1 | Individual Lab 3 — Razor Page and PageModel Flow | `OnGet` data appears through Razor output |

The individual labs use separate practice projects. Do not complete `TODO-PT-*` work during them.

All dates are pacing targets. Suspended or online-only PC blocks move to the listed recovery window; students are not required to compensate with home-PC coding.

## Required PT work order

The guided laboratories cumulatively build your final Performance Task. Complete them only after the related lesson has been taught and in this scheduled order:

| Date | Guided PT laboratory | TODO group | Required result |
| --- | --- | --- | --- |
| September 7 | Guided PT Lab 1 — READ Students | `TODO-PT-READ-*` | Seed Students load and display |
| September 8 | Guided PT Lab 2 — CREATE a Student | `TODO-PT-CREATE-*` | Complete form saves a valid Student that persists after restart |
| September 9 | Guided PT Lab 3 — UPDATE a Student | `TODO-PT-UPDATE-*` | Changes persist after restart |
| September 9 | Guided PT Lab 4 — DELETE with Confirmation | `TODO-PT-DELETE-*` | Confirmed deletion persists |
| September 9 | Guided PT Lab 5 — Validation and Feedback | `TODO-PT-VALIDATE-*` | Invalid input is rejected and not saved |
| September 10 | Final PT Completion Lab | All groups | Complete matrix and integration pass |

Completing the individual labs progressively creates your PT. The final PT still requires the Final PT Completion Lab, teacher check, individual demonstration, and submission.

After completing the prerequisite laboratories and confirming that the starter application runs, continue with [GUIDED_LAB.md](GUIDED_LAB.md) for the five scheduled guided PT labs and Final PT Completion Lab.

See [PT_CHECKLIST.md](PT_CHECKLIST.md) for the concise checkpoints, tests, and scoring categories.

## Basic troubleshooting

- **Database connection failure:** confirm PostgreSQL is running and the local values are correct.
- **Password failure:** recheck the assigned local password; do not paste it into source code.
- **`dotnet ef` missing:** run `dotnet tool restore` from the project folder.
- **Restore failure:** confirm the school PC has internet/package access and retry `dotnet restore`.
- **Port already in use:** stop the other running application or use the alternate URL printed by ASP.NET Core.
- **Migration already applied:** this is normally safe; run the application and continue.

## Submission

- Submit the source files requested by your teacher.
- Do not submit database files.
- Do not submit `.git/`, `bin/`, `obj/`, or credential-bearing settings.
- Never commit or share your PostgreSQL password.
- Git knowledge itself is not graded; the provided commands are setup steps.
- Be prepared to demonstrate and explain your own implementation.
