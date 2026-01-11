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
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComputerFavorite> UserComputerFavorites { get; set; }
        public DbSet<UserLaptopFavorite> UserLaptopFavorites { get; set; }
        public DbSet<UserMonitorFavorite> UserMonitorFavorites { get; set; }
        public DbSet<UserHeadphonesFavorite> UserHeadphonesFavorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserComputerFavorite>()
                .HasKey(x => new { x.UserId, x.ComputerId });

            modelBuilder.Entity<UserComputerFavorite>()
                .HasOne(x => x.User)
                .WithMany(u => u.FavoriteComputers)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserComputerFavorite>()
                .HasOne(x => x.Computer)
                .WithMany()
                .HasForeignKey(x => x.ComputerId);

            modelBuilder.Entity<UserLaptopFavorite>()
                .HasKey(x => new { x.UserId, x.LaptopId });

            modelBuilder.Entity<UserLaptopFavorite>()
                .HasOne(x => x.User)
                .WithMany(u => u.FavoriteLaptops)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserLaptopFavorite>()
                .HasOne(x => x.Laptop)
                .WithMany()
                .HasForeignKey(x => x.LaptopId);

            modelBuilder.Entity<UserMonitorFavorite>()
                .HasKey(x => new { x.UserId, x.MonitorId });

            modelBuilder.Entity<UserMonitorFavorite>()
                .HasOne(x => x.User)
                .WithMany(u => u.FavoriteMonitors)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserMonitorFavorite>()
                .HasOne(x => x.Monitor)
                .WithMany()
                .HasForeignKey(x => x.MonitorId);

            modelBuilder.Entity<UserHeadphonesFavorite>()
                .HasKey(x => new { x.UserId, x.HeadphonesId });

            modelBuilder.Entity<UserHeadphonesFavorite>()
                .HasOne(x => x.User)
                .WithMany(u => u.FavoriteHeadphones)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserHeadphonesFavorite>()
                .HasOne(x => x.Headphones)
                .WithMany()
                .HasForeignKey(x => x.HeadphonesId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
