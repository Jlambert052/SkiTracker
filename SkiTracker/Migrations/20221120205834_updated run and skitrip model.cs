using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class updatedrunandskitripmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RunTotal",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "VerticalTotal",
                table: "SkiTrips",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Vertical",
                table: "Runs",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RunTotal",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "VerticalTotal",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "Vertical",
                table: "Runs");
        }
    }
}
