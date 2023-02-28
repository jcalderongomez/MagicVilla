using MagicVillage_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVillage_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<NumeroVilla> NumeroVillas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre= "Villa Real",
                    Detalle= "Detalle de la Villa...",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=90,
                    Tarifa=200,
                    Amenidad="",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion= DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Calderon",
                    Detalle = "Detalle de la Villa Calderon",
                    ImagenUrl = "",
                    Ocupantes = 6,
                    MetrosCuadrados = 190,
                    Tarifa = 2000,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );
        }

    }
}
