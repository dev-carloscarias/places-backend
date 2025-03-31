using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenityDescriptionToSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AmenityBySites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(305), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(316), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1129), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AmenityBySites");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8674), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8675), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8678), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 851, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4636), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4638), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 852, DateTimeKind.Unspecified).AddTicks(4642), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4665), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4672), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4675), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4676), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4678), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 13, 14, 20, 853, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
