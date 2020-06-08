using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class doubleToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0487c3-ff19-48a1-b4be-61f621903eab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f2fbf5e-4d09-4a71-bc06-6753de77c1d9", "831cece1-4320-464c-9747-38872f55d6af", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2fbf5e-4d09-4a71-bc06-6753de77c1d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd0487c3-ff19-48a1-b4be-61f621903eab", "528ca52c-385c-45f0-b25e-662c9c6f0c17", "Admin", "ADMIN" });
        }
    }
}
