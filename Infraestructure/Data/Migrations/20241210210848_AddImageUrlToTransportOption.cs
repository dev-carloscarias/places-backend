using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToTransportOption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TransportOptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1913), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1944), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7434), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 265, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 15, 8, 48, 266, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TransportOptions");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4622), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4625), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9931), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9304), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9314), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9315), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
