using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul.Data.Migrations
{
    public partial class ZalozenieToDatabaseChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CzyNaVat",
                table: "ZolozeniaDlaOferty",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CzyNaVat",
                table: "ZolozeniaDlaOferty");
        }
    }
}
