﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Nombre { get; set; }
        public String Detalle{ get; set; }

        [Required]
        public double Tarifa{ get; set; }

        public int Ocupantes { get; set; }

        public double MetrosCuadrados { get; set; }

        public String ImagenUrl { get; set; }

        public String Amenidad { get; set; }
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }


}
