using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class JornadaEmergencium
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Ocupacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? Estado { get; set; }
        public string OcupacionInfo { get; set; }
        public int? IdFecha { get; set; }
    }
}
