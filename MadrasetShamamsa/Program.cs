using MadrasetShamamsa.Services;
using MadrasetShamamsa.Interfaces;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICopticDateService, CopticDateService>();

// Configure Arabic as default culture
var supportedCultures = new[] { new CultureInfo("ar-EG") };
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("ar-EG");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    // Clear all culture providers to force Arabic
    options.RequestCultureProviders.Clear();
});

var app = builder.Build();

// Use Request Localization (IMPORTANT: Add this before other middleware)
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("ar-EG"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();