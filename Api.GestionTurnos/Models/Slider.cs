using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Slider
    {
        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public string Imagen { get; set; }
        public string ImagenXs { get; set; }
        public bool? Target { get; set; }
        public int Orden { get; set; }
        public bool Habilitado { get; set; }
        public DateTime? FechaHabilitado { get; set; }
        public DateTime FechaActivoD { get; set; }
        public DateTime FechaActivoH { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
