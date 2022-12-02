using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class UpdatedSkiTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips");

            migrationBuilder.RenameColumn(
                name: "SkiierId",
                table: "SkiTrips",
                newName: "Attendees");

            migrationBuilder.AddColumn<string>(
                name: "Housing",
                table: "SkiTrips",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "HousingCost",
                table: "SkiTrips",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "SkiTrips",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skiiers_SkiTrips_SkiTripId",
                table: "Skiiers");

            migrationBuilder.DropIndex(
                name: "IX_Skiiers_SkiTripId",
                table: "Skiiers");

            migrationBuilder.DropColumn(
                name: "Housing",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "HousingCost",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "SkiTripId",
                table: "Skiiers");

            migrationBuilder.RenameColumn(
                name: "Attendees",
                table: "SkiTrips",
                newName: "SkiierId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips",
                column: "SkiierId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips",
                column: "SkiierId",
                principalTable: "Skiiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
