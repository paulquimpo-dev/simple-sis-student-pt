using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSIS.Data;
using SimpleSIS.Models;

namespace SimpleSIS.Pages.Students;

public class CreateModel(AppDbContext context) : PageModel
{
    [BindProperty]
    public Student Student { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        _ = context; // The provided context is used when completing the TODO.

        // TODO-PT-CREATE-01
        // If model validation fails, redisplay this page so the student can
        // correct the form. Do not save invalid input.

        // TODO-PT-CREATE-02
        // Add the bound Student to the provided DbContext and save the change.
        // Hint: adding and saving are two separate operations.

        return RedirectToPage("Index");
    }
}
