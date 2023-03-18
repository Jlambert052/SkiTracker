using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiTracker.Migrations
{
    public partial class defaults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TicketTotal",
                table: "SkiTrips",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "SkiTrips",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "planning",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "RunTotal",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SkiTrips",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "n/a",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Departure",
                table: "SkiTrips",
                type: "date",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Arrival",
                table: "SkiTrips",
                type: "date",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "RunCount",
                table: "SkiTripLines",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RunCountTotal",
                table: "SkiTripAttendees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "PaidAmount",
                table: "SkiTripAttendees",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LodgingCost",
                table: "SkiTripAttendees",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "LodgePaid",
                table: "SkiTripAttendees",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Skiiers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vertical",
                table: "Runs",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Runs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "N/A",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "Runs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<decimal>(
                name: "YearlySnowfall",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TicketCostAvg",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "Snowmaking",
                table: "Resorts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "PassCost",
                table: "Resorts",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OpenTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "9:00",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<bool>(
                name: "NightSki",
                table: "Resorts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "MountainTransportation",
                table: "Resorts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "ExpertsFriendly",
                table: "Resorts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CloseTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "19:00",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<bool>(
                name: "BeginnerFriendly",
                table: "Resorts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Airports",
                table: "Resorts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "LodgingTotal",
                table: "Housings",
                type: "Decimal(7,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)");

            migrationBuilder.AlterColumn<int>(
                name: "GuestMax",
                table: "Housings",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Beds",
                table: "Housings",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bathrooms",
                table: "Housings",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 1m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Housings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Weather",
                table: "Conditions",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "Clear",
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<decimal>(
                name: "TemperatureF",
                table: "Conditions",
                type: "Decimal(5,2)",
                nullable: false,
                defaultValue: 32m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "SnowCondition",
                table: "Conditions",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "Groomed",
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Conditions",
                type: "date",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TicketTotal",
                table: "SkiTrips",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "SkiTrips",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValue: "planning");

            migrationBuilder.AlterColumn<int>(
                name: "RunTotal",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "SkiTrips",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SkiTrips",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldDefaultValue: "n/a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Departure",
                table: "SkiTrips",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Arrival",
                table: "SkiTrips",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<int>(
                name: "RunCount",
                table: "SkiTripLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "RunCountTotal",
                table: "SkiTripAttendees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "PaidAmount",
                table: "SkiTripAttendees",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "LodgingCost",
                table: "SkiTripAttendees",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<bool>(
                name: "LodgePaid",
                table: "SkiTripAttendees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Skiiers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Vertical",
                table: "Runs",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Runs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldDefaultValue: "N/A");

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                table: "Runs",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<decimal>(
                name: "YearlySnowfall",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<decimal>(
                name: "TicketCostAvg",
                table: "Resorts",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<bool>(
                name: "Snowmaking",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PassCost",
                table: "Resorts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "OpenTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldDefaultValue: "9:00");

            migrationBuilder.AlterColumn<bool>(
                name: "NightSki",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MountainTransportation",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ExpertsFriendly",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CloseTime",
                table: "Resorts",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldDefaultValue: "19:00");

            migrationBuilder.AlterColumn<bool>(
                name: "BeginnerFriendly",
                table: "Resorts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Airports",
                table: "Resorts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "LodgingTotal",
                table: "Housings",
                type: "Decimal(7,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(7,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<int>(
                name: "GuestMax",
                table: "Housings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Beds",
                table: "Housings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bathrooms",
                table: "Housings",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 1m);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Housings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Weather",
                table: "Conditions",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldDefaultValue: "Clear");

            migrationBuilder.AlterColumn<decimal>(
                name: "TemperatureF",
                table: "Conditions",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)",
                oldDefaultValue: 32m);

            migrationBuilder.AlterColumn<string>(
                name: "SnowCondition",
                table: "Conditions",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldDefaultValue: "Groomed");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Conditions",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValueSql: "getdate()");
        }
    }
}
