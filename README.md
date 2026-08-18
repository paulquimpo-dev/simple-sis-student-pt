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

## Required work order

Complete the searchable TODOs in this order:

1. `TODO-PT-READ-*`
2. `TODO-PT-CREATE-*`
3. `TODO-PT-UPDATE-*`
4. `TODO-PT-DELETE-*`
5. `TODO-PT-VALIDATE-*`
6. Full testing

After completing all setup steps above and confirming that the starter application runs, continue with [GUIDED_LAB.md](GUIDED_LAB.md) to complete READ, CREATE, UPDATE, DELETE, validation, and final testing.

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
