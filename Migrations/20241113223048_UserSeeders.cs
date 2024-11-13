using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CordiSimpleDotnet.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "last_name", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "caro@example.com", "bte", "caro", "password", "admin" },
                    { 2, "cami@example.com", "campi", "cami", "password", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
