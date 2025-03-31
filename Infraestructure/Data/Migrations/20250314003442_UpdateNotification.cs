using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilePhoto",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8179), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8181), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8182), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8183), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8184), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 619, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3813), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3822), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 620, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3721), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 13, 18, 34, 41, 621, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilePhoto",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3062), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3064), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3068), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3075), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(691), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4524), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4524), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4529), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
