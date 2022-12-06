using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class testaddskitriptracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skiiers_SkiTrips_SkiTripId",
                table: "Skiiers");

            migrationBuilder.DropIndex(
                name: "IX_Skiiers_SkiTripId",
                table: "Skiiers");

            migrationBuilder.DropColumn(
                name: "SkiTripId",
                table: "Skiiers");

            migrationBuilder.CreateTable(
                name: "SkiTripSkiier",
                columns: table => new
                {
                    SkiiersId = table.Column<int>(type: "int", nullable: false),
                    TripsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkiTripSkiier", x => new { x.SkiiersId, x.TripsId });
                    table.ForeignKey(
                        name: "FK_SkiTripSkiier_Skiiers_SkiiersId",
                        column: x => x.SkiiersId,
                        principalTable: "Skiiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkiTripSkiier_SkiTrips_TripsId",
                        column: x => x.TripsId,
                        principalTable: "SkiTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripSkiier_TripsId",
                table: "SkiTripSkiier",
                column: "TripsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkiTripSkiier");

            migrationBuilder.AddColumn<int>(
                name: "SkiTripId",
                table: "Skiiers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skiiers_SkiTripId",
                table: "Skiiers",
                column: "SkiTripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skiiers_SkiTrips_SkiTripId",
                table: "Skiiers",
                column: "SkiTripId",
                principalTable: "SkiTrips",
                principalColumn: "Id");
        }
    }
}
