using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class updatedGardner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1e04b7-28b5-4590-9d1a-3ce1dcf7d777");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5890dd8-adb2-423a-a808-f42c65372c97", "8f311f95-88d7-4371-b4ce-9eae4adac647", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5890dd8-adb2-423a-a808-f42c65372c97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1e04b7-28b5-4590-9d1a-3ce1dcf7d777", "16da14f5-b70b-4047-80a3-3a00bb03a720", "Admin", "ADMIN" });
        }
    }
}
