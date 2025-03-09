using course.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace course.Pages.Models
{
    public class AppDataContext: IdentityDbContext<IdentityUser>
    {
     



        public AppDataContext()
        {
        }
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
