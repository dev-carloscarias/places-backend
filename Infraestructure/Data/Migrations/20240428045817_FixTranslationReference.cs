using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTranslationReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2929), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2933), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2934), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2936), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2937), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2943), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 561, DateTimeKind.Unspecified).AddTicks(2944), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2058), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2061), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2064), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 562, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2796), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2810), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2815), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 58, 16, 563, DateTimeKind.Unspecified).AddTicks(2816), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Translates_CountryId",
                table: "Translates",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Countries_CountryId",
                table: "Translates",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Currencies_CurrencyId",
                table: "Translates",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Language_LanguageId",
                table: "Translates",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Countries_CountryId",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Currencies_CurrencyId",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Language_LanguageId",
                table: "Translates");

            migrationBuilder.DropIndex(
                name: "IX_Translates_CountryId",
                table: "Translates");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8003), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8010), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8015), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8022), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 920, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5744), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 925, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5866), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5905), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5907), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5909), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5912), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 27, 22, 50, 13, 927, DateTimeKind.Unspecified).AddTicks(5914), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
