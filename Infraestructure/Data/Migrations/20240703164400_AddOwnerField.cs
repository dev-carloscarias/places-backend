using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnerField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPendingToResolve",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DataFileType",
                table: "DataFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPendingToResolve",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataFileType",
                table: "DataFiles");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6239), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6275), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6283), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 995, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 996, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4946), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4958), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 5, 22, 38, 55, 997, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
