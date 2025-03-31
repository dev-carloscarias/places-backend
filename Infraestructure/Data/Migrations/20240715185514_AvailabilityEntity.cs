using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AvailabilityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AdultPrice",
                table: "Sites",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ChildPrice",
                table: "Sites",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TransportationPrice",
                table: "Sites",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availability_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6713), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6721), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6731), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 943, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3428), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3461), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3464), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3466), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3468), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 945, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2471), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2476), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2481), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2483), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 15, 12, 55, 9, 947, DateTimeKind.Unspecified).AddTicks(2488), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CategoryId",
                table: "Sites",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Availability_SiteId",
                table: "Availability",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Categories_CategoryId",
                table: "Sites",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Categories_CategoryId",
                table: "Sites");

            migrationBuilder.DropTable(
                name: "Availability");

            migrationBuilder.DropIndex(
                name: "IX_Sites_CategoryId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AdultPrice",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "ChildPrice",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "TransportationPrice",
                table: "Sites");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8033), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8076), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8080), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8083), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8086), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 5, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8897), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 6, DateTimeKind.Unspecified).AddTicks(8902), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5404), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 7, 9, 22, 42, 7, 8, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
