using Microsoft.EntityFrameworkCore.Migrations;

namespace Geoprofs_v2.Migrations
{
    public partial class updatewerknemer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Werknemers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Werknemers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Werknemers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Werknemers");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Werknemers");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Werknemers");
        }
    }
}
