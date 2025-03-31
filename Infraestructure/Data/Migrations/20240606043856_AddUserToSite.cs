using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6239), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6275), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6283), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4958), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_UserId",
                table: "Sites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Users_UserId",
                table: "Sites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Users_UserId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_UserId",
                table: "Sites");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9107), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9111), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 54, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7172), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7189), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 55, DateTimeKind.Unspecified).AddTicks(7190), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8877), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8892), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 32, 42, 56, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
