using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTemporaryImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemporaryImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileOrder = table.Column<int>(type: "int", nullable: false),
                    DataFileType = table.Column<int>(type: "int", nullable: false),
                    DataTypeExtension = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryImages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4302), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4310), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 255, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9685), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 11, 21, 12, 18, 34, 256, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporaryImages");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9410), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9435), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9438), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9441), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9441), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9444), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9445), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 781, DateTimeKind.Unspecified).AddTicks(9446), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(4993), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(5003), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(5007), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 782, DateTimeKind.Unspecified).AddTicks(5008), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4755), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4767), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4767), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4771), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 30, 13, 19, 6, 783, DateTimeKind.Unspecified).AddTicks(4772), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
