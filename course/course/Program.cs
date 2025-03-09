using course.Pages.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using course.Data;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;



var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("courseContextConnection") ?? throw new InvalidOperationException("Connection string 'courseContextConnection' not found.");






var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDataContext>(options =>
    options.UseSqlite(Configuration.GetConnectionString("default")));


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<AppDataContext>()
               .AddDefaultUI()
               .AddDefaultTokenProviders();

builder.Services.AddScoped<UserManager<IdentityUser>>();












builder.Services.AddRazorPages();




var app = builder.Build();





if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();


app.Run();
