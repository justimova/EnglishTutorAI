using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTranscriptAndExamplesDictionaryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b8c7d00-ca09-4431-9eee-ef085b0eb95e");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50d6658b-7743-4dbe-a2ae-31cca240d450", 0, "8aa38592-3627-415d-bd35-31b574ec799c", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "dbc485d2-96fd-4d31-9468-ab6000678f3b", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50d6658b-7743-4dbe-a2ae-31cca240d450");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b8c7d00-ca09-4431-9eee-ef085b0eb95e", 0, "49cbd938-27a0-4697-bcc9-bd5a89475340", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "78577e33-c4ff-433a-a958-a48296d12e4d", false, "SuperAdmin" });
        }
    }
}
