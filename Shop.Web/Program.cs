using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Context;
using Shop.Web.Data.Daos;
using Shop.Web.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ShopDbContext>(options =>
                                          options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb")));

builder.Services.AddTransient<IEmployees, DaoEmployees>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
