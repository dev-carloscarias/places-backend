using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSelectedDatesToVarchar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectedDates",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9490), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9515), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9518), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9520), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9522), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 877, DateTimeKind.Unspecified).AddTicks(9525), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4753), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 878, DateTimeKind.Unspecified).AddTicks(4755), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4696), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4697), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4698), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4699), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 11, 9, 54, 44, 879, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedDates",
                table: "Sites");

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
    }
}
