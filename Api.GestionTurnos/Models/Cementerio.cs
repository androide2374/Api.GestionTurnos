using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Cementerio
    {
        public int Id { get; set; }
        public int? IdTitular { get; set; }
        public int? IdCotitular { get; set; }
        public string TipoRenovacion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Archivo4 { get; set; }
        public string Archivo5 { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaEstado { get; set; }
    }
}
