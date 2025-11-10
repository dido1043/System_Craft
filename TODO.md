# TODO: Prepare SystemCraftAPI for DB Migration

## Steps to Complete

- [x] Update SystemCraftAPI.csproj to include EF Core packages (Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools) and DotNetEnv for .env support.
- [x] Create .env file in SystemCraftAPI/ with SQL Server connection string.
- [x] Create SystemCraftAPI/Model/SystemCraftDbContext.cs with DbSets for all entities (Computer, GraphicsCard, Headphones, Keyboard, Laptop, Monitor, Mouse, Printer, Webcam).
- [x] Update SystemCraftAPI/Program.cs to load .env file and register the DbContext service.
- [x] Run `dotnet ef migrations add InitialCreate` to generate initial migration files.
- [x] Optionally, run `dotnet ef database update` to apply the migration (if database is available).
