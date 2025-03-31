using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddChatOneToOne2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatConversation_Users_UserOneId",
                table: "ChatConversation");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatConversation_Users_UserTwoId",
                table: "ChatConversation");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_ChatConversation_ChatConversationId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Users_SenderUserId",
                table: "ChatMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMessage",
                table: "ChatMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatConversation",
                table: "ChatConversation");

            migrationBuilder.RenameTable(
                name: "ChatMessage",
                newName: "ChatMessages");

            migrationBuilder.RenameTable(
                name: "ChatConversation",
                newName: "ChatConversations");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_SenderUserId",
                table: "ChatMessages",
                newName: "IX_ChatMessages_SenderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_ChatConversationId",
                table: "ChatMessages",
                newName: "IX_ChatMessages_ChatConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatConversation_UserTwoId",
                table: "ChatConversations",
                newName: "IX_ChatConversations_UserTwoId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatConversation_UserOneId",
                table: "ChatConversations",
                newName: "IX_ChatConversations_UserOneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMessages",
                table: "ChatMessages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatConversations",
                table: "ChatConversations",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ChatConversations_Users_UserOneId",
                table: "ChatConversations",
                column: "UserOneId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatConversations_Users_UserTwoId",
                table: "ChatConversations",
                column: "UserTwoId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_ChatConversations_ChatConversationId",
                table: "ChatMessages",
                column: "ChatConversationId",
                principalTable: "ChatConversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessages_Users_SenderUserId",
                table: "ChatMessages",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatConversations_Users_UserOneId",
                table: "ChatConversations");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatConversations_Users_UserTwoId",
                table: "ChatConversations");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_ChatConversations_ChatConversationId",
                table: "ChatMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessages_Users_SenderUserId",
                table: "ChatMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatMessages",
                table: "ChatMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatConversations",
                table: "ChatConversations");

            migrationBuilder.RenameTable(
                name: "ChatMessages",
                newName: "ChatMessage");

            migrationBuilder.RenameTable(
                name: "ChatConversations",
                newName: "ChatConversation");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessages_SenderUserId",
                table: "ChatMessage",
                newName: "IX_ChatMessage_SenderUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessages_ChatConversationId",
                table: "ChatMessage",
                newName: "IX_ChatMessage_ChatConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatConversations_UserTwoId",
                table: "ChatConversation",
                newName: "IX_ChatConversation_UserTwoId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatConversations_UserOneId",
                table: "ChatConversation",
                newName: "IX_ChatConversation_UserOneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatMessage",
                table: "ChatMessage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatConversation",
                table: "ChatConversation",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ChatConversation_Users_UserOneId",
                table: "ChatConversation",
                column: "UserOneId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatConversation_Users_UserTwoId",
                table: "ChatConversation",
                column: "UserTwoId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_ChatConversation_ChatConversationId",
                table: "ChatMessage",
                column: "ChatConversationId",
                principalTable: "ChatConversation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Users_SenderUserId",
                table: "ChatMessage",
                column: "SenderUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
