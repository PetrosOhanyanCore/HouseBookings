using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Translation_DescriptionId",
                table: "Apartment");

            migrationBuilder.RenameColumn(
                name: "DescriptionId",
                table: "Apartment",
                newName: "TranslationId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_DescriptionId",
                table: "Apartment",
                newName: "IX_Apartment_TranslationId");

            migrationBuilder.AddColumn<int>(
                name: "TranslationId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TranslationId",
                table: "Building",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_TranslationId",
                table: "Client",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_TranslationId",
                table: "Building",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_DescriptionId",
                table: "Booking",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Translation_TranslationId",
                table: "Apartment",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Translation_DescriptionId",
                table: "Booking",
                column: "DescriptionId",
                principalTable: "Translation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Translation_TranslationId",
                table: "Building",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Translation_TranslationId",
                table: "Client",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Translation_TranslationId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Translation_DescriptionId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_Translation_TranslationId",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Translation_TranslationId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_TranslationId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Building_TranslationId",
                table: "Building");

            migrationBuilder.DropIndex(
                name: "IX_Booking_DescriptionId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TranslationId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TranslationId",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "TranslationId",
                table: "Apartment",
                newName: "DescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_TranslationId",
                table: "Apartment",
                newName: "IX_Apartment_DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Translation_DescriptionId",
                table: "Apartment",
                column: "DescriptionId",
                principalTable: "Translation",
                principalColumn: "Id");
        }
    }
}
