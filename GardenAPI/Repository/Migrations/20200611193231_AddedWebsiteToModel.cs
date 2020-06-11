using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddedWebsiteToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Garden",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 1,
                columns: new[] { "State", "Website" },
                values: new object[] { "WI", "www.alicesgardenmke.com" });

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 2,
                columns: new[] { "State", "Website" },
                values: new object[] { "WI", "" });

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 3,
                columns: new[] { "State", "Website" },
                values: new object[] { "WI", "https://urbanecologycenter.org/" });

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 4,
                columns: new[] { "State", "Website" },
                values: new object[] { "WI", "https://www.ololmke.org/community-garden/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Website",
                table: "Garden");

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 1,
                column: "State",
                value: "Wisconsin");

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 2,
                column: "State",
                value: "Wisconsin");

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 3,
                column: "State",
                value: "Wisconsin");

            migrationBuilder.UpdateData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 4,
                column: "State",
                value: "Wisconsin");
        }
    }
}
