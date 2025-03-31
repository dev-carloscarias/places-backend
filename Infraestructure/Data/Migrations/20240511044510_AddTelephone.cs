using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTelephone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 917, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4380), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4391), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4394), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 918, DateTimeKind.Unspecified).AddTicks(4397), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4242), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4256), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4258), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4260), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 22, 45, 5, 919, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5046), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5090), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5103), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5105), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5110), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 11, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4802), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 13, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4423), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4473), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4477), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4480), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 9, 11, 4, 50, 16, DateTimeKind.Unspecified).AddTicks(4482), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
