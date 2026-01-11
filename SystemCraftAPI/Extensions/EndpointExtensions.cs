using Microsoft.EntityFrameworkCore;
using SystemCraftAPI.Model;

namespace SystemCraftAPI.Extensions
{
    public static class EndpointExtensions
    {
        public static void MapCrudEndpoints<TEntity>(this WebApplication app, string route)
            where TEntity : class
        {
            var group = app.MapGroup(route);

            group.MapGet("/", async (SystemCraftDbContext db) => await db.Set<TEntity>().ToListAsync());

            group.MapGet("/{id:int}", async (int id, SystemCraftDbContext db) =>
            {
                var entity = await db.Set<TEntity>().FindAsync(id);
                return entity is null ? Results.NotFound() : Results.Ok(entity);
            });

            group.MapPost("/", async (TEntity entity, SystemCraftDbContext db) =>
            {
                db.Set<TEntity>().Add(entity);
                await db.SaveChangesAsync();
                return Results.Created($"{route}", entity);
            });

            group.MapPut("/{id:int}", async (int id, TEntity entity, SystemCraftDbContext db) =>
            {
                var existing = await db.Set<TEntity>().FindAsync(id);
                if (existing is null) return Results.NotFound();

                db.Entry(existing).CurrentValues.SetValues(entity);
                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            group.MapDelete("/{id:int}", async (int id, SystemCraftDbContext db) =>
            {
                var existing = await db.Set<TEntity>().FindAsync(id);
                if (existing is null) return Results.NotFound();

                db.Set<TEntity>().Remove(existing);
                await db.SaveChangesAsync();
                return Results.NoContent();
            });
        }
    }
}
