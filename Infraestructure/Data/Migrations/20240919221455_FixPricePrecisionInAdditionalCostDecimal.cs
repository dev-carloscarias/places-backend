using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPricePrecisionInAdditionalCostDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1419), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6483), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6485), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6491), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1614), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1615), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1621), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7138), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
