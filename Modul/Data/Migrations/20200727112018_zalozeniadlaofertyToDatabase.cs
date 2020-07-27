using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul.Data.Migrations
{
    public partial class zalozeniadlaofertyToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZolozeniaDlaOferty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokazFormularz = table.Column<string>(nullable: false),
                    CzyRolnik = table.Column<string>(nullable: false),
                    ProgPodatkowy = table.Column<int>(nullable: false),
                    Wojewodztwo = table.Column<int>(nullable: false),
                    MiesieczneRachunki = table.Column<int>(nullable: false),
                    ZnajomoscRocznychRachunkowiZuzywanaEnergia = table.Column<string>(nullable: true),
                    ImieiNazwiskoKlienta = table.Column<string>(nullable: false),
                    Paneltechniczny = table.Column<string>(nullable: true),
                    WycenaNaZyczenie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZolozeniaDlaOferty", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZolozeniaDlaOferty");
        }
    }
}
