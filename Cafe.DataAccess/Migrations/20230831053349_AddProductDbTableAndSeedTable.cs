using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cafe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductDbTableAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "FoodCode", "FoodName", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", "Pizza", 200.0, 180.0, 130.0, 160.0, "The New Food Village" },
                    { 2, "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", "Pasta", 300.0, 250.0, 200.0, 220.0, "The Pasta" },
                    { 3, "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", "New Cabab", 320.0, 300.0, 250.0, 280.0, "Cabab" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
