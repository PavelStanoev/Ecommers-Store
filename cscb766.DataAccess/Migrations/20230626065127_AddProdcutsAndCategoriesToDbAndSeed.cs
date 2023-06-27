using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cscb766.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProdcutsAndCategoriesToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "SciFi" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "DiscountPrice", "ListPrice", "Name" },
                values: new object[,]
                {
                    { 1, "Ben's Original", "Savor the delicious taste of traditional Thai Jasmine rice and satisfy your desire for Southeast Asian cuisine in just 90 seconds.", 4.9900000000000002, 5.4500000000000002, "Microwave Rice" },
                    { 2, "Lindt", "Discover our classic LINDOR Milk Chocolate Truffles. Since 1845, the Lindt Master Chocolatiers have combined their expertise with the highest quality ingredients from around the world to produce the finest chocolates.", 7.5, 9.5, "Milk Chocolate Truffles" },
                    { 3, "Olympus", "Olympus fresh milk, produced from fresh milk carefully selected from selected farms, is the excellent choice for a brisk morning.", 2.5, 3.2999999999999998, "Milk" },
                    { 4, "Gradus", "Fresh chicken is suitable for grilling, in the oven, boiling and making delicious soup. Without added water, preservatives and phosphates.", 8.0999999999999996, 8.8000000000000007, "Whole chicken" },
                    { 5, "Crunchips", "Curly potato chips with barbecue flavor.", 2.7999999999999998, 3.0, "Chips" },
                    { 6, "Estrella", "The beer of Barcelona", 2.2000000000000002, 2.7999999999999998, "Corona Estrella" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
