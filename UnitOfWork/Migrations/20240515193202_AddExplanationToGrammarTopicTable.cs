using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddExplanationToGrammarTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ee84463-8487-44e6-8e9f-9ba6542b0465");

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "GrammarTopics",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 1,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 2,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 3,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 4,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 5,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 6,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 7,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 8,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 9,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 10,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 11,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 12,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 13,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 14,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 15,
                column: "Explanation",
                value: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e8885c5-c688-4d7d-bf57-c484cf0a2446", 0, "4bf845a1-2dc9-497b-96e8-25b4a4926ad0", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "ffa5cbb0-d42a-4aeb-a5c5-444a491f4b67", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0e8885c5-c688-4d7d-bf57-c484cf0a2446");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "GrammarTopics");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ee84463-8487-44e6-8e9f-9ba6542b0465", 0, "6788ae54-071c-4f5b-aed1-986160666db0", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "9aaf4bd7-baa3-4b51-a1ea-1dfb5e0f8565", false, "SuperAdmin" });
        }
    }
}
