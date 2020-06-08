using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class Caps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2fbf5e-4d09-4a71-bc06-6753de77c1d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de960b7d-83b7-4006-9dff-73fd03148bb7", "d8659b04-b884-4298-b78e-dfbd30d7ab3d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de960b7d-83b7-4006-9dff-73fd03148bb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f2fbf5e-4d09-4a71-bc06-6753de77c1d9", "831cece1-4320-464c-9747-38872f55d6af", "Admin", "ADMIN" });
        }
    }
}
