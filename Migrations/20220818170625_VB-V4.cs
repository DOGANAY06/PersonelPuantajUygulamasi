using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelPuantajUygulamasi.Migrations
{
    public partial class VBV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarsambaId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "CumaId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "CumartesiId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "PazarId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "PazartesiId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "PersembeId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "SalıId",
                table: "Personels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarsambaId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CumaId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CumartesiId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PazarId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PazartesiId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersembeId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalıId",
                table: "Personels",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
