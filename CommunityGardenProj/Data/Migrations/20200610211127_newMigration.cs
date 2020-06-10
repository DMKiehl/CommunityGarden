using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Data.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e73e9b-f0e6-4639-adf0-19a621f80fe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f59cc27-fcfc-48a1-806c-59bcffb3f873");

            migrationBuilder.CreateTable(
                name: "Garden",
                columns: table => new
                {
                    gardenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    gardenType = table.Column<string>(nullable: true),
                    streetAddress = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zip = table.Column<int>(nullable: false),
                    latitude = table.Column<float>(nullable: false),
                    longitude = table.Column<float>(nullable: false),
                    volunteerOpportunities = table.Column<bool>(nullable: false),
                    organic = table.Column<bool>(nullable: false),
                    cost = table.Column<int>(nullable: false),
                    plotSize = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garden", x => x.gardenId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b0ddf5b-b325-4957-b04a-785cedbbf463", "29689f91-8721-4b7c-97d7-26eba39c1d8c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9dfe94e-1ae1-4efa-8b0b-97a8b864712e", "07fed3bf-2fd4-42ca-836e-5c6380bbb1e5", "Gardener", "GARDENER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garden");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b0ddf5b-b325-4957-b04a-785cedbbf463");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9dfe94e-1ae1-4efa-8b0b-97a8b864712e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13e73e9b-f0e6-4639-adf0-19a621f80fe5", "7914e27b-ed36-4565-8d32-4e01e8a17cb1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f59cc27-fcfc-48a1-806c-59bcffb3f873", "f56982dd-0d45-4ac4-9bc3-828fc8a50df6", "Gardener", "GARDENER" });
        }
    }
}
