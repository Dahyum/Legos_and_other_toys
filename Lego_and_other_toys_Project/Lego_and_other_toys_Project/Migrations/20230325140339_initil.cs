using Microsoft.EntityFrameworkCore.Migrations;

namespace Lego_and_other_toys_Project.Migrations
{
    public partial class initil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BabyToys",
                columns: table => new
                {
                    Toy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Toy_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BabyToys", x => x.Toy_id);
                });

            migrationBuilder.CreateTable(
                name: "BoardGames",
                columns: table => new
                {
                    Toy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Toy_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoP = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGames", x => x.Toy_id);
                });

            migrationBuilder.CreateTable(
                name: "LEGOSets",
                columns: table => new
                {
                    Set_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Set_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Series_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    In_stock = table.Column<bool>(type: "bit", nullable: false),
                    Age_group = table.Column<int>(type: "int", nullable: false),
                    NoB = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    In_Production = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEGOSets", x => x.Set_id);
                });

            migrationBuilder.CreateTable(
                name: "SportsToys",
                columns: table => new
                {
                    Toy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsToys", x => x.Toy_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BabyToys");

            migrationBuilder.DropTable(
                name: "BoardGames");

            migrationBuilder.DropTable(
                name: "LEGOSets");

            migrationBuilder.DropTable(
                name: "SportsToys");
        }
    }
}
