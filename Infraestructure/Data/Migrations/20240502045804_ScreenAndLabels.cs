using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ScreenAndLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Translates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Label_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9036), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9046), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9048), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 689, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 691, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5028), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5033), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5041), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 22, 58, 1, 693, DateTimeKind.Unspecified).AddTicks(5046), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Translates_LabelId",
                table: "Translates",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_Label_ScreenId",
                table: "Label",
                column: "ScreenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Label_LabelId",
                table: "Translates",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Label_LabelId",
                table: "Translates");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Screen");

            migrationBuilder.DropIndex(
                name: "IX_Translates_LabelId",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Translates");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2666), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2695), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2700), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2702), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 528, DateTimeKind.Unspecified).AddTicks(2710), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1761), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1763), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 529, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2762), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2765), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2768), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2770), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 29, 22, 2, 50, 530, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
