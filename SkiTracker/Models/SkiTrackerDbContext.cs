using Microsoft.EntityFrameworkCore;

namespace SkiTracker.Models {

    public class SkiTrackerDbContext : DbContext{

        public DbSet<Resort> Resorts { get; set; }

        public DbSet<Skiier> Skiiers { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<SkiTrip> SkiTrips { get; set; }

        public DbSet<SkiTripLine> SkiTripLines {  get; set; }

        public DbSet<SkiTripAttendee> SkiTripAttendees { get; set; }

        public DbSet<Housing> Housings { get; set; }

        public SkiTrackerDbContext(DbContextOptions<SkiTrackerDbContext> options) : base(options) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder) {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
