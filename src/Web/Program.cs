using Microsoft.EntityFrameworkCore;
using Spokesoft.Clobberfest.Common.Extensions.Configuration;
using Spokesoft.Clobberfest.Common.Extensions.Logging;
using Spokesoft.Clobberfest.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddConfiguration();
builder.AddLogging();

builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Clobberfest")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
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

app.MapAreaControllerRoute(
    name: "heroes-default",
    areaName: "Heroes",
    pattern: "heroes/{controller}/{action}/{id?}",
    defaults: new { action = "Index" }
);

app.MapAreaControllerRoute(
    name: "play-default",
    areaName: "Play",
    pattern: "play/{controller}/{action}/{id?}",
    defaults: new { action = "Index" }
);

app.Run();
