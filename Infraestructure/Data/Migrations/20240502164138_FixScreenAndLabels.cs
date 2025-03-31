using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixScreenAndLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Label_Screen_ScreenId",
                table: "Label");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Label_LabelId",
                table: "Translates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Screen",
                table: "Screen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Label",
                table: "Label");

            migrationBuilder.RenameTable(
                name: "Screen",
                newName: "Screens");

            migrationBuilder.RenameTable(
                name: "Label",
                newName: "Labels");

            migrationBuilder.RenameIndex(
                name: "IX_Label_ScreenId",
                table: "Labels",
                newName: "IX_Labels_ScreenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Screens",
                table: "Screens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Labels",
                table: "Labels",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7532), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7565), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7573), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7575), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7576), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 496, DateTimeKind.Unspecified).AddTicks(7579), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6974), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6987), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 497, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3373), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3412), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3414), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3418), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3421), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 2, 10, 41, 36, 500, DateTimeKind.Unspecified).AddTicks(3423), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Screens_ScreenId",
                table: "Labels",
                column: "ScreenId",
                principalTable: "Screens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Labels_LabelId",
                table: "Translates",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Screens_ScreenId",
                table: "Labels");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Labels_LabelId",
                table: "Translates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Screens",
                table: "Screens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Labels",
                table: "Labels");

            migrationBuilder.RenameTable(
                name: "Screens",
                newName: "Screen");

            migrationBuilder.RenameTable(
                name: "Labels",
                newName: "Label");

            migrationBuilder.RenameIndex(
                name: "IX_Labels_ScreenId",
                table: "Label",
                newName: "IX_Label_ScreenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Screen",
                table: "Screen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Label",
                table: "Label",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Label_Screen_ScreenId",
                table: "Label",
                column: "ScreenId",
                principalTable: "Screen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Label_LabelId",
                table: "Translates",
                column: "LabelId",
                principalTable: "Label",
                principalColumn: "Id");
        }
    }
}
