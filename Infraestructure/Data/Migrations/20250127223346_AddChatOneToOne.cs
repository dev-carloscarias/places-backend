using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddChatOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatConversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserOneId = table.Column<int>(type: "int", nullable: false),
                    UserTwoId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatConversation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatConversation_Users_UserOneId",
                        column: x => x.UserOneId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatConversation_Users_UserTwoId",
                        column: x => x.UserTwoId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatConversationId = table.Column<int>(type: "int", nullable: false),
                    SenderUserId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessage_ChatConversation_ChatConversationId",
                        column: x => x.ChatConversationId,
                        principalTable: "ChatConversation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatMessage_Users_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3022), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3025), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3027), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3028), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 762, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 763, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6077), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6079), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6082), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6082), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6084), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 27, 16, 33, 45, 764, DateTimeKind.Unspecified).AddTicks(6084), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_ChatConversation_UserOneId",
                table: "ChatConversation",
                column: "UserOneId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatConversation_UserTwoId",
                table: "ChatConversation",
                column: "UserTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_ChatConversationId",
                table: "ChatMessage",
                column: "ChatConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_SenderUserId",
                table: "ChatMessage",
                column: "SenderUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "ChatConversation");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5027), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5029), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5030), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5033), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5036), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 775, DateTimeKind.Unspecified).AddTicks(5037), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(503), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(507), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 776, DateTimeKind.Unspecified).AddTicks(508), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(110), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(111), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(113), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 1, 10, 13, 8, 4, 777, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
