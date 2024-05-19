using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddSourceToStoryTableAndModifyStoryParagraphTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50c35be4-7135-427d-90e4-8a7836c26cc7");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "StoryParagraphs");

            migrationBuilder.AddColumn<string>(
                name: "TranslatedText",
                table: "StoryParagraphs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "53e76d80-3421-44b0-aefe-32d8ca0cab0b", 0, "02aec1e1-a460-486a-a2e8-2d9b0fd510c2", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "97755fa5-7e4b-44d2-ac11-42e1c73471ea", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53e76d80-3421-44b0-aefe-32d8ca0cab0b");

            migrationBuilder.DropColumn(
                name: "TranslatedText",
                table: "StoryParagraphs");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "StoryParagraphs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50c35be4-7135-427d-90e4-8a7836c26cc7", 0, "4045ad40-ba52-4b0a-a8fe-d3f5c2b13d1e", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "564e6351-c160-4597-9fe3-0aebf358da25", false, "SuperAdmin" });
        }
    }
}
