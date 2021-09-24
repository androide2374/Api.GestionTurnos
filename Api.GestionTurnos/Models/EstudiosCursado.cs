using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class EstudiosCursado
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Titulo { get; set; }
        public int? AñoEgreso { get; set; }
        public string Escuela { get; set; }
        public string Distrito { get; set; }
        public DateTime? FechaLegalizado { get; set; }
        public string NumeroRegistro { get; set; }
        public int? RcescolarNturno { get; set; }
    }
}
