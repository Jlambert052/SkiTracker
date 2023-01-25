using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class modelupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkiTripSkiier");

            migrationBuilder.RenameColumn(
                name: "VerticalTotal",
                table: "SkiTrips",
                newName: "HousingTotal");

            migrationBuilder.RenameColumn(
                name: "HousingCost",
                table: "SkiTrips",
                newName: "HousingCostPerNight");

            migrationBuilder.RenameColumn(
                name: "IntermediateFriendly",
                table: "Resorts",
                newName: "MountainTransportation");

            migrationBuilder.RenameColumn(
                name: "ExpertFriendly",
                table: "Resorts",
                newName: "ExpertsFriendly");

            migrationBuilder.AddColumn<int>(
                name: "SkiierId",
                table: "SkiTrips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketTotal",
                table: "SkiTrips",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SkiierId",
                table: "SkiTripLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Vertical",
                table: "Resorts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Trails",
                table: "Resorts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,0)");

            migrationBuilder.AlterColumn<int>(
                name: "Lifts",
                table: "Resorts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,0)");

            migrationBuilder.AddColumn<string>(
                name: "CloseTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Resorts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OpenTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PassCost",
                table: "Resorts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketCostAvg",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YearlySnowfall",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "SkiTripAttendees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LodgingCost = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "Decimal(7,2)", nullable: false),
                    LodgePaid = table.Column<bool>(type: "bit", nullable: false),
                    RunCountTotal = table.Column<int>(type: "int", nullable: false),
                    SkiierId = table.Column<int>(type: "int", nullable: false),
                    SkiTripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkiTripAttendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkiTripAttendees_Skiiers_SkiierId",
                        column: x => x.SkiierId,
                        principalTable: "Skiiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkiTripAttendees_SkiTrips_SkiTripId",
                        column: x => x.SkiTripId,
                        principalTable: "SkiTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips",
                column: "SkiierId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripLines_SkiierId",
                table: "SkiTripLines",
                column: "SkiierId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripAttendees_SkiierId",
                table: "SkiTripAttendees",
                column: "SkiierId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripAttendees_SkiTripId",
                table: "SkiTripAttendees",
                column: "SkiTripId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTripLines_Skiiers_SkiierId",
                table: "SkiTripLines",
                column: "SkiierId",
                principalTable: "Skiiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips",
                column: "SkiierId",
                principalTable: "Skiiers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiTripLines_Skiiers_SkiierId",
                table: "SkiTripLines");

            migrationBuilder.DropForeignKey(
                name: "FK_SkiTrips_Skiiers_SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropTable(
                name: "SkiTripAttendees");

            migrationBuilder.DropIndex(
                name: "IX_SkiTrips_SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropIndex(
                name: "IX_SkiTripLines_SkiierId",
                table: "SkiTripLines");

            migrationBuilder.DropColumn(
                name: "SkiierId",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "TicketTotal",
                table: "SkiTrips");

            migrationBuilder.DropColumn(
                name: "SkiierId",
                table: "SkiTripLines");

            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "OpenTime",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "PassCost",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "TicketCostAvg",
                table: "Resorts");

            migrationBuilder.DropColumn(
                name: "YearlySnowfall",
                table: "Resorts");

            migrationBuilder.RenameColumn(
                name: "HousingTotal",
                table: "SkiTrips",
                newName: "VerticalTotal");

            migrationBuilder.RenameColumn(
                name: "HousingCostPerNight",
                table: "SkiTrips",
                newName: "HousingCost");

            migrationBuilder.RenameColumn(
                name: "MountainTransportation",
                table: "Resorts",
                newName: "IntermediateFriendly");

            migrationBuilder.RenameColumn(
                name: "ExpertsFriendly",
                table: "Resorts",
                newName: "ExpertFriendly");

            migrationBuilder.AlterColumn<decimal>(
                name: "Vertical",
                table: "Resorts",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Trails",
                table: "Resorts",
                type: "Decimal(7,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lifts",
                table: "Resorts",
                type: "Decimal(7,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripSkiier_TripsId",
                table: "SkiTripSkiier",
                column: "TripsId");
        }
    }
}
