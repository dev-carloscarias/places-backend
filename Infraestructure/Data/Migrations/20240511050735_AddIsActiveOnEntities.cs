using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveOnEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Translates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Screens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Labels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Currencies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Continents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3319), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3349), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3351), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3352), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3353), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3354), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9646), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9654), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9657), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9659), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 589, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6369), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6370), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6371), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6372), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsActive", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, -6, 0, 0, 0)), true, new DateTimeOffset(new DateTime(2024, 5, 10, 23, 7, 34, 590, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Screens");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Continents");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6005), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
