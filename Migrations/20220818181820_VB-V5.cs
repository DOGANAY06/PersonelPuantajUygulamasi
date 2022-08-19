using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelPuantajUygulamasi.Migrations
{
    public partial class VBV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salı",
                table: "Personels");

            migrationBuilder.AddColumn<string>(
                name: "Sali",
                table: "Personels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sali",
                table: "Personels");

            migrationBuilder.AddColumn<string>(
                name: "Salı",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
