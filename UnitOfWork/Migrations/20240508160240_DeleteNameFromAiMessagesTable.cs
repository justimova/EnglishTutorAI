using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class DeleteNameFromAiMessagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "85f7971b-ed5d-479b-be70-677b81373dab");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AiMessages");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "faa391fb-abca-4246-91bd-ec94e47cbd0c", 0, "751736ac-cff2-434e-951c-fb90c293b97f", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "1f7ed83e-6314-421d-8e88-ad77bf4dd57e", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "faa391fb-abca-4246-91bd-ec94e47cbd0c");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AiMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "85f7971b-ed5d-479b-be70-677b81373dab", 0, "fda11dfe-6e57-4c8d-938a-fe6c801dc77e", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "9d2b057d-8cd1-4755-85ab-27e8b8ff0d24", false, "SuperAdmin" });
        }
    }
}
