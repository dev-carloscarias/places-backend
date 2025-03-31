using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Category_CategoryId",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Site_SiteId",
                table: "Translates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Site",
                table: "Site");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Site",
                newName: "Sites");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sites",
                table: "Sites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmenityBySites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityBySites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmenityBySites_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityBySites_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileOrder = table.Column<int>(type: "int", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: true),
                    AmenityId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataFiles_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DataFiles_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7693), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7698), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7699), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 911, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4351), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4363), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 912, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5384), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5397), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 4, 23, 3, 54, 913, DateTimeKind.Unspecified).AddTicks(5403), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_AmenityBySites_AmenityId",
                table: "AmenityBySites",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_AmenityBySites_SiteId",
                table: "AmenityBySites",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_DataFiles_AmenityId",
                table: "DataFiles",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_DataFiles_SiteId",
                table: "DataFiles",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Categories_CategoryId",
                table: "Translates",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Sites_SiteId",
                table: "Translates",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Categories_CategoryId",
                table: "Translates");

            migrationBuilder.DropForeignKey(
                name: "FK_Translates_Sites_SiteId",
                table: "Translates");

            migrationBuilder.DropTable(
                name: "AmenityBySites");

            migrationBuilder.DropTable(
                name: "DataFiles");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sites",
                table: "Sites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Sites");

            migrationBuilder.RenameTable(
                name: "Sites",
                newName: "Site");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Site",
                table: "Site",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4326), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 473, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4109), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 474, DateTimeKind.Unspecified).AddTicks(4114), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8501), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8503), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8505), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 3, 21, 24, 5, 475, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Category_CategoryId",
                table: "Translates",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translates_Site_SiteId",
                table: "Translates",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "Id");
        }
    }
}
