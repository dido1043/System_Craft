using Microsoft.EntityFrameworkCore;
using SystemCraftAPI.Model.Entities;
using MonitorEntity = SystemCraftAPI.Model.Entities.Monitor;

namespace SystemCraftAPI.Model
{
    public class SystemCraftDbContext : DbContext
    {
        public SystemCraftDbContext(DbContextOptions<SystemCraftDbContext> options) : base(options) { }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<Headphones> Headphones { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<MonitorEntity> Monitors { get; set; }
        public DbSet<Mouse> Mice { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Webcam> Webcams { get; set; }
    }
}
