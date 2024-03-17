using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProekt.Migrations
{
    public partial class _5gh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "People",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Bookings1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bookings1",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Bookings1",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Bookings1",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PeopleCount",
                table: "Bookings1",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "PeopleCount",
                table: "Bookings1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "People",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
