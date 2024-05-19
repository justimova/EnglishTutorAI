using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateGrammarTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b61c806-9d10-4b04-bb77-7d4618e576b6");

            migrationBuilder.CreateTable(
                name: "GrammarTopics",
                columns: table => new
                {
                    GrammarTopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageLevelId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrammarTopics", x => x.GrammarTopicId);
                    table.ForeignKey(
                        name: "FK_GrammarTopics_LanguageLevels_LanguageLevelId",
                        column: x => x.LanguageLevelId,
                        principalTable: "LanguageLevels",
                        principalColumn: "LanguageLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GrammarTopics",
                columns: new[] { "GrammarTopicId", "Description", "LanguageLevelId", "Order", "Text" },
                values: new object[,]
                {
                    { 1, "For habitual actions and daily routines", 2, 1, "Present Simple Tense" },
                    { 2, "For actions happening at the moment of speaking", 2, 2, "Present Continuous Tense" },
                    { 3, "To talk about completed actions in the past", 2, 3, "Past Simple Tense" },
                    { 4, "For planned actions or intentions", 2, 4, "Future with 'going to'" },
                    { 5, "To express ability or possibility", 2, 5, "Can/Could for Ability" },
                    { 6, "To compare things and people", 2, 6, "Comparatives and Superlatives" },
                    { 7, "Such as 'in', 'at', 'on' for describing time", 2, 7, "Prepositions of Time" },
                    { 8, "Such as 'in', 'at', 'on' for describing location", 2, 8, "Prepositions of Place" },
                    { 9, "Such as 'must', 'should' for necessity and advice", 2, 9, "Simple Modal Verbs" },
                    { 10, "Using 's and s' to show possession", 2, 10, "Possessives" },
                    { 11, "Including use of 'some' and 'any'", 2, 11, "Countable and Uncountable Nouns" },
                    { 12, "Such as 'always', 'usually', 'often', 'sometimes', 'never'", 2, 12, "Adverbs of Frequency" },
                    { 13, "To describe the existence or presence of something", 2, 13, "There is/There are" },
                    { 14, "For giving direct orders and requests", 2, 14, "Imperatives" },
                    { 15, "For actions that were in progress at a specific time in the past", 2, 15, "Past Continuous Tense" }
                });

            migrationBuilder.UpdateData(
                table: "LanguageLevels",
                keyColumn: "LanguageLevelId",
                keyValue: 2,
                column: "Description",
                value: "Can understand sentences and frequently used expressions related to areas of most immediate relevance (e.g., very basic personal and family information, shopping, local geography, employment).\r\nCan communicate in simple and routine tasks requiring a simple and direct exchange of information on familiar and routine matters.\r\nCan describe in simple terms aspects of their background, immediate environment, and matters in areas of immediate need.");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ee84463-8487-44e6-8e9f-9ba6542b0465", 0, "6788ae54-071c-4f5b-aed1-986160666db0", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "9aaf4bd7-baa3-4b51-a1ea-1dfb5e0f8565", false, "SuperAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_GrammarTopics_LanguageLevelId",
                table: "GrammarTopics",
                column: "LanguageLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrammarTopics");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ee84463-8487-44e6-8e9f-9ba6542b0465");

            migrationBuilder.UpdateData(
                table: "LanguageLevels",
                keyColumn: "LanguageLevelId",
                keyValue: 2,
                column: "Description",
                value: "1. Can understand sentences and frequently used expressions related to areas of most immediate relevance (e.g., very basic personal and family information, shopping, local geography, employment).\r\nCan communicate in simple and routine tasks requiring a simple and direct exchange of information on familiar and routine matters.\r\nCan describe in simple terms aspects of their background, immediate environment, and matters in areas of immediate need.");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b61c806-9d10-4b04-bb77-7d4618e576b6", 0, "3a858112-6e14-42a9-a4c5-a81a141cd538", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "f0c4bff3-7052-40d7-b4ab-c8680ce00d2f", false, "SuperAdmin" });
        }
    }
}
