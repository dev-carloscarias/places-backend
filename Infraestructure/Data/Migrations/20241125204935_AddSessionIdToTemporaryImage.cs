using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSessionIdToTemporaryImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "TemporaryImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8451), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8454), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8456), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7955), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "TemporaryImages");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4302), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9685), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
