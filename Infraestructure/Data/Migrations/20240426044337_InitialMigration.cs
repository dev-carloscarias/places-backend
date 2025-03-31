using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Rate = table.Column<decimal>(type: "numeric(18,2)", maxLength: 18, precision: 2, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    Tranlation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iso2 = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    Iso3 = table.Column<string>(type: "char(3)", maxLength: 2, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DefaultCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ContinentId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MustChangePassword = table.Column<bool>(type: "bit", nullable: false),
                    PlatformId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    HasProperties = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7010), new TimeSpan(0, -6, 0, 0, 0)), 0, "África", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7038), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, -6, 0, 0, 0)), 0, "América", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7042), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 3, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, -6, 0, 0, 0)), 0, "Asia", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7044), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 4, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, -6, 0, 0, 0)), 0, "Europa", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7046), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 5, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -6, 0, 0, 0)), 0, "Oceanía", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 584, DateTimeKind.Unspecified).AddTicks(7047), new TimeSpan(0, -6, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, -6, 0, 0, 0)), 0, "Super Administrator", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, -6, 0, 0, 0)), 0, "Regular User", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(756), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 3, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(757), new TimeSpan(0, -6, 0, 0, 0)), 0, "Administrator", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(758), new TimeSpan(0, -6, 0, 0, 0)), 0 }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, -6, 0, 0, 0)), 0, "Email", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7401), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 2, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, -6, 0, 0, 0)), 0, "Facebook", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 3, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -6, 0, 0, 0)), 0, "Google", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -6, 0, 0, 0)), 0 },
                    { 4, new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, -6, 0, 0, 0)), 0, "Apple", new DateTimeOffset(new DateTime(2024, 4, 25, 22, 43, 37, 586, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, -6, 0, 0, 0)), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Translate_Comment_Language",
                table: "Translates",
                columns: new[] { "CommentId", "LanguageCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Translate_Currency_Language",
                table: "Translates",
                columns: new[] { "CurrencyId", "LanguageCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Translate_Language_Language",
                table: "Translates",
                columns: new[] { "LanguageId", "LanguageCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Translate_Message_Language",
                table: "Translates",
                columns: new[] { "MessageId", "LanguageCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Translates");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}