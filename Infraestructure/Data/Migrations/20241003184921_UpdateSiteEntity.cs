using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSiteEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Sites",
                newName: "TransportationPrice");

            migrationBuilder.RenameColumn(
                name: "EntryPrice",
                table: "Sites",
                newName: "ChildPrice");

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsBicycle",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsBus",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsCar",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsMotorcycle",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptsTruck",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "AdultPrice",
                table: "Sites",
                type: "numeric(18,2)",
                maxLength: 18,
                precision: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Sites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9093), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9094), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 208, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4358), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 209, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3752), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 3, 12, 49, 21, 210, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptsBicycle",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsBus",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsCar",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsMotorcycle",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AcceptsTruck",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "AdultPrice",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "TransportationPrice",
                table: "Sites",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ChildPrice",
                table: "Sites",
                newName: "EntryPrice");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1419), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1452), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7331), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7344), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 271, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6483), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6484), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6485), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6490), new TimeSpan(0, -6, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 19, 16, 14, 55, 272, DateTimeKind.Unspecified).AddTicks(6491), new TimeSpan(0, -6, 0, 0, 0)) });
        }
    }
}
