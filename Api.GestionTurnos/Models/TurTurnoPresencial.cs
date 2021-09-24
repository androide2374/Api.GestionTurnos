using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurTurnoPresencial
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdHorario { get; set; }
        public int IdTipoTurno { get; set; }
        public int IdPersona { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdStatus { get; set; }
    }
}
