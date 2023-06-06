using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace AutomobiliWebAplikacija.Models
{ 
    public class AppDbContext : IdentityDbContext<IdentityUser>
{

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Automobil> Automobil { get; set; }
    public DbSet<Kategorija> Kategorija { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Automobil>().Property(f => f.Cijena).HasPrecision(10, 2);

        modelBuilder.Entity<Kategorija>().HasData(
            new Kategorija() { Id = 1, Naziv = "Karavan" },
            new Kategorija() { Id = 2, Naziv = "Limuzina" },
            new Kategorija() { Id = 3, Naziv = "Coupe" },
            new Kategorija() { Id = 4, Naziv = "Terenac" },
            new Kategorija() { Id = 5, Naziv = "Crossover" });

            modelBuilder.Entity<Automobil>().HasData(
               new Automobil() { Id = 1, Naziv = "Mercedes-Benz C-klasa T-model 220 d T", Cijena = 24.000m, GodinaProizvodnje = int.Parse("2015"), SlikaUrl = "https://www.njuskalo.hr/image-w920x690/auti/mercedes-benz-c-klasa-t-model-220-d-t-amg-automatik-slika-118786932.jpg", KategorijaId = 1 },
               new Automobil() { Id = 2, Naziv = "Audi A4 2.0 TDI ULTRA", Cijena = 20.000m, GodinaProizvodnje = int.Parse("2016"), SlikaUrl = "https://www.motoringresearch.com/wp-content/uploads/2015/10/01_Audi_A4_20_TDI_ultra_SE_2015.jpg", KategorijaId = 2 },
               new Automobil() { Id = 3, Naziv = "BMW serija 3 Coupe 320Cd", Cijena = 9.400m, GodinaProizvodnje = int.Parse("2009"), SlikaUrl = "https://www.njuskalo.hr/image-w920x690/auti/bmw-serija-3-coupe-320cd-slika-138187914.jpg", KategorijaId = 3 },
               new Automobil() { Id = 4, Naziv = "JEEP GRAND CHEROKEE 3.0 CRD SUMMIT AT8", Cijena = 85.000m, GodinaProizvodnje = int.Parse("2021"), SlikaUrl = "https://www.njuskalo.hr/image-w920x690/auti/jeep-grand-cherokee-3.0-crd-slika-158986632.jpg", KategorijaId = 4 },
               new Automobil() { Id = 5, Naziv = "Opel Crossland X 1,5 cdti ", Cijena = 14.400m, GodinaProizvodnje = int.Parse("2019"), SlikaUrl = "https://www.njuskalo.hr/image-w920x690/auti/opel-crossland-x-1.5-cdti-innovation-slika-190791989.jpg", KategorijaId = 5 }
               );
          }
    }
}
