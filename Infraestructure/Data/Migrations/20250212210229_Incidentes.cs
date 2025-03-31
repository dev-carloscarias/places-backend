using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Incidentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_SiteId",
                table: "Incidents",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_UserId",
                table: "Incidents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3504), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3507), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3510), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3512), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3512), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9801), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9802), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 686, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9842), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9850), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9854), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9855), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9856), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 2, 6, 17, 9, 49, 687, DateTimeKind.Unspecified).AddTicks(9857), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
