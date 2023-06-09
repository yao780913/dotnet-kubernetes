using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myWebApp.Pages;

public class ExitModel : PageModel
{
    public ExitModel ()
    {
        Environment.Exit(0);
    }
    
    public void OnGet ()
    {
        
    }
}