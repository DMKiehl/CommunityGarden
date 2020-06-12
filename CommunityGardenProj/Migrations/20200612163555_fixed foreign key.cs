using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityGardenProj.Migrations
{
    public partial class fixedforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Answers_AnswerId",
                table: "Discussions");

            migrationBuilder.DropIndex(
                name: "IX_Discussions_AnswerId",
                table: "Discussions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e71c458-33d4-48cc-be18-b818c6a58876");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8651be1f-7cfc-4fcd-834a-7d2dd1f78486");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Discussions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b19db248-194d-427a-8be4-30506f334453", "a6ea25cf-1e23-481f-8ecd-ef012c217468", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59a68e47-db22-4815-8f71-d15d4b2d41df", "c5ca57dd-f92c-4b99-802b-8e453bf5e227", "Gardener", "GARDENER" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Discussions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Discussions_QuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59a68e47-db22-4815-8f71-d15d4b2d41df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b19db248-194d-427a-8be4-30506f334453");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Discussions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e71c458-33d4-48cc-be18-b818c6a58876", "be59a80d-bb9e-46bd-b982-1a78d4271fc6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8651be1f-7cfc-4fcd-834a-7d2dd1f78486", "c9fef6ab-d9e2-419a-96cf-670f2f7b05e2", "Gardener", "GARDENER" });

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_AnswerId",
                table: "Discussions",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Answers_AnswerId",
                table: "Discussions",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
