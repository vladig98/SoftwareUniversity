using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusTicketsSystem.Data.Migrations
{
    public partial class AddingArrivedTripsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArrivedTrips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualArrivalTime = table.Column<DateTime>(nullable: false),
                    OriginBusStationId = table.Column<int>(nullable: false),
                    DestinationBusStationId = table.Column<int>(nullable: false),
                    PassengersCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrivedTrips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArrivedTrips_BusStations_DestinationBusStationId",
                        column: x => x.DestinationBusStationId,
                        principalTable: "BusStations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArrivedTrips_BusStations_OriginBusStationId",
                        column: x => x.OriginBusStationId,
                        principalTable: "BusStations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArrivedTrips_DestinationBusStationId",
                table: "ArrivedTrips",
                column: "DestinationBusStationId");

            migrationBuilder.CreateIndex(
                name: "IX_ArrivedTrips_OriginBusStationId",
                table: "ArrivedTrips",
                column: "OriginBusStationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArrivedTrips");
        }
    }
}
