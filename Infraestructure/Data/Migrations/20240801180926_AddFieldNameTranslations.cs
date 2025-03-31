using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldNameTranslations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "Translates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1966), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1979), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "Translates");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5698), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5705), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 21, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2763), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2778), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2779), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2781), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 22, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6756), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6760), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 19, 10, 16, 39, 23, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
