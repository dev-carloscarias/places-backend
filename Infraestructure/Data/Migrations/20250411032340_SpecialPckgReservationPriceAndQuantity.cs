using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SpecialPckgReservationPriceAndQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SpecialPackageAgreedPrice",
                table: "Reservations",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialPackageQuantity",
                table: "Reservations",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialPackageAgreedPrice",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SpecialPackageQuantity",
                table: "Reservations");
        }
    }
}
