using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b803e0a-07de-4e78-8262-d1a1f241e3ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1e04b7-28b5-4590-9d1a-3ce1dcf7d777", "16da14f5-b70b-4047-80a3-3a00bb03a720", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1e04b7-28b5-4590-9d1a-3ce1dcf7d777");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b803e0a-07de-4e78-8262-d1a1f241e3ed", "14b459ae-e5cb-4051-89b2-229a27886563", "Admin", "ADMIN" });
        }
    }
}
