using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomobiliWebAplikacija.Migrations
{
    public partial class InicijalnaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobili");

            migrationBuilder.CreateTable(
                name: "Automobil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    SlikaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automobil_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Automobil",
                columns: new[] { "Id", "Cijena", "GodinaProizvodnje", "KategorijaId", "Naziv", "SlikaUrl" },
                values: new object[,]
                {
                    { 1, 24.000m, 2015, 1, "Mercedes-Benz C-klasa T-model 220 d T", "https://www.njuskalo.hr/image-w920x690/auti/mercedes-benz-c-klasa-t-model-220-d-t-amg-automatik-slika-118786932.jpg" },
                    { 2, 20.000m, 2016, 2, "Audi A4 2.0 TDI ULTRA", "https://www.motoringresearch.com/wp-content/uploads/2015/10/01_Audi_A4_20_TDI_ultra_SE_2015.jpg" },
                    { 3, 9.400m, 2009, 3, "BMW serija 3 Coupe 320Cd", "https://www.njuskalo.hr/image-w920x690/auti/bmw-serija-3-coupe-320cd-slika-138187914.jpg" },
                    { 4, 85.000m, 2021, 4, "JEEP GRAND CHEROKEE 3.0 CRD SUMMIT AT8", "https://www.njuskalo.hr/image-w920x690/auti/jeep-grand-cherokee-3.0-crd-slika-158986632.jpg" },
                    { 5, 14.400m, 2019, 5, "Opel Crossland X 1,5 cdti ", "https://www.njuskalo.hr/image-w920x690/auti/opel-crossland-x-1.5-cdti-innovation-slika-190791989.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobil_KategorijaId",
                table: "Automobil",
                column: "KategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobil");

            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlikaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automobili_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Automobili",
                columns: new[] { "Id", "Cijena", "GodinaProizvodnje", "KategorijaId", "Naziv", "SlikaUrl" },
                values: new object[,]
                {
                    { 1, 24.000m, 2015, 1, "Mercedes-Benz C-klasa T-model 220 d T", "https://www.njuskalo.hr/image-w920x690/auti/mercedes-benz-c-klasa-t-model-220-d-t-amg-automatik-slika-118786932.jpg" },
                    { 2, 20.000m, 2016, 2, "Audi A4 2.0 TDI ULTRA", "https://www.motoringresearch.com/wp-content/uploads/2015/10/01_Audi_A4_20_TDI_ultra_SE_2015.jpg" },
                    { 3, 9.400m, 2009, 3, "BMW serija 3 Coupe 320Cd", "https://www.njuskalo.hr/image-w920x690/auti/bmw-serija-3-coupe-320cd-slika-138187914.jpg" },
                    { 4, 85.000m, 2021, 4, "JEEP GRAND CHEROKEE 3.0 CRD SUMMIT AT8", "https://www.njuskalo.hr/image-w920x690/auti/jeep-grand-cherokee-3.0-crd-slika-158986632.jpg" },
                    { 5, 14.400m, 2019, 5, "Opel Crossland X 1,5 cdti ", "https://www.njuskalo.hr/image-w920x690/auti/opel-crossland-x-1.5-cdti-innovation-slika-190791989.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobili_KategorijaId",
                table: "Automobili",
                column: "KategorijaId");
        }
    }
}
