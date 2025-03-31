using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Language",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(821), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(853), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(862), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(865), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1410), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1413), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1414), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(482), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Countries");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7038), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7042), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7044), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7046), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(757), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(758), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
