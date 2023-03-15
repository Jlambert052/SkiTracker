using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class housing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Housing",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "HousingCostPerNight",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "HousingTotal",
                table: "SkiTrips");

            migrationBuilder.AddColumn<int>(
                name: "HousingId",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Airports",
                table: "Resorts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Epic",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ikon",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Housings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lodging = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LodgingCostPerNight = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    LodgingTotal = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuestMax = table.Column<int>(type: "int", nullable: false),
                    Beds = table.Column<int>(type: "int", nullable: false),
                    Bathrooms = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SkiOut = table.Column<bool>(type: "bit", nullable: false),
                    MilesToMountain = table.Column<int>(type: "int", nullable: false),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    ResortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Housings_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiTrips_HousingId",
                table: "SkiTrips",
                column: "HousingId");

            migrationBuilder.CreateIndex(
                name: "IX_Housings_ResortId",
                table: "Housings",
                column: "ResortId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTrips_Housings_HousingId",
                table: "SkiTrips",
                column: "HousingId",
                principalTable: "Housings",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiTrips_Housings_HousingId",
                table: "SkiTrips");

            migrationBuilder.DropTable(
                name: "Housings");

            migrationBuilder.DropIndex(
                name: "IX_SkiTrips_HousingId",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "HousingId",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "Airports",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "Epic",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "Ikon",
                table: "Resorts");

            migrationBuilder.AddColumn<string>(
                name: "Housing",
                table: "SkiTrips",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "HousingCostPerNight",
                table: "SkiTrips",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HousingTotal",
                table: "SkiTrips",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
