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
        //default values for each model

        //Resort Defaults
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Resort>()
                .Property(x => x.TicketCostAvg).HasDefaultValue(1);
            modelBuilder.Entity<Resort>()
                .Property(x => x.PassCost).HasDefaultValue(1);
            modelBuilder.Entity<Resort>()
                .Property(x => x.PassCost).HasDefaultValue(1);
            modelBuilder.Entity<Resort>()
                .Property(x => x.YearlySnowfall).HasDefaultValue(1);
            modelBuilder.Entity<Resort>()
                .Property(x => x.Acreage).HasDefaultValue(1);
            modelBuilder.Entity<Resort>()
                .Property(x => x.OpenTime).HasDefaultValue("9:00");
            modelBuilder.Entity<Resort>()
                .Property(x => x.CloseTime).HasDefaultValue("19:00");
            modelBuilder.Entity<Resort>()
                .Property(x => x.Airports).HasDefaultValue("");

            //SkTrip Defaults
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.Arrival).HasDefaultValueSql<DateOnly>("getdate()");
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.Departure).HasDefaultValueSql<DateOnly>("getdate()");
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.Status).HasDefaultValue("planning");
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.TicketTotal).HasDefaultValue(1);
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.Notes).HasDefaultValue("n/a");
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.Rating).HasDefaultValue(1);
            modelBuilder.Entity<SkiTrip>()
                .Property(x => x.RunTotal).HasDefaultValue(0);

            //SkiTripAttendeeDefaults
            modelBuilder.Entity<SkiTripAttendee>()
                .Property(x => x.LodgingCost).HasDefaultValue(1);
            modelBuilder.Entity<SkiTripAttendee>()
                .Property(x => x.PaidAmount).HasDefaultValue(0);
            modelBuilder.Entity<SkiTripAttendee>()
                .Property(x => x.LodgePaid).HasDefaultValue(false);
            modelBuilder.Entity<SkiTripAttendee>()
                .Property(x => x.RunCountTotal).HasDefaultValue(0);
            //Run Defaults

            modelBuilder.Entity<Run>()
                .Property(x => x.Vertical).HasDefaultValue(1);
            modelBuilder.Entity<Run>()
                .Property(x => x.Features).HasDefaultValue("None");
            modelBuilder.Entity<Run>()
                .Property(x => x.Notes).HasDefaultValue("N/A");
            //SkiTripLine Defaults
            modelBuilder.Entity<SkiTripLine>()
                .Property(x => x.RunCount).HasDefaultValue(1);
            //Housing Defaults
            modelBuilder.Entity<Housing>()
                .Property(x => x.LodgingTotal).HasDefaultValue(1);
            modelBuilder.Entity<Housing>()
                .Property(x => x.Address).HasDefaultValue("");
            modelBuilder.Entity<Housing>()
                .Property(x => x.GuestMax).HasDefaultValue(1);
            modelBuilder.Entity<Housing>()
                .Property(x => x.Beds).HasDefaultValue(1);
            modelBuilder.Entity<Housing>()
                .Property(x => x.Bathrooms).HasDefaultValue(1);
            //Condition Defaults
            modelBuilder.Entity<Condition>()
                .Property(x => x.TemperatureF).HasDefaultValue(32);
            modelBuilder.Entity<Condition>()
                .Property(x => x.Weather).HasDefaultValue("Clear");
            modelBuilder.Entity<Condition>()
                .Property(x => x.SnowCondition).HasDefaultValue("Groomed");
            modelBuilder.Entity<Condition>()
                .Property(x => x.Date).HasDefaultValueSql("getdate()");
        }
    }
}
