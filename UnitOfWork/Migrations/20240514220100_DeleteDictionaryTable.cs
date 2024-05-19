using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class DeleteDictionaryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dictionaries");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50d6658b-7743-4dbe-a2ae-31cca240d450");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "775c5d22-abf5-400e-8f32-0c94f66d8528", 0, "48f8cc89-05c5-43f0-95c6-0df5578f8e45", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "afde18c9-3035-441a-bc16-2a27a0b47878", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    Examples = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Transcript = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.DictionaryId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50d6658b-7743-4dbe-a2ae-31cca240d450", 0, "8aa38592-3627-415d-bd35-31b574ec799c", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "dbc485d2-96fd-4d31-9468-ab6000678f3b", false, "SuperAdmin" });
        }
    }
}
