using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class bvonbp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");
        }
    }
}
