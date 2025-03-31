using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataFilesToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "DataFiles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2136), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2143), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7490), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6934), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_DataFiles_CategoryId",
                table: "DataFiles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataFiles_Categories_CategoryId",
                table: "DataFiles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataFiles_Categories_CategoryId",
                table: "DataFiles");

            migrationBuilder.DropIndex(
                name: "IX_DataFiles_CategoryId",
                table: "DataFiles");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "DataFiles");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2264), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2266), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
