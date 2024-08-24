using Microsoft.EntityFrameworkCore;
using Spokesoft.Clobberfest.Common.Extensions.Configuration;
using Spokesoft.Clobberfest.Common.Extensions.Logging;
using Spokesoft.Clobberfest.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfiguration();
builder.AddLogging();

builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Clobberfest")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/blog/articles", async (BlogDbContext context) =>
{
    return new {
        Articles = await context.Articles.ToListAsync(),
        TotalCount = await context.Articles.CountAsync()
    };
});

app.Run();

