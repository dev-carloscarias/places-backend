using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Site : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4326), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4114), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8501), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8503), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8505), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3554), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3559), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3565), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 257, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3573), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3595), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 258, DateTimeKind.Unspecified).AddTicks(3598), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8860), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 30, 17, 4, 5, 259, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
