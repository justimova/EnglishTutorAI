using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateDictionaryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53e76d80-3421-44b0-aefe-32d8ca0cab0b");

            migrationBuilder.CreateTable(
                name: "Dictionaries",
                columns: table => new
                {
                    DictionaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Transcript = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Examples = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.DictionaryId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b8c7d00-ca09-4431-9eee-ef085b0eb95e", 0, "49cbd938-27a0-4697-bcc9-bd5a89475340", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "78577e33-c4ff-433a-a958-a48296d12e4d", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dictionaries");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b8c7d00-ca09-4431-9eee-ef085b0eb95e");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "53e76d80-3421-44b0-aefe-32d8ca0cab0b", 0, "02aec1e1-a460-486a-a2e8-2d9b0fd510c2", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "97755fa5-7e4b-44d2-ac11-42e1c73471ea", false, "SuperAdmin" });
        }
    }
}
