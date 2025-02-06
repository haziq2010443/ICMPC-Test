using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ICMPC_Test.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$12$9HzWcMXJlvqyQzqekyHtPeFlFvRz0QNv21yN3HW1Ytbn2j6QZobCq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$7Qy5wIxiPIuokfKhFwKAMOIRY8N5p9N40XNDX4wLopzAdprdiBeRm");
        }
    }
}
