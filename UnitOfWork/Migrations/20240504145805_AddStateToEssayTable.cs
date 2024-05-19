using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddStateToEssayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b297c994-388b-4f0a-8847-86836169a240");

            migrationBuilder.AlterColumn<string>(
                name: "TranslatedText",
                table: "Essays",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Essays",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Essays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e4df443-1bdb-4dad-9435-e458fb04d87a", 0, "5326a8e7-95ca-4046-9bb1-1ee2f26c8b91", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "e8be4743-64c0-4ccb-8d89-f194290605e5", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e4df443-1bdb-4dad-9435-e458fb04d87a");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Essays");

            migrationBuilder.AlterColumn<string>(
                name: "TranslatedText",
                table: "Essays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDate",
                table: "Essays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b297c994-388b-4f0a-8847-86836169a240", 0, "fd3ddb53-a221-4987-8cae-d530d04099e3", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "c2ece1e0-5451-4497-98b1-0fa38d17760b", false, "SuperAdmin" });
        }
    }
}
