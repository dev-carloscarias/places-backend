using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAdults = table.Column<int>(type: "int", nullable: false),
                    AdultAgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalChildren = table.Column<int>(type: "int", nullable: false),
                    ChildAgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    ReservationState = table.Column<int>(type: "int", nullable: false),
                    ReservationPaymentType = table.Column<int>(type: "int", nullable: false),
                    SpecialPackageId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_SpecialPackage_SpecialPackageId",
                        column: x => x.SpecialPackageId,
                        principalTable: "SpecialPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationAdditionalCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalCostId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationAdditionalCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationAdditionalCosts_AdditionalCost_AdditionalCostId",
                        column: x => x.AdditionalCostId,
                        principalTable: "AdditionalCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationAdditionalCosts_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationTransferState = table.Column<int>(type: "int", nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationTransfers_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationTransportOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AgreedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransportOptionId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_ReservationTransportOptions_TransportOptions_TransportOptionId",
                        column: x => x.TransportOptionId,
                        principalTable: "TransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationAdditionalCosts_AdditionalCostId",
                table: "ReservationAdditionalCosts",
                column: "AdditionalCostId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationAdditionalCosts_ReservationId",
                table: "ReservationAdditionalCosts",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SiteId",
                table: "Reservations",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SpecialPackageId",
                table: "Reservations",
                column: "SpecialPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTransfers_ReservationId",
                table: "ReservationTransfers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTransportOptions_ReservationId",
                table: "ReservationTransportOptions",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTransportOptions_TransportOptionId",
                table: "ReservationTransportOptions",
                column: "TransportOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationAdditionalCosts");

            migrationBuilder.DropTable(
                name: "ReservationTransfers");

            migrationBuilder.DropTable(
                name: "ReservationTransportOptions");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
