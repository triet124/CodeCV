using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Data;

var builder = WebApplication.CreateBuilder(args);

//Duong dan ket noi CSDL
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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
app.UseSession();
app.MapAreaControllerRoute(
    name: "AdminRoute",
    areaName: "Admin",
    pattern: "Admin/{controller=Cars}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "UserRoute",
    areaName: "User",
    pattern: "User/{controller=User}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
