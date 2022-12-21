using Microsoft.EntityFrameworkCore.Migrations;

namespace Geoprofs_v2.Migrations
{
    public partial class addwerknemer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Werknemers",
                columns: table => new
                {
                    werknemer_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werknemers", x => x.werknemer_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Werknemers");
        }
    }
}
