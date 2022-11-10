using Microsoft.EntityFrameworkCore;

namespace SkiTracker.Models {

    public class SkiTrackerDbContext : DbContext{

        public DbSet<Resort> Resorts { get; set; }

        public DbSet<Skiier> Skiiers { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<SkiTrip> SkiTrips { get; set; }

        public SkiTrackerDbContext(DbContextOptions<SkiTrackerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
