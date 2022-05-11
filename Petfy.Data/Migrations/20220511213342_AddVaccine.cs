using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petfy.Data.Migrations
{
    public partial class AddVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lab = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PetVaccine",
                columns: table => new
                {
                    PetsID = table.Column<int>(type: "int", nullable: false),
                    VaccinesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetVaccine", x => new { x.PetsID, x.VaccinesID });
                    table.ForeignKey(
                        name: "FK_PetVaccine_Pets_PetsID",
                        column: x => x.PetsID,
                        principalTable: "Pets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetVaccine_Vaccines_VaccinesID",
                        column: x => x.VaccinesID,
                        principalTable: "Vaccines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetVaccine_VaccinesID",
                table: "PetVaccine",
                column: "VaccinesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetVaccine");

            migrationBuilder.DropTable(
                name: "Vaccines");
        }
    }
}
