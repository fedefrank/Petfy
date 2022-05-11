using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petfy.Data.Migrations
{
    public partial class AddPetVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Pets_PetsID",
                table: "PetVaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccinesID",
                table: "PetVaccine");

            migrationBuilder.RenameColumn(
                name: "VaccinesID",
                table: "PetVaccine",
                newName: "VaccineID");

            migrationBuilder.RenameColumn(
                name: "PetsID",
                table: "PetVaccine",
                newName: "PetID");

            migrationBuilder.RenameIndex(
                name: "IX_PetVaccine_VaccinesID",
                table: "PetVaccine",
                newName: "IX_PetVaccine_VaccineID");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateApplied",
                table: "PetVaccine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Pets_PetID",
                table: "PetVaccine",
                column: "PetID",
                principalTable: "Pets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccineID",
                table: "PetVaccine",
                column: "VaccineID",
                principalTable: "Vaccines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Pets_PetID",
                table: "PetVaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccineID",
                table: "PetVaccine");

            migrationBuilder.DropColumn(
                name: "DateApplied",
                table: "PetVaccine");

            migrationBuilder.RenameColumn(
                name: "VaccineID",
                table: "PetVaccine",
                newName: "VaccinesID");

            migrationBuilder.RenameColumn(
                name: "PetID",
                table: "PetVaccine",
                newName: "PetsID");

            migrationBuilder.RenameIndex(
                name: "IX_PetVaccine_VaccineID",
                table: "PetVaccine",
                newName: "IX_PetVaccine_VaccinesID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Pets_PetsID",
                table: "PetVaccine",
                column: "PetsID",
                principalTable: "Pets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PetVaccine_Vaccines_VaccinesID",
                table: "PetVaccine",
                column: "VaccinesID",
                principalTable: "Vaccines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
