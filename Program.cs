using Microsoft.EntityFrameworkCore;
using CountryList.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string stringConnection = builder.Configuration.GetConnectionString("CountryContext");
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});

builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WorldCountryContext>(settings => settings.UseSqlServer(stringConnection));


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
app.UseSession();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "",
        pattern: "{controller}/{action}/page{pagenumber}/continent/{continent}/sort-by-{sortfield}/direction/{sortdirection}"
    );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.Run();
