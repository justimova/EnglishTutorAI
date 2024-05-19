using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class CreateEssayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cf522c63-76f1-44e1-b2ee-6bf1579e3301");

            migrationBuilder.CreateTable(
                name: "Essays",
                columns: table => new
                {
                    EssayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BriefText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SourceText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslatedText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Essays", x => x.EssayId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b297c994-388b-4f0a-8847-86836169a240", 0, "fd3ddb53-a221-4987-8cae-d530d04099e3", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "c2ece1e0-5451-4497-98b1-0fa38d17760b", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Essays");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b297c994-388b-4f0a-8847-86836169a240");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cf522c63-76f1-44e1-b2ee-6bf1579e3301", 0, "886d874b-b627-475a-9e39-34cfc65d56fe", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "bc0c8011-829b-44d5-8e5d-08e9ddac2940", false, "SuperAdmin" });
        }
    }
}
