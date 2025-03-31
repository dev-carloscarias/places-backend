using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPricePrecisionInAdditionalCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdultPrice",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "TransportationPrice",
                table: "Sites",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "ChildPrice",
                table: "Sites",
                newName: "EntryPrice");

            migrationBuilder.CreateTable(
                name: "AdditionalCost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCost_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialPackage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialPackage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecialPackage_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialPackageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageItem_SpecialPackage_SpecialPackageId",
                        column: x => x.SpecialPackageId,
                        principalTable: "SpecialPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1614), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1615), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1621), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7123), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7137), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 741, DateTimeKind.Unspecified).AddTicks(7138), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 10, 17, 742, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCost_SiteId",
                table: "AdditionalCost",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageItem_SpecialPackageId",
                table: "PackageItem",
                column: "SpecialPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialPackage_SiteId",
                table: "SpecialPackage",
                column: "SiteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCost");

            migrationBuilder.DropTable(
                name: "PackageItem");

            migrationBuilder.DropTable(
                name: "SpecialPackage");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Sites",
                newName: "TransportationPrice");

            migrationBuilder.RenameColumn(
                name: "EntryPrice",
                table: "Sites",
                newName: "ChildPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "AdultPrice",
                table: "Sites",
                type: "numeric(18,2)",
                maxLength: 18,
                precision: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1966), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1979), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 718, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 719, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4883), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 8, 1, 12, 9, 23, 721, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
