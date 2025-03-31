using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CorporateEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Hobbie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobbie_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Hobbie_userId",
                table: "Hobbie",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbie");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CorporateEmail",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2136), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2139), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2141), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2143), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(2145), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7484), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7490), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 96, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6926), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6934), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6938), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6939), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 14, 18, 48, 40, 97, DateTimeKind.Unspecified).AddTicks(6941), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
