using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using RentSys.Data;
using Microsoft.AspNetCore.Identity;
using RentSys.Models.UserManagement;

var builder = WebApplication.CreateBuilder(args);

// Connect to the database

builder.Services.AddDbContext<RentSysContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RentSysConnect") ?? throw new InvalidOperationException("Connection string 'AspnetCoreMvcFullContext' not found.")));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
  // Configure identity options here
})
.AddEntityFrameworkStores<RentSysContext>()
.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
  options.LoginPath = "/Auth/LoginBasic"; // Redirect to your custom AuthController's Login action
  options.AccessDeniedPath = "/Auth/AccessDenied"; // Redirect to your custom AuthController's AccessDenied action
  options.LogoutPath = "/Auth/Logout"; // Redirect to your custom AuthController's Logout action
});

// Add authentication services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboards}/{action=Index}/{id?}"); // <-- Update in AspnetCoreMvcStarter

app.Run();
