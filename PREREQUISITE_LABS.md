# SimpleSIS Prerequisite Individual Laboratories

These short individual laboratories prepare you for the SimpleSIS Performance Task. They use separate practice folders and do not complete any `TODO-PT-*` work early.

Complete each laboratory only after its related lesson and keep the practice project separate from the `simple-sis-student-pt` folder.

## Target and recovery schedule

| Primary target | Recovery window | Laboratory | Readiness gate |
| --- | --- | --- | --- |
| August 20 | Next available in-person PC block, preferably August 24 | Individual Lab 1 — .NET CLI and Project Structure | Lessons 1.1–1.4 and CLI demonstration complete |
| August 26 | August 27 or next available in-person PC block | Individual Lab 2 — First Razor Pages Web App | ASP.NET Core, localhost, and request/response demonstration complete |
| September 1 | September 2–3 or next available in-person PC block | Guided PT Lab 0 — SimpleSIS Setup | School PCs, repository access, and PostgreSQL available |
| September 2 | September 3 or before Guided PT Lab 1 | Individual Lab 3 — Razor Page and PageModel Flow | PageModel, `OnGet`, properties, and `@Model` taught |

These are pacing targets, not automatic deadlines. If a class is suspended or a readiness gate is not met, use the recovery window. Do not complete a PC-dependent laboratory at home unless the teacher explicitly provides an equitable alternative.

---

# Individual Lab 1 — .NET CLI and Project Structure

**Primary target:** Thursday, August 20, 2026

**Recovery window:** Next available in-person PC block, preferably Monday, August 24
**Work mode:** Individual, teacher-guided start  
**Product:** A separate console practice project

## Goal

Use the .NET CLI correctly and distinguish source, configuration, and generated project files.

## Tasks

1. Create a practice folder outside the SimpleSIS repository.
2. Create a console project with `dotnet new console`.
3. Run `dotnet restore`, `dotnet build`, and `dotnet run` separately.
4. Change the output in `Program.cs`, rebuild, and run it again.
5. Locate `Program.cs`, the `.csproj` file, `bin`, and `obj`.
6. Record one sentence explaining the purpose of each command and each located item.

## Checkpoint

- [ ] The project builds without errors.
- [ ] The changed output appears when the project runs.
- [ ] The student can explain the difference between `build` and `run`.
- [ ] The student identifies source/configuration files and generated folders correctly.

## Challenge

Introduce a small syntax error, observe which command reports it, repair it, and explain why the program could not run normally.

## Evidence

Show the running console output, project tree, and brief written command/file explanations. Submit only if directed by the teacher.

---

# Individual Lab 2 — First Razor Pages Web App

**Primary target:** Wednesday, August 26, 2026

**Recovery window:** Thursday, August 27, or the next available in-person PC block
**Work mode:** Individual after teacher demonstration  
**Product:** A separate Razor Pages practice project

## Goal

Create and run an ASP.NET Core Razor Pages web application and connect the browser, localhost URL, server, request, and response.

## Tasks

1. Create a separate Razor Pages project with `dotnet new webapp`.
2. Restore and run the project.
3. Open the exact localhost URL printed by the terminal.
4. Identify the port number and explain why the site is a web application rather than a desktop application.
5. Locate `Program.cs`, `Pages`, `wwwroot`, and the `.csproj` file.
6. Make one teacher-approved visible text change on the Home page and rerun the project.
7. Stop the server correctly with Ctrl+C.

## Checkpoint

- [ ] The browser displays the local Razor Pages application.
- [ ] The terminal remains responsible for the running server.
- [ ] The visible text change appears after rerunning.
- [ ] The student can trace: browser request → ASP.NET Core → HTML response.

## Challenge

Explain what happens in the browser when the server is stopped and why the `.exe` or running process does not make this a desktop application.

## Evidence

Show the running page, terminal URL, changed page text, and project folders. Do not submit `bin` or `obj`.

---

# Guided PT Lab 0 — SimpleSIS Setup

**Primary target:** Tuesday, September 1, 2026

**Recovery window:** September 2–3, or the next available in-person PC block
**Work mode:** Teacher-guided environment setup  
**Product:** A working local copy of the provided student scaffold

Follow the Setup section of [README.md](README.md). The teacher checks repository access, package/tool restore, safe local PostgreSQL configuration, the provided migration, and the first successful web run.

This is an environment-readiness checkpoint. Credential or workstation problems are corrected during class and are not treated as programming failures.

---

# Individual Lab 3 — Razor Page and PageModel Flow

**Primary target:** Wednesday, September 2, 2026

**Recovery window:** September 3, or before Guided PT Lab 1 begins
**Work mode:** Individual after the Module 4 lesson  
**Product:** A separate non-PT Razor practice page

## Goal

Use a PageModel property and `OnGet` to provide a value that a `.cshtml` page renders as HTML.

## Tasks

1. Use the separate Razor Pages practice project from Individual Lab 2.
2. Add a teacher-named practice Razor Page; do not edit SimpleSIS Student TODO files.
3. Declare a string property in its PageModel.
4. Assign a course-related value inside `OnGet`.
5. Display the value from the `.cshtml` file with `@Model`.
6. Run the app and open the page directly.
7. Draw or write the flow from browser request to PageModel to Razor output.

## Checkpoint

- [ ] The practice page opens without an unhandled error.
- [ ] The value assigned in `OnGet` appears in the browser.
- [ ] The student can identify what belongs in `.cshtml` and `.cshtml.cs`.
- [ ] The student explains that the browser receives HTML rather than executing server-side C#.

## Challenge

Add a second property of a different simple C# type and display it with a clear label without copying a completed Student-list solution.

## Evidence

Show the working practice page, both paired files, and the written request/PageModel/Razor flow. Submit only if directed by the teacher.

---

## Transition to the Performance Task

After the prerequisite checkpoints are complete, return to [GUIDED_LAB.md](GUIDED_LAB.md). The formal cumulative implementation targets Guided PT Lab 1 — READ Students on September 7. If suspensions delay a prerequisite, the teacher moves the affected PT checkpoint instead of skipping the prerequisite.

The prerequisite laboratories demonstrate readiness. They are not three additional SIS applications and must not receive duplicate credit for later PT behavior.
