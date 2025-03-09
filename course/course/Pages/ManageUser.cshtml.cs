using course.Pages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace course.Pages
{
    [Authorize(Roles = "AdminManager")]

    public class ManageUser : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageUser(RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public List<IdentityRole> roles { get; set; }

        public List<IdentityUser> users { get; set; }

        [BindProperty(Name = "Id", SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty]
        public string roleName { get; set; }

        [BindProperty(Name = "handler",SupportsGet = true)]
        public string handler { get; set; }

        [BindProperty]

        public string PasswordString { get; set; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            roles= await _roleManager.Roles.ToListAsync();

            users = await _userManager.Users.ToListAsync(); 

            return Page();
        }

        public async Task<IActionResult> OnGetDeleteAsync()
        {
             
            var role = await _roleManager.FindByIdAsync(Id);
         
            var result = await _roleManager.DeleteAsync(role);
            

            
           
            
            return RedirectToPage("/ManageUser");
        }

        public async Task<IActionResult> OnGetDeleteHandlerAsync()
        {
            var user = await _userManager.FindByIdAsync(Id);

            var output = await _userManager.DeleteAsync(user);

            return RedirectToPage("/ManageUser");
        }
    

            public async Task<IActionResult> OnpostAddAsync()
        {
            await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            return RedirectToPage("/ManageUser");
        }

        public async Task<IActionResult> OnpostUpdateAsync()
        {
            var users = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(users);
            await _userManager.AddPasswordAsync(users, PasswordString);
            return RedirectToPage("/ManageUser");
        }
    }
}
