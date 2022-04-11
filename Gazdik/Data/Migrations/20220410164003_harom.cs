using Microsoft.EntityFrameworkCore.Migrations;

namespace Gazdik.Data.Migrations
{
    public partial class harom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GazdiAdatok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GazdiId = table.Column<int>(type: "int", nullable: false),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefonszam = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GazdiAdatok", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GazdiAdatok");
        }
    }
}
