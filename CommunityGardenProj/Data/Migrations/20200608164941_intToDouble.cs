using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class intToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc9deb47-53f9-437b-83bb-2f7c0adf7125");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd0487c3-ff19-48a1-b4be-61f621903eab", "528ca52c-385c-45f0-b25e-662c9c6f0c17", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0487c3-ff19-48a1-b4be-61f621903eab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc9deb47-53f9-437b-83bb-2f7c0adf7125", "dedf8f66-9d33-4ee9-92e2-8ced0d224457", "Admin", "ADMIN" });
        }
    }
}
