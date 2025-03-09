using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace course.Pages 
{ 
    public class Index2Model : PageModel
    {
        [BindProperty]
        [Required]
        public string username { get; set; }



        
        public string Password { get; set; }

        [BindProperty]
        [Required]
        public string Email { get; set; }





        public string Message { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost() {
            ViewData["customessage"] = $"Hello there this is a post,{username},{Email}";

            if (!ModelState.IsValid)
            {
                
                return Page();
            }
            else
            {
                

                return RedirectToPage("Index");
            }







        }

       
    }
}
