using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProekt.Migrations
{
    public partial class th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "People",
                table: "Bookings1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "People",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Bookings1");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Bookings1");
        }
    }
}
