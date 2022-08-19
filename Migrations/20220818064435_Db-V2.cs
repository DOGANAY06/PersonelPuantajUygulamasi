using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelPuantajUygulamasi.Migrations
{
    public partial class DbV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "Personels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iban",
                table: "Personels");
        }
    }
}
