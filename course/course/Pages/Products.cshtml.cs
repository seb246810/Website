using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Xml.Linq;

namespace course.Pages
{
    
    using System.ComponentModel;
    using System.Diagnostics.Metrics;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    using course.Models;
    using course.Pages.Models;
    using Microsoft.AspNetCore.Authorization;
    using System.Data;

    public class ProductsModel : PageModel
    {

        public readonly AppDataContext _db;

        public List<Product> Products { get; set; }

       

        public ProductsModel(AppDataContext db)
        {
            _db = db;
        }



        public void OnGet()
        {

            Products = _db.Product.ToList();



        }

       
        public IActionResult OnGetDelete(int Id)
        {
            if (!User.IsInRole("AdminManager"))
            {
               return RedirectToPage("/Index");
            }

            _db.Remove(_db.Product.Find(Id));

            _db.SaveChanges();

            return RedirectToPage("/Index");
        }





    }
    }




