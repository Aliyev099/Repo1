using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProekt.Migrations
{
    public partial class _56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_rezervasiya",
                table: "rezervasiya");

            migrationBuilder.RenameTable(
                name: "rezervasiya",
                newName: "Reservation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "rezervasiya");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rezervasiya",
                table: "rezervasiya",
                column: "Id");
        }
    }
}
