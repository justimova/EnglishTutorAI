using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddUserColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ebaa475-2661-4190-92d6-a929fe8ec8f2");

            migrationBuilder.AddColumn<int>(
                name: "LanguageLevelId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Stories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Essays",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Dictionaries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "FirstName", "LanguageLevelId", "LastName", "LockoutEnabled", "LockoutEnd", "ModificationDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e79d45fa-2642-4a87-b81d-11b477430bf2", 0, "bae81fd1-059e-4a9f-80ae-87b476224cb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperAdmin@gmail.com", false, null, 1, null, false, null, null, null, null, null, null, false, "1af1f24d-248a-4ddb-b6bb-e314dcb09fdc", false, "SuperAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LanguageLevelId",
                table: "Users",
                column: "LanguageLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId",
                table: "Stories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Essays_UserId",
                table: "Essays",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionaries_UserId",
                table: "Dictionaries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dictionaries_Users_UserId",
                table: "Dictionaries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Essays_Users_UserId",
                table: "Essays",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Users_UserId",
                table: "Stories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_LanguageLevels_LanguageLevelId",
                table: "Users",
                column: "LanguageLevelId",
                principalTable: "LanguageLevels",
                principalColumn: "LanguageLevelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dictionaries_Users_UserId",
                table: "Dictionaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Essays_Users_UserId",
                table: "Essays");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Users_UserId",
                table: "Stories");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_LanguageLevels_LanguageLevelId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LanguageLevelId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Stories_UserId",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Essays_UserId",
                table: "Essays");

            migrationBuilder.DropIndex(
                name: "IX_Dictionaries_UserId",
                table: "Dictionaries");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e79d45fa-2642-4a87-b81d-11b477430bf2");

            migrationBuilder.DropColumn(
                name: "LanguageLevelId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Essays");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dictionaries");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModificationDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ebaa475-2661-4190-92d6-a929fe8ec8f2", 0, "344c5dd1-1fbc-46dc-abe9-dc8a4e2cbc11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, null, false, "790501f1-3c74-41ca-8c2d-02be8f7d1c10", false, "SuperAdmin" });
        }
    }
}
