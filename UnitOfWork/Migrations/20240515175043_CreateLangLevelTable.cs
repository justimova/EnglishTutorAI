using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateLangLevelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aaf10fed-8384-4b25-97c0-f00f26b18857");

            migrationBuilder.CreateTable(
                name: "LanguageLevels",
                columns: table => new
                {
                    LanguageLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageLevels", x => x.LanguageLevelId);
                });

            migrationBuilder.InsertData(
                table: "LanguageLevels",
                columns: new[] { "LanguageLevelId", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A1", "Can understand and use familiar everyday expressions and very basic phrases aimed at the satisfaction of needs of a concrete type.\r\nCan introduce themselves and others and can ask and answer questions about personal details such as where they live, people they know, and things they have.\r\nCan interact in a simple way provided the other person talks slowly and clearly and is prepared to help.", "Beginner" },
                    { 2, "A2", "1. Can understand sentences and frequently used expressions related to areas of most immediate relevance (e.g., very basic personal and family information, shopping, local geography, employment).\r\nCan communicate in simple and routine tasks requiring a simple and direct exchange of information on familiar and routine matters.\r\nCan describe in simple terms aspects of their background, immediate environment, and matters in areas of immediate need.", "Elementary" },
                    { 3, "B1", "Can understand the main points of clear standard input on familiar matters regularly encountered in work, school, leisure, etc.\r\nCan deal with most situations likely to arise while traveling in an area where the language is spoken.\r\nCan produce simple connected text on topics that are familiar or of personal interest.\r\nCan describe experiences and events, dreams, hopes, and ambitions and briefly give reasons and explanations for opinions and plans.", "Intermediate" },
                    { 4, "B2", "Can understand the main ideas of complex text on both concrete and abstract topics, including technical discussions in their field of specialization.\r\nCan interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.\r\nCan produce clear, detailed text on a wide range of subjects and explain a viewpoint on a topical issue giving the advantages and disadvantages of various options.", "Upper Intermediate" },
                    { 5, "C1", "Can understand a wide range of demanding, longer texts, and recognize implicit meaning.\r\nCan express ideas fluently and spontaneously without much obvious searching for expressions.\r\nCan use language flexibly and effectively for social, academic, and professional purposes.\r\nCan produce clear, well-structured, detailed text on complex subjects, showing controlled use of organizational patterns, connectors, and cohesive devices.", "Advanced" },
                    { 6, "C2", "Can understand with ease virtually everything heard or read.\r\nCan summarize information from different spoken and written sources, reconstructing arguments and accounts in a coherent presentation.\r\nCan express themselves spontaneously, very fluently and precisely, differentiating finer shades of meaning even in more complex situations.", "Proficiency" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b61c806-9d10-4b04-bb77-7d4618e576b6", 0, "3a858112-6e14-42a9-a4c5-a81a141cd538", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "f0c4bff3-7052-40d7-b4ab-c8680ce00d2f", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageLevels");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b61c806-9d10-4b04-bb77-7d4618e576b6");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aaf10fed-8384-4b25-97c0-f00f26b18857", 0, "d345a4c3-00e4-4ef2-81f5-00fa56f577ef", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "4f32dc4e-17f5-4103-8b06-c6655e3fc0d8", false, "SuperAdmin" });
        }
    }
}
