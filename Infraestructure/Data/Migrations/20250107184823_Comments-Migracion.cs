using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CommentsMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
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
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4785), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4811), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4814), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4816), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4816), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4818), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4820), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 479, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(380), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 480, DateTimeKind.Unspecified).AddTicks(393), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(396), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(399), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(401), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(402), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 7, 12, 48, 23, 481, DateTimeKind.Unspecified).AddTicks(403), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SiteId",
                table: "Comments",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 225, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(305), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(316), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(319), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 226, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1128), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 12, 12, 12, 49, 28, 227, DateTimeKind.Unspecified).AddTicks(1129), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
