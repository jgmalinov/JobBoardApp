using JobBoardApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<JobBoardContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteConnString")));
}
else if (builder.Environment.IsProduction())
{
    builder.Services.AddDbContext<JobBoardContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnString")));
}

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
