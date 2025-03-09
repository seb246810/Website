using course.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using course.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization;


namespace course.Pages
{
    [Authorize(Roles = "AdminManager")]
    public class Enterdata : PageModel
    {

       


        public readonly AppDataContext _db;

        [BindProperty]
        public Product Products { get; set; }


        




        public Enterdata(AppDataContext db) { 

            _db = db;
        
        
        
        }

        
        

        public void OnGet()
        {
        }

        public IActionResult OnPost() {

            // Products = new Product();


            

            _db.Product.Add(Products);

                


            _db.SaveChanges();

            return RedirectToPage("Index");



        }
    }
}
