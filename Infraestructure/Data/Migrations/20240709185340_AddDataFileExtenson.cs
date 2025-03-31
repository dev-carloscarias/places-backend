using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataFileExtenson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DataTypeExtension",
                table: "DataFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3382), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3415), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3419), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3424), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3426), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 821, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2159), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2161), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 822, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4517), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4541), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4544), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4551), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 12, 53, 37, 823, DateTimeKind.Unspecified).AddTicks(4552), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataTypeExtension",
                table: "DataFiles");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5864), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5865), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5869), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5871), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 794, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4121), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4124), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 795, DateTimeKind.Unspecified).AddTicks(4129), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7782), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7785), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7786), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 3, 10, 43, 57, 796, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
