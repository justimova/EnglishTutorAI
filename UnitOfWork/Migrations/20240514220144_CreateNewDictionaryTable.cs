using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewDictionaryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "775c5d22-abf5-400e-8f32-0c94f66d8528");

            migrationBuilder.CreateTable(
                name: "Dictionaries",
                columns: table => new
                {
                    DictionaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Transcript = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Examples = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.DictionaryId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aaf10fed-8384-4b25-97c0-f00f26b18857", 0, "d345a4c3-00e4-4ef2-81f5-00fa56f577ef", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "4f32dc4e-17f5-4103-8b06-c6655e3fc0d8", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dictionaries");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aaf10fed-8384-4b25-97c0-f00f26b18857");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "775c5d22-abf5-400e-8f32-0c94f66d8528", 0, "48f8cc89-05c5-43f0-95c6-0df5578f8e45", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "afde18c9-3035-441a-bc16-2a27a0b47878", false, "SuperAdmin" });
        }
    }
}
