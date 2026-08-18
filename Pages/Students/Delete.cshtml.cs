using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSIS.Data;
using SimpleSIS.Models;

namespace SimpleSIS.Pages.Students;

public class DeleteModel(AppDbContext context) : PageModel
{
    [BindProperty]
    public Student Student { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        _ = context; // The provided context is used when completing the TODO.

        // TODO-PT-DELETE-01
        // Find the selected Student, return NotFound when it does not exist,
        // and display it for confirmation. Do not delete during GET.
        return Page();
    }

    public IActionResult OnPost()
    {
        // TODO-PT-DELETE-02
        // Find the confirmed Student by Student.Id, handle a missing record,
        // remove it from the DbContext, and save the change.

        return RedirectToPage("Index");
    }
}
