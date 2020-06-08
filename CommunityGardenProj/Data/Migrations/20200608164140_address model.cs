using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class addressmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5890dd8-adb2-423a-a808-f42c65372c97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc9deb47-53f9-437b-83bb-2f7c0adf7125", "dedf8f66-9d33-4ee9-92e2-8ced0d224457", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc9deb47-53f9-437b-83bb-2f7c0adf7125");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5890dd8-adb2-423a-a808-f42c65372c97", "8f311f95-88d7-4371-b4ce-9eae4adac647", "Admin", "ADMIN" });
        }
    }
}
