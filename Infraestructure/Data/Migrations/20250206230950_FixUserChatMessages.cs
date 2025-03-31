using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixUserChatMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserChatMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ChatMessageId = table.Column<int>(type: "int", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ChatMessageId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserChatMessages_ChatMessages_ChatMessageId",
                        column: x => x.ChatMessageId,
                        principalTable: "ChatMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserChatMessages_ChatMessages_ChatMessageId1",
                        column: x => x.ChatMessageId1,
                        principalTable: "ChatMessages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserChatMessages_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserChatMessages_ChatMessageId",
                table: "UserChatMessages",
                column: "ChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatMessages_ChatMessageId1",
                table: "UserChatMessages",
                column: "ChatMessageId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatMessages_UserId",
                table: "UserChatMessages",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChatMessages");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6269), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6299), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6301), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6304), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 336, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1741), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 337, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1576), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 28, 16, 45, 29, 338, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
