using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ_Users_Email",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6005), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "UQ_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }
    }
}
