using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReservationSelectedTransportOptionCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationTransportOptions");

            migrationBuilder.CreateTable(
                name: "ReservationSelectedTransportOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SelectedTransportOptionId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationSelectedTransportOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationSelectedTransportOptions_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationSelectedTransportOptions_SelectedTransportOptions_SelectedTransportOptionId",
                        column: x => x.SelectedTransportOptionId,
                        principalTable: "SelectedTransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSelectedTransportOptions_ReservationId",
                table: "ReservationSelectedTransportOptions",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationSelectedTransportOptions_SelectedTransportOptionId",
                table: "ReservationSelectedTransportOptions",
                column: "SelectedTransportOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationSelectedTransportOptions");

            migrationBuilder.CreateTable(
                name: "ReservationTransportOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    SelectedTransportOptionId = table.Column<int>(type: "int", nullable: false),
                    AgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTransportOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationTransportOptions_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationTransportOptions_SelectedTransportOptions_SelectedTransportOptionId",
                        column: x => x.SelectedTransportOptionId,
                        principalTable: "SelectedTransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTransportOptions_ReservationId",
                table: "ReservationTransportOptions",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTransportOptions_SelectedTransportOptionId",
                table: "ReservationTransportOptions",
                column: "SelectedTransportOptionId");
        }
    }
}
