using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixCountryCurrencyIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DefaultCurrencyId",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "ContinentId",
                table: "Countries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6841), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6843), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6845), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 11, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3178), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3187), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 14, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4262), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4283), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4285), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4286), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4287), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 17, 59, 18, 15, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "ContinentId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefaultCurrencyId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(821), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(853), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(856), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(862), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(864), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 388, DateTimeKind.Unspecified).AddTicks(865), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1410), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1413), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1414), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 390, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(463), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(480), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 26, 20, 0, 2, 391, DateTimeKind.Unspecified).AddTicks(482), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
