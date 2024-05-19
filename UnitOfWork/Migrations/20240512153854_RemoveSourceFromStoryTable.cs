using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSourceFromStoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "809a8a2c-a97c-4ef2-860a-e43259221c3e");

            migrationBuilder.DropColumn(
                name: "SourceText",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "TranslatedText",
                table: "Stories");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a6d4a00e-553f-40f4-a8f2-219147bc1fc5", 0, "2a9d2d1b-0c46-44b4-8636-0fb3041e4e80", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "f9732ff1-5c36-4cc3-9d27-72876c9f141b", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a6d4a00e-553f-40f4-a8f2-219147bc1fc5");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "SourceText",
                table: "Stories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TranslatedText",
                table: "Stories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "809a8a2c-a97c-4ef2-860a-e43259221c3e", 0, "dee49265-fd1a-4bfd-95b6-de78b0fad9d2", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "b64f0689-8905-4d99-8399-44c932e97e05", false, "SuperAdmin" });
        }
    }
}
