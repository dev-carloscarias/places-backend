using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTransportOptionsAndSelectedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptsBicycle",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsBus",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsCar",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsMotorcycle",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "AcceptsTruck",
                table: "Sites",
                newName: "NewRegion");

            migrationBuilder.AddColumn<string>(
                name: "NewRegionName",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SitePolicies",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SelectedDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedDates_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransportOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectedTransportOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    TransportOptionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedTransportOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedTransportOptions_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedTransportOptions_TransportOptions_TransportOptionId",
                        column: x => x.TransportOptionId,
                        principalTable: "TransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4622), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4625), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9931), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9936), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 972, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9304), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9314), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9315), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 10, 12, 26, 2, 973, DateTimeKind.Unspecified).AddTicks(9319), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedDates_SiteId",
                table: "SelectedDates",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedTransportOptions_SiteId",
                table: "SelectedTransportOptions",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedTransportOptions_TransportOptionId",
                table: "SelectedTransportOptions",
                column: "TransportOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedDates");

            migrationBuilder.DropTable(
                name: "SelectedTransportOptions");

            migrationBuilder.DropTable(
                name: "TransportOptions");

            migrationBuilder.DropColumn(
                name: "NewRegionName",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "SitePolicies",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "NewRegion",
                table: "Sites",
                newName: "AcceptsTruck");

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsBicycle",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsBus",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsCar",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsMotorcycle",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8449), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8451), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8454), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8455), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 631, DateTimeKind.Unspecified).AddTicks(8456), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 632, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7955), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 25, 14, 49, 34, 633, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
