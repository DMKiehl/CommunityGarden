using Microsoft.EntityFrameworkCore.Migrations;



namespace CommunityGardenProj.Data.Migrations
{
    public partial class checkingSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de960b7d-83b7-4006-9dff-73fd03148bb7");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<double>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Gardeners",
                columns: table => new
                {
                    GardenerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GardenInterest = table.Column<string>(nullable: true),
                    AddressId = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardeners", x => x.GardenerId);
                    table.ForeignKey(
                        name: "FK_Gardeners_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gardeners_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13e73e9b-f0e6-4639-adf0-19a621f80fe5", "7914e27b-ed36-4565-8d32-4e01e8a17cb1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f59cc27-fcfc-48a1-806c-59bcffb3f873", "f56982dd-0d45-4ac4-9bc3-828fc8a50df6", "Gardener", "GARDENER" });

            migrationBuilder.CreateIndex(
                name: "IX_Gardeners_AddressId",
                table: "Gardeners",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Gardeners_IdentityUserId",
                table: "Gardeners",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gardeners");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e73e9b-f0e6-4639-adf0-19a621f80fe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f59cc27-fcfc-48a1-806c-59bcffb3f873");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de960b7d-83b7-4006-9dff-73fd03148bb7", "d8659b04-b884-4298-b78e-dfbd30d7ab3d", "Admin", "ADMIN" });
        }
    }
}
