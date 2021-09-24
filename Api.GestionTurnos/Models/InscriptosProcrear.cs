using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class InscriptosProcrear
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string IngresosAproximados { get; set; }
        public DateTime FechaAlta { get; set; }
        public int IdStatus { get; set; }
        public DateTime? BajaLogica { get; set; }
        public DateTime? FechaAprobado { get; set; }
    }
}
