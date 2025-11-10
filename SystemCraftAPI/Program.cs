using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using SystemCraftAPI.Model;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SystemCraftDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SystemCraftDb")));

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
