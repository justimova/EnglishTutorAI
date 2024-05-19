using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToAuthorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ca39f5a3-6ec1-45d7-89aa-287775774788");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Edgar Allan Poe" },
                    { 2, "O.Henry" },
                    { 3, "Ernest Hemingway" },
                    { 4, "F.Scott Fitzgerald" },
                    { 5, "Alice Munro" },
                    { 6, "Jorge Luis Borges" },
                    { 7, "Guy de Maupassant" },
                    { 8, "Ray Bradbury" },
                    { 9, "Flannery O'Connor" },
                    { 10, "Shirley Jackson" },
                    { 11, "Haruki Murakami" },
                    { 12, "Jules Verne" },
                    { 13, "Mark Twain" },
                    { 14, "Stephen King" },
                    { 15, "John Cheever" },
                    { 16, "Isaac Asimov" },
                    { 17, "James Joyce" },
                    { 18, "Nathaniel Hawthorne" },
                    { 19, "H.P.Lovecraft" },
                    { 20, "Virginia Woolf" },
                    { 21, "William Faulkner" },
                    { 22, "Eudora Welty" },
                    { 23, "Katherine Mansfield" },
                    { 24, "Kurt Vonnegut" },
                    { 25, "Philip K.Dick" },
                    { 26, "Charles Bukowski" },
                    { 27, "Roald Dahl" },
                    { 28, "Henry James" },
                    { 29, "Edgar Rice Burroughs" },
                    { 30, "Truman Capote" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "809a8a2c-a97c-4ef2-860a-e43259221c3e", 0, "dee49265-fd1a-4bfd-95b6-de78b0fad9d2", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "b64f0689-8905-4d99-8399-44c932e97e05", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "809a8a2c-a97c-4ef2-860a-e43259221c3e");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ca39f5a3-6ec1-45d7-89aa-287775774788", 0, "55976dc9-4a34-4d91-a6b9-a2cf18a17b19", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "b9f3b395-2f57-40aa-9daf-6a3423bc04cf", false, "SuperAdmin" });
        }
    }
}
