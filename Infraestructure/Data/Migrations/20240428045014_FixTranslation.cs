using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Translates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "Translates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Translates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Translates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Translates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MessageId",
                table: "Translates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "Translates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Translates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Translates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Translates",
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
        }
    }
}
