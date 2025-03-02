using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MatalkWebApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d90c529-3e46-4798-8f4f-8e1e6aedbb7e", null, "User", "USER" },
                    { "b903f5ea-22aa-46e6-9c98-ea57d981d68c", null, "Admin", "ADMIN" },
                    { "d96385fa-c93e-4940-a1c2-a9d7a59e704a", null, "Host", "HOST" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d90c529-3e46-4798-8f4f-8e1e6aedbb7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b903f5ea-22aa-46e6-9c98-ea57d981d68c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96385fa-c93e-4940-a1c2-a9d7a59e704a");
        }
    }
}
