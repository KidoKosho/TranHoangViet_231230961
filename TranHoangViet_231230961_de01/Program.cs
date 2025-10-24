using Microsoft.EntityFrameworkCore;
using TranHoangViet_231230961_de01.Models;

var builder = WebApplication.CreateBuilder(args);

// ?? �ang k� MVC
builder.Services.AddControllersWithViews();

// ?? �ang k� DbContext (thay th? cho Startup)
builder.Services.AddDbContext<thvComputerText>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ComputerShop")));

var app = builder.Build();

// ?? C?u h�nh pipeline request
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/thvHome/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=thvHome}/{action=thvIndex}/{id?}");

app.Run();
