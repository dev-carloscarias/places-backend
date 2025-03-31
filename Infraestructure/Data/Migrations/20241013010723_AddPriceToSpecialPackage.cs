using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToSpecialPackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SpecialPackage",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2262), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2264), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2266), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 656, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(390), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(392), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 12, 19, 7, 22, 658, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SpecialPackage");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9093), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4358), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3752), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
