using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class Updatedcolumnnamesandfixedannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trip",
                table: "SkiTrips");

            migrationBuilder.RenameColumn(
                name: "Intermediate",
                table: "Resorts",
                newName: "IntermediateFriendly");

            migrationBuilder.RenameColumn(
                name: "Expert",
                table: "Resorts",
                newName: "ExpertFriendly");

            migrationBuilder.RenameColumn(
                name: "Beginner",
                table: "Resorts",
                newName: "BeginnerFriendly");

            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "Conditions",
                newName: "TemperatureF");

            migrationBuilder.RenameColumn(
                name: "SnowCon",
                table: "Conditions",
                newName: "SnowCondition");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SkiTrips",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TripName",
                table: "SkiTrips",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Trails",
                table: "Resorts",
                type: "Decimal(7,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lifts",
                table: "Resorts",
                type: "Decimal(7,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTrips_ResortId",
                table: "SkiTrips",
                column: "ResortId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips",
                column: "SkiierId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTrips_Resorts_ResortId",
                table: "SkiTrips",
                column: "ResortId",
                principalTable: "Resorts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips",
                column: "SkiierId",
                principalTable: "Skiiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiTrips_Resorts_ResortId",
                table: "SkiTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropIndex(
                name: "IX_SkiTrips_ResortId",
                table: "SkiTrips");

            migrationBuilder.DropIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "TripName",
                table: "SkiTrips");

            migrationBuilder.RenameColumn(
                name: "IntermediateFriendly",
                table: "Resorts",
                newName: "Intermediate");

            migrationBuilder.RenameColumn(
                name: "ExpertFriendly",
                table: "Resorts",
                newName: "Expert");

            migrationBuilder.RenameColumn(
                name: "BeginnerFriendly",
                table: "Resorts",
                newName: "Beginner");

            migrationBuilder.RenameColumn(
                name: "TemperatureF",
                table: "Conditions",
                newName: "Temperature");

            migrationBuilder.RenameColumn(
                name: "SnowCondition",
                table: "Conditions",
                newName: "SnowCon");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SkiTrips",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Trip",
                table: "SkiTrips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Trails",
                table: "Resorts",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lifts",
                table: "Resorts",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,0)");
        }
    }
}
