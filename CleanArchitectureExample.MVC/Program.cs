using CleanArchitecture.Infra.Data.Context;
using CleanArchitecture.Infra.IoC;
using CleanArchitectureExample.MVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


var StoreconnectionString = builder.Configuration.GetConnectionString("StoreConnection");
builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer(StoreconnectionString));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.RegisterServices(); // this is for config services writen in dependancy container 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

// we should create a extension method to call this fuction. In dot net core 6 we have only program.cs. therfore all startup will execute with program.cs 
public static class ServiceExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        DependancyContainer.RegisterServices(services);
    }
}
