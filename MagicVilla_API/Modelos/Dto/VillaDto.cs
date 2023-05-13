using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public String Nombre { get; set; }
        public String Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public double MetrosCuadrados { get; set; }

        public String ImagenUrl { get; set; }

        public String Amenidad { get; set; }
    }
}
