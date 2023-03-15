﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkiTracker.Models;

#nullable disable

namespace SkiTracker.Migrations
{
    [DbContext(typeof(SkiTrackerDbContext))]
    partial class SkiTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SkiTracker.Models.Condition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("ResortId")
                        .HasColumnType("int");

                    b.Property<string>("SnowCondition")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<decimal>("TemperatureF")
                        .HasColumnType("Decimal(5,2)");

                    b.Property<string>("Weather")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("id");

                    b.HasIndex("ResortId");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("SkiTracker.Models.Housing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bathrooms")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Beds")
                        .HasColumnType("int");

                    b.Property<int>("GuestMax")
                        .HasColumnType("int");

                    b.Property<string>("Lodging")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("LodgingCostPerNight")
                        .HasColumnType("Decimal(7,2)");

                    b.Property<decimal>("LodgingTotal")
                        .HasColumnType("Decimal(7,2)");

                    b.Property<int>("MilesToMountain")
                        .HasColumnType("int");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<int>("ResortId")
                        .HasColumnType("int");

                    b.Property<bool>("SkiOut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ResortId");

                    b.ToTable("Housings");
                });

            modelBuilder.Entity("SkiTracker.Models.Resort", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Airports")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("BeginnerFriendly")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("CloseTime")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Epic")
                        .HasColumnType("bit");

                    b.Property<bool>("ExpertsFriendly")
                        .HasColumnType("bit");

                    b.Property<bool>("Ikon")
                        .HasColumnType("bit");

                    b.Property<int>("Lifts")
                        .HasColumnType("int");

                    b.Property<bool>("MountainTransportation")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<bool>("NightSki")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OpenTime")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PassCost")
                        .HasColumnType("int");

                    b.Property<bool>("Snowmaking")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<decimal>("TicketCostAvg")
                        .HasColumnType("Decimal(5,2)");

                    b.Property<int>("Trails")
                        .HasColumnType("int");

                    b.Property<int>("Vertical")
                        .HasColumnType("int");

                    b.Property<decimal>("YearlySnowfall")
                        .HasColumnType("Decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("SkiTracker.Models.Run", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ResortId")
                        .HasColumnType("int");

                    b.Property<decimal>("Vertical")
                        .HasColumnType("Decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("ResortId");

                    b.ToTable("Runs");
                });

            modelBuilder.Entity("SkiTracker.Models.Skiier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("SnowSport")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Skiiers");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("date");

                    b.Property<int>("Attendees")
                        .HasColumnType("int");

                    b.Property<DateTime>("Departure")
                        .HasColumnType("date");

                    b.Property<int>("HousingId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ResortId")
                        .HasColumnType("int");

                    b.Property<int>("RunTotal")
                        .HasColumnType("int");

                    b.Property<int?>("SkiierId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("TicketTotal")
                        .HasColumnType("Decimal(5,2)");

                    b.Property<string>("TripName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("HousingId");

                    b.HasIndex("ResortId");

                    b.HasIndex("SkiierId");

                    b.ToTable("SkiTrips");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTripAttendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("LodgePaid")
                        .HasColumnType("bit");

                    b.Property<decimal>("LodgingCost")
                        .HasColumnType("Decimal(7,2)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("Decimal(7,2)");

                    b.Property<int>("RunCountTotal")
                        .HasColumnType("int");

                    b.Property<int>("SkiTripId")
                        .HasColumnType("int");

                    b.Property<int>("SkiierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkiTripId");

                    b.HasIndex("SkiierId");

                    b.ToTable("SkiTripAttendees");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTripLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RunCount")
                        .HasColumnType("int");

                    b.Property<int>("RunId")
                        .HasColumnType("int");

                    b.Property<int>("SkiTripId")
                        .HasColumnType("int");

                    b.Property<int>("SkiierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RunId");

                    b.HasIndex("SkiTripId");

                    b.HasIndex("SkiierId");

                    b.ToTable("SkiTripLines");
                });

            modelBuilder.Entity("SkiTracker.Models.Condition", b =>
                {
                    b.HasOne("SkiTracker.Models.Resort", "Resort")
                        .WithMany()
                        .HasForeignKey("ResortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("SkiTracker.Models.Housing", b =>
                {
                    b.HasOne("SkiTracker.Models.Resort", "Resort")
                        .WithMany()
                        .HasForeignKey("ResortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("SkiTracker.Models.Run", b =>
                {
                    b.HasOne("SkiTracker.Models.Resort", "Resort")
                        .WithMany()
                        .HasForeignKey("ResortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTrip", b =>
                {
                    b.HasOne("SkiTracker.Models.Housing", "Housing")
                        .WithMany()
                        .HasForeignKey("HousingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkiTracker.Models.Resort", "Resort")
                        .WithMany()
                        .HasForeignKey("ResortId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkiTracker.Models.Skiier", null)
                        .WithMany("Trips")
                        .HasForeignKey("SkiierId");

                    b.Navigation("Housing");

                    b.Navigation("Resort");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTripAttendee", b =>
                {
                    b.HasOne("SkiTracker.Models.SkiTrip", "SkiTrip")
                        .WithMany("Skiiers")
                        .HasForeignKey("SkiTripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkiTracker.Models.Skiier", "Skiier")
                        .WithMany()
                        .HasForeignKey("SkiierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkiTrip");

                    b.Navigation("Skiier");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTripLine", b =>
                {
                    b.HasOne("SkiTracker.Models.Run", "Run")
                        .WithMany()
                        .HasForeignKey("RunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkiTracker.Models.SkiTrip", "SkiTrip")
                        .WithMany("SkiTripLines")
                        .HasForeignKey("SkiTripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkiTracker.Models.Skiier", "Skiier")
                        .WithMany()
                        .HasForeignKey("SkiierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Run");

                    b.Navigation("SkiTrip");

                    b.Navigation("Skiier");
                });

            modelBuilder.Entity("SkiTracker.Models.Skiier", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("SkiTracker.Models.SkiTrip", b =>
                {
                    b.Navigation("SkiTripLines");

                    b.Navigation("Skiiers");
                });
#pragma warning restore 612, 618
        }
    }
}
