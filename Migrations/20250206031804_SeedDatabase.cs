using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ICMPC_Test.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "PasswordHash", "UserName" },
                values: new object[] { 1, "admin@example.com", "$2a$11$7Qy5wIxiPIuokfKhFwKAMOIRY8N5p9N40XNDX4wLopzAdprdiBeRm", "Admin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "ProductName", "UserId" },
                values: new object[,]
                {
                    { 1, "Description for product 1", 10.0, "Product 1", 1 },
                    { 2, "Description for product 2", 20.0, "Product 2", 1 },
                    { 3, "Description for product 3", 30.0, "Product 3", 1 },
                    { 4, "Description for product 4", 40.0, "Product 4", 1 },
                    { 5, "Description for product 5", 50.0, "Product 5", 1 },
                    { 6, "Description for product 6", 60.0, "Product 6", 1 },
                    { 7, "Description for product 7", 70.0, "Product 7", 1 },
                    { 8, "Description for product 8", 80.0, "Product 8", 1 },
                    { 9, "Description for product 9", 90.0, "Product 9", 1 },
                    { 10, "Description for product 10", 100.0, "Product 10", 1 },
                    { 11, "Description for product 11", 110.0, "Product 11", 1 },
                    { 12, "Description for product 12", 120.0, "Product 12", 1 },
                    { 13, "Description for product 13", 130.0, "Product 13", 1 },
                    { 14, "Description for product 14", 140.0, "Product 14", 1 },
                    { 15, "Description for product 15", 150.0, "Product 15", 1 },
                    { 16, "Description for product 16", 160.0, "Product 16", 1 },
                    { 17, "Description for product 17", 170.0, "Product 17", 1 },
                    { 18, "Description for product 18", 180.0, "Product 18", 1 },
                    { 19, "Description for product 19", 190.0, "Product 19", 1 },
                    { 20, "Description for product 20", 200.0, "Product 20", 1 },
                    { 21, "Description for product 21", 210.0, "Product 21", 1 },
                    { 22, "Description for product 22", 220.0, "Product 22", 1 },
                    { 23, "Description for product 23", 230.0, "Product 23", 1 },
                    { 24, "Description for product 24", 240.0, "Product 24", 1 },
                    { 25, "Description for product 25", 250.0, "Product 25", 1 },
                    { 26, "Description for product 26", 260.0, "Product 26", 1 },
                    { 27, "Description for product 27", 270.0, "Product 27", 1 },
                    { 28, "Description for product 28", 280.0, "Product 28", 1 },
                    { 29, "Description for product 29", 290.0, "Product 29", 1 },
                    { 30, "Description for product 30", 300.0, "Product 30", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
