using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RatingValue = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_SiteId",
                table: "Ratings",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

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
        }
    }
}
