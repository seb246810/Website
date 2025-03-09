using course.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using course.Models;
using Microsoft.AspNetCore.Authorization;

namespace course.Pages
{
    [Authorize(Roles = "AdminManager")]
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Product Products { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public readonly AppDataContext _db;

        public UpdateModel(AppDataContext db)
        {
            _db = db;
        }


        public void OnGet()
        {
            Products = _db.Product.Find(Id);
        }

        public IActionResult Onpost()
        {
            _db.Product.Update(Products);
            _db.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
