using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProekt.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TittlesName",
                table: "Tittles",
                newName: "tittlesname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tittlesname",
                table: "Tittles",
                newName: "TittlesName");
        }
    }
}
