using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class botn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Apartment_PropertyId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Building_BuildingId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoring_Translation_TranslationId",
                table: "Scoring");

            migrationBuilder.DropIndex(
                name: "IX_Image_BuildingId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_PropertyId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "IsApartment",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "IsBuilding",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "IsClient",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Image");

            migrationBuilder.AlterColumn<int>(
                name: "TranslationId",
                table: "Scoring",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "Scoring",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Scoring",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentId",
                table: "Scoring",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Scoring",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Scoring",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CardOwner",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Image",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scoring_ApartmentId",
                table: "Scoring",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Scoring_BuildingId",
                table: "Scoring",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Scoring_ClientId",
                table: "Scoring",
                column: "ClientId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Scoring_Apartment_ApartmentId",
                table: "Scoring",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scoring_Building_BuildingId",
                table: "Scoring",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scoring_Client_ClientId",
                table: "Scoring",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scoring_Translation_TranslationId",
                table: "Scoring",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoring_Apartment_ApartmentId",
                table: "Scoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoring_Building_BuildingId",
                table: "Scoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoring_Client_ClientId",
                table: "Scoring");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoring_Translation_TranslationId",
                table: "Scoring");

            migrationBuilder.DropIndex(
                name: "IX_Scoring_ApartmentId",
                table: "Scoring");

            migrationBuilder.DropIndex(
                name: "IX_Scoring_BuildingId",
                table: "Scoring");

            migrationBuilder.DropIndex(
                name: "IX_Scoring_ClientId",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "ApartmentId",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Scoring");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Scoring");

            migrationBuilder.AlterColumn<int>(
                name: "TranslationId",
                table: "Scoring",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "Scoring",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Scoring",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApartment",
                table: "Scoring",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBuilding",
                table: "Scoring",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsClient",
                table: "Scoring",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyCode",
                table: "Payment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CardOwner",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Image",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_BuildingId",
                table: "Image",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PropertyId",
                table: "Image",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Apartment_PropertyId",
                table: "Image",
                column: "PropertyId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Building_BuildingId",
                table: "Image",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Apartment_ApartmentId",
                table: "Options",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Building_BuildingId",
                table: "Options",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scoring_Translation_TranslationId",
                table: "Scoring",
                column: "TranslationId",
                principalTable: "Translation",
                principalColumn: "Id");
        }
    }
}
