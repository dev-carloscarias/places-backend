using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustmentRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 963, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(128), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(136), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(138), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(139), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 964, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1028), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1029), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
