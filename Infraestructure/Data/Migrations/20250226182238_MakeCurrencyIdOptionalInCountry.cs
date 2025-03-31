using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeCurrencyIdOptionalInCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Countries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId1",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9637), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9662), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9665), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9665), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9666), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9668), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 919, DateTimeKind.Unspecified).AddTicks(9669), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5059), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5067), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5068), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 920, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4584), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 26, 12, 22, 37, 921, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId1",
                table: "Countries",
                column: "CurrencyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyId1",
                table: "Countries",
                column: "CurrencyId1",
                principalTable: "Currencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyId1",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyId1",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencyId1",
                table: "Countries");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5644), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5674), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5677), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 938, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1662), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1680), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1680), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1682), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 939, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2223), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2223), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2227), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 12, 15, 2, 28, 940, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
