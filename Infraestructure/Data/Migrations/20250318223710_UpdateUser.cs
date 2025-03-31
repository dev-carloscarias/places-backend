using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusinessPatent",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessPatentType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentoId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentoIdType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LegalRepresentation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LegalRepresentationType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "DataFiles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5092), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5095), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5099), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 876, DateTimeKind.Unspecified).AddTicks(5102), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1294), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1307), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 877, DateTimeKind.Unspecified).AddTicks(1312), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2641), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2643), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2645), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2647), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 18, 16, 37, 9, 878, DateTimeKind.Unspecified).AddTicks(2648), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessPatent",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessPatentType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DocumentoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DocumentoIdType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LegalRepresentation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LegalRepresentationType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "DataFiles");

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
    }
}
