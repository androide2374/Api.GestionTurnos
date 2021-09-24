using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurTurnoNoConfirmado
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public DateTime Registrado { get; set; }
        public DateTime? Confirmado { get; set; }
        public bool? Presente { get; set; }
        public DateTime? FechaPresente { get; set; }
        public int IdDedicacion { get; set; }
        public int IdTipoTurno { get; set; }
        public int IdStatus { get; set; }
        public int IdPersona { get; set; }
        public string Observacion { get; set; }
    }
}
