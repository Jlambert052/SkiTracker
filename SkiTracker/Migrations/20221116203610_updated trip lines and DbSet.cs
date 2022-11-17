using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class updatedtriplinesandDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkiTripLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RunCount = table.Column<int>(type: "int", nullable: false),
                    RunId = table.Column<int>(type: "int", nullable: false),
                    SkiTripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkiTripLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkiTripLines_Runs_RunId",
                        column: x => x.RunId,
                        principalTable: "Runs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkiTripLines_SkiTrips_SkiTripId",
                        column: x => x.SkiTripId,
                        principalTable: "SkiTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripLines_RunId",
                table: "SkiTripLines",
                column: "RunId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiTripLines_SkiTripId",
                table: "SkiTripLines",
                column: "SkiTripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkiTripLines");
        }
    }
}
