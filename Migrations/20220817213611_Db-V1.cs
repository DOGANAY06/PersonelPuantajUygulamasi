using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonelPuantajUygulamasi.Migrations
{
    public partial class DbV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pazartesi = table.Column<string>(nullable: true),
                    PazartesiId = table.Column<string>(nullable: true),
                    Salı = table.Column<string>(nullable: true),
                    SalıId = table.Column<string>(nullable: true),
                    Carsamba = table.Column<string>(nullable: true),
                    CarsambaId = table.Column<string>(nullable: true),
                    Persembe = table.Column<string>(nullable: true),
                    PersembeId = table.Column<string>(nullable: true),
                    Cuma = table.Column<string>(nullable: true),
                    CumaId = table.Column<string>(nullable: true),
                    Cumartesi = table.Column<string>(nullable: true),
                    CumartesiId = table.Column<string>(nullable: true),
                    Pazar = table.Column<string>(nullable: true),
                    PazarId = table.Column<string>(nullable: true),
                    DepartmanId = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Maas = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vardiyas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vardiyas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Vardiyas");
        }
    }
}
