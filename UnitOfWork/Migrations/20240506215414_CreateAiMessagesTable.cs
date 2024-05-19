using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateAiMessagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b0ad8a8f-0373-4c09-ba57-7976b959b125");

            migrationBuilder.CreateTable(
                name: "AiMessages",
                columns: table => new
                {
                    AiMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    EssayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiMessages", x => x.AiMessageId);
                    table.ForeignKey(
                        name: "FK_AiMessages_Essays_EssayId",
                        column: x => x.EssayId,
                        principalTable: "Essays",
                        principalColumn: "EssayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "85f7971b-ed5d-479b-be70-677b81373dab", 0, "fda11dfe-6e57-4c8d-938a-fe6c801dc77e", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "9d2b057d-8cd1-4755-85ab-27e8b8ff0d24", false, "SuperAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_AiMessages_EssayId",
                table: "AiMessages",
                column: "EssayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AiMessages");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "85f7971b-ed5d-479b-be70-677b81373dab");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0ad8a8f-0373-4c09-ba57-7976b959b125", 0, "19cce1d0-1a12-40f0-82f9-bb66a55dfe99", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "b9159ac4-8c83-4955-9968-1012edffa0a7", false, "SuperAdmin" });
        }
    }
}
