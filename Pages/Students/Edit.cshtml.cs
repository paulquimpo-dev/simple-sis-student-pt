using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSIS.Data;
using SimpleSIS.Models;

namespace SimpleSIS.Pages.Students;

public class EditModel(AppDbContext context) : PageModel
{
    [BindProperty]
    public Student Student { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        _ = context; // The provided context is used when completing the TODO.

        // TODO-PT-UPDATE-01
        // Find the Student with the supplied id. Return NotFound when it does
        // not exist; otherwise place it in the bound Student property.
        return Page();
    }

    public IActionResult OnPost()
    {
        // TODO-PT-UPDATE-02
        // If model validation fails, redisplay the form without saving.

        // TODO-PT-UPDATE-03
        // Find the stored Student by Student.Id, handle a missing record,
        // copy the five editable field values, and save the changes.
        return RedirectToPage("Index");
    }
}
