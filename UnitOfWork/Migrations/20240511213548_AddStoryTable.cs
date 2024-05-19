using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddStoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "faa391fb-abca-4246-91bd-ec94e47cbd0c");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Essays",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "366771e8-28e1-428d-9eb0-ad64eaaf3112", 0, "9de1a735-f1da-447d-beba-41a7fb8fc188", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "e7927686-a6d3-4f63-8eff-a1ff27267ca5", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "366771e8-28e1-428d-9eb0-ad64eaaf3112");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Essays",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "faa391fb-abca-4246-91bd-ec94e47cbd0c", 0, "751736ac-cff2-434e-951c-fb90c293b97f", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "1f7ed83e-6314-421d-8e88-ad77bf4dd57e", false, "SuperAdmin" });
        }
    }
}
