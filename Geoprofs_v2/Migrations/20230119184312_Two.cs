using Microsoft.EntityFrameworkCore.Migrations;

namespace Geoprofs_v2.Migrations
{
    public partial class Two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Department_departmentId",
                table: "Werknemers");

            migrationBuilder.DropForeignKey(
                name: "FK_Werknemers_Role_roleId",
                table: "Werknemers");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Werknemers_departmentId",
                table: "Werknemers");

            migrationBuilder.DropIndex(
                name: "IX_Werknemers_roleId",
                table: "Werknemers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Werknemers_departmentId",
                table: "Werknemers",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemers_roleId",
                table: "Werknemers",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Department_departmentId",
                table: "Werknemers",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Werknemers_Role_roleId",
                table: "Werknemers",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
