using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace course.Pages
{
    [Authorize(Roles = "AdminManager,Member")]
    
    public class Events : PageModel
    {
        public void OnGet()
        {
        }
    }
}
