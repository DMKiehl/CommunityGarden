using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Organic",
                table: "Garden",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Garden",
                columns: new[] { "GardenId", "City", "Cost", "GardenType", "Latitude", "Longitude", "Name", "Organic", "PlotSize", "State", "StreetAddress", "VolunteerOpportunities", "Zip" },
                values: new object[,]
                {
                    { 1, "Milwaukee", 0.0, "Urban Farm", 43.058630000000001, -87.938800000000001, "Alice's Garden Urban Farm", false, "Cooperative", "Wisconsin", "2136 N. 21st St.", true, 53205.0 },
                    { 2, "West Bend", 15.0, "Vegetable", 43.396120000000003, -88.180239999999998, "Community Church Garden", false, "10 X 20", "Wisconsin", "2005 S. Main St.", false, 53095.0 },
                    { 3, "Milwaukee", 45.0, "Vegetable", 43.067729999999997, -87.890789999999996, "Urban Ecology Center- Riverside Park", true, "10 X 15", "Wisconsin", "1500 E Park Place", false, 53211.0 },
                    { 4, "Milwaukee", 20.0, "Vegetable", 42.976730000000003, -87.986170000000001, "Our Common Home Community Garden", false, "4 X 10", "Wisconsin", "3722 S. 58th St.", true, 53220.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "GardenId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Organic",
                table: "Garden");
        }
    }
}
