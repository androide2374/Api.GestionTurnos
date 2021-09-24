using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Transparencium
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdAreaTematica { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? Contestado { get; set; }
    }
}
