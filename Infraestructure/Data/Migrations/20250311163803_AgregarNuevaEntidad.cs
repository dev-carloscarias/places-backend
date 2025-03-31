using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNuevaEntidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3062), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3064), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3068), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 514, DateTimeKind.Unspecified).AddTicks(3075), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(691), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 515, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4510), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4524), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4524), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 11, 10, 38, 2, 516, DateTimeKind.Unspecified).AddTicks(4529), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

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
        }
    }
}
