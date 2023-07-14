using FluentValidation.AspNetCore;
using Hamburger_Application.Data;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Validations;
using Hamburger_Application.Repositories.Abstract;
using Hamburger_Application.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(Program).Assembly);


builder.Services.AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssemblyContaining<Program>();
    x.DisableDataAnnotationsValidation = true;
});

var connectionString = builder.Configuration.GetConnectionString("ConnStr");
builder.Services.AddDbContext<HamburgerDbContext>(options =>
    options.UseSqlServer(connectionString));

//var connectionString = builder.Configuration.GetConnectionString("ConStr");
//builder.Services.AddDbContext<HamburgerDbContext>(options =>
//	options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<AppRole>()
    .AddEntityFrameworkStores<HamburgerDbContext>().AddErrorDescriber<CustomIdentityValidator>();

// login olan kullanýcý bir dk mouse klavye hareket yoksa sistemden atýlýr
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "Identity";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(1);
    options.SlidingExpiration = true;

    options.LoginPath = "/Home/Index"; // default u degistirme
});

//builder.Services.Configure<IdentityOptions>(options =>
//{
//    // password customize
//    options.Password.RequiredLength = 8;
//    options.User.RequireUniqueEmail = true;
//    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
//});

builder.Services.AddRazorPages();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Main}/{id?}");

app.MapRazorPages();

app.Run();
