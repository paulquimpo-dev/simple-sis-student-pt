using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleSIS.Data;
using SimpleSIS.Models;

namespace SimpleSIS.Pages.Students;

public class IndexModel(AppDbContext context) : PageModel
{
    public List<Student> Students { get; private set; } = [];

    public void OnGet()
    {
        _ = context; // The provided context is used when completing the TODO.

        // TODO-PT-READ-01
        // Retrieve the Students from the provided DbContext and place them
        // in the Students property so the Razor Page can display them.
        // Hint: the context already exposes a Students collection.
    }
}
