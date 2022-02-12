using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_WEBAPI.Migrations
{
    public partial class createInitial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "SuperHeroes");
        }
    }
}
