using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SelectedTransportOptionReservationCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTransportOptions_TransportOptions_TransportOptionId",
                table: "ReservationTransportOptions");

            migrationBuilder.RenameColumn(
                name: "TransportOptionId",
                table: "ReservationTransportOptions",
                newName: "SelectedTransportOptionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationTransportOptions_TransportOptionId",
                table: "ReservationTransportOptions",
                newName: "IX_ReservationTransportOptions_SelectedTransportOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTransportOptions_SelectedTransportOptions_SelectedTransportOptionId",
                table: "ReservationTransportOptions",
                column: "SelectedTransportOptionId",
                principalTable: "SelectedTransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationTransportOptions_SelectedTransportOptions_SelectedTransportOptionId",
                table: "ReservationTransportOptions");

            migrationBuilder.RenameColumn(
                name: "SelectedTransportOptionId",
                table: "ReservationTransportOptions",
                newName: "TransportOptionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationTransportOptions_SelectedTransportOptionId",
                table: "ReservationTransportOptions",
                newName: "IX_ReservationTransportOptions_TransportOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationTransportOptions_TransportOptions_TransportOptionId",
                table: "ReservationTransportOptions",
                column: "TransportOptionId",
                principalTable: "TransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
