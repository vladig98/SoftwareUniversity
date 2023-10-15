using Eventures.Data;
using Eventures.DbModels;
using Eventures.Middleware;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("EventuresContextConnection") ??
        throw new InvalidOperationException("Connection string 'EventuresContextConnection' not found.");

builder.Services.AddDbContext<EventuresDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<EventuresDbContext>().AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequiredUniqueChars = 0;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(9999999);
    options.Lockout.MaxFailedAccessAttempts = 999999;
    options.Lockout.AllowedForNewUsers = false;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

//builder.Services.AddScoped<EventuresDbContext, EventuresDbContext>();
//builder.Services.AddScoped<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();
//builder.Services.AddScoped<UserManager<User>, UserManager<User>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();
app.UseDataSeeder();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
