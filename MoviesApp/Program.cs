using MoviesApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MoviesAppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MoviesConnectionString") ?? throw new InvalidOperationException("Connection string 'MoviesConnectionString' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Profiles}/{action=Index}/{id?}");


app.Run();
