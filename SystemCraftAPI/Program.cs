using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SystemCraftAPI.Model;
using SystemCraftAPI.Service;
var builder = WebApplication.CreateBuilder(args);

Env.TraversePath().Load();
builder.Configuration.AddEnvironmentVariables();

// Register all concrete service classes in the assembly that end with "Service"
foreach (var t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
{
    if (t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service"))
    {
        builder.Services.AddScoped(t);
    }
}
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SystemCraftDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SystemCraft API",
        Version = "v1",
        Description = "API surface for SystemCraft resources and user favorites."
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
