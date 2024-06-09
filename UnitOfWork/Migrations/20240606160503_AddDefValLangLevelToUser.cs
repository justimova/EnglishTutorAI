using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddDefValLangLevelToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e79d45fa-2642-4a87-b81d-11b477430bf2");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "FirstName", "LanguageLevelId", "LastName", "LockoutEnabled", "LockoutEnd", "ModificationDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "175f5a9c-4399-4bbb-8903-c1bd87b4760b", 0, "63727778-47dd-4ad2-8e20-3bb7689601d8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperAdmin@gmail.com", false, null, 1, null, false, null, null, null, null, null, null, false, "2de2e70b-734d-4a2f-bf34-c37443e267b6", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "175f5a9c-4399-4bbb-8903-c1bd87b4760b");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "FirstName", "LanguageLevelId", "LastName", "LockoutEnabled", "LockoutEnd", "ModificationDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e79d45fa-2642-4a87-b81d-11b477430bf2", 0, "bae81fd1-059e-4a9f-80ae-87b476224cb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperAdmin@gmail.com", false, null, 1, null, false, null, null, null, null, null, null, false, "1af1f24d-248a-4ddb-b6bb-e314dcb09fdc", false, "SuperAdmin" });
        }
    }
}
