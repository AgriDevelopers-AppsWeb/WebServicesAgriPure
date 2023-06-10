using Microsoft.EntityFrameworkCore;
using WebServicesAgriPure.AgriPure.Domain.Models;

namespace WebServicesAgriPure.Shared.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Plant>().ToTable("Plants");
            builder.Entity<Plant>().HasKey(p => p.Id);
            builder.Entity<Plant>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Plant>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Plant>().Property(p => p.Image).IsRequired().HasMaxLength(500);
            builder.Entity<Plant>().Property(p => p.Scientifistname).IsRequired().HasMaxLength(100);
            builder.Entity<Plant>().Property(p => p.Variety).IsRequired().HasMaxLength(30);
            builder.Entity<Plant>().Property(p => p.InfolandType).IsRequired().HasMaxLength(500);
            builder.Entity<Plant>().Property(p => p.Ph).IsRequired();
            builder.Entity<Plant>().Property(p => p.InfoDistanceBetween).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.DistancePlants).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.InfoIdealDepth).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.Depth).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.InfoWeatherConditions).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.Weather).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.InfoFertFumig).IsRequired().HasMaxLength(550);
            builder.Entity<Plant>().Property(p => p.IntervaleFert).IsRequired();
            builder.Entity<Plant>().Property(p => p.IntervaleFumig).IsRequired();
            builder.Entity<Plant>().Property(p => p.SavePlant);
        }
    }
}
