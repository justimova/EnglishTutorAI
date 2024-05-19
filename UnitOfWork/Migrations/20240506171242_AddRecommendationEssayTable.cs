using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddRecommendationEssayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e4df443-1bdb-4dad-9435-e458fb04d87a");

            migrationBuilder.AddColumn<string>(
                name: "Recommendation",
                table: "Essays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0ad8a8f-0373-4c09-ba57-7976b959b125", 0, "19cce1d0-1a12-40f0-82f9-bb66a55dfe99", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "b9159ac4-8c83-4955-9968-1012edffa0a7", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b0ad8a8f-0373-4c09-ba57-7976b959b125");

            migrationBuilder.DropColumn(
                name: "Recommendation",
                table: "Essays");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e4df443-1bdb-4dad-9435-e458fb04d87a", 0, "5326a8e7-95ca-4046-9bb1-1ee2f26c8b91", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "e8be4743-64c0-4ccb-8d89-f194290605e5", false, "SuperAdmin" });
        }
    }
}
