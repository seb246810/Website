using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace course.Pages
{
    [Authorize(Roles ="AdminManager,Member")]
    public class Meals : PageModel
    {
        public void OnGet()
        {
        }
    }
}
