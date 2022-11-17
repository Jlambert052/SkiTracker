using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class InitModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    City = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Lifts = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    Vertical = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    Trails = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    Beginner = table.Column<bool>(type: "bit", nullable: false),
                    Intermediate = table.Column<bool>(type: "bit", nullable: false),
                    Expert = table.Column<bool>(type: "bit", nullable: false),
                    NightSki = table.Column<bool>(type: "bit", nullable: false),
                    Snowmaking = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skiiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    SnowSport = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skiiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkiTrips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Arrival = table.Column<DateTime>(type: "date", nullable: false),
                    Departure = table.Column<DateTime>(type: "date", nullable: false),
                    ResortId = table.Column<int>(type: "int", nullable: false),
                    SkiierId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkiTrips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Temperature = table.Column<decimal>(type: "Decimal(5,2)", nullable: false),
                    Weather = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    SnowCon = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ResortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Conditions_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Features = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ResortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Runs_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_ResortId",
                table: "Conditions",
                column: "ResortId");

            migrationBuilder.CreateIndex(
                name: "IX_Runs_ResortId",
                table: "Runs",
                column: "ResortId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Runs");

            migrationBuilder.DropTable(
                name: "Skiiers");

            migrationBuilder.DropTable(
                name: "SkiTrips");

            migrationBuilder.DropTable(
                name: "Resorts");
        }
    }
}
