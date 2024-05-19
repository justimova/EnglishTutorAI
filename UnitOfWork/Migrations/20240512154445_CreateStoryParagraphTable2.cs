using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateStoryParagraphTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.CreateTable(
                name: "StoryParagraphs",
                columns: table => new
                {
                    StoryParagraphId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryParagraphs", x => x.StoryParagraphId);
                    table.ForeignKey(
                        name: "FK_StoryParagraphs_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50c35be4-7135-427d-90e4-8a7836c26cc7", 0, "4045ad40-ba52-4b0a-a8fe-d3f5c2b13d1e", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "564e6351-c160-4597-9fe3-0aebf358da25", false, "SuperAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_StoryParagraphs_StoryId",
                table: "StoryParagraphs",
                column: "StoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoryParagraphs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50c35be4-7135-427d-90e4-8a7836c26cc7");

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
    }
}
