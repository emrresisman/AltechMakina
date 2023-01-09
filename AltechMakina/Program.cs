using AltechMakina;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewLocalization();
builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";

});
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new("tr");

    CultureInfo[] cultures = new CultureInfo[]
    {
        new("tr"),
        new("en"),
        new("fr")
    };
    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});
builder.Services.AddScoped<RequestLocalizationCookiesMiddleware>();
var app = builder.Build();
app.UseRequestLocalization();
app.UseRequestLocalizationCookies();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
