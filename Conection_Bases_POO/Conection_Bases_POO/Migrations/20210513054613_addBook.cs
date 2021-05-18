using Microsoft.EntityFrameworkCore.Migrations;

namespace Conection_Bases_POO.Migrations
{
    public partial class addBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    editorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isbn = table.Column<int>(type: "int", nullable: false),
                    numPages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
