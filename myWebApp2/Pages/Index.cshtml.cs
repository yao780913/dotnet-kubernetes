using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myWebApp2.Data;

namespace myWebApp2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly SchoolContext _context;

    public IndexModel (ILogger<IndexModel> logger, SchoolContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public string StudentName { get; set; } = "PageModel in C#";

    public void OnGet ()
    {
        var student = _context.Students.FirstOrDefault(d => d.Id == 1);
        if (student != null)
            this.StudentName = $"{student.FirstName} {student.LastName}";
    }

    
}