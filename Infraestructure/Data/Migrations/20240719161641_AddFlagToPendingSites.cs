using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFlagToPendingSites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPendingToApprove",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPendingToApprove",
                table: "Sites");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1323), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1365), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1368), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1369), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1375), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(1376), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9850), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9851), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 820, DateTimeKind.Unspecified).AddTicks(9855), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2374), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2414), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 13, 0, 33, 823, DateTimeKind.Unspecified).AddTicks(2422), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
