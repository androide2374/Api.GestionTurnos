using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurTurnoBk
    {
        public Guid Orid { get; set; }
        public DateTime FechaHora { get; set; }
        public DateTime Registrado { get; set; }
        public DateTime? Confirmado { get; set; }
        public bool? Presente { get; set; }
        public DateTime? FechaPresente { get; set; }
        public Guid IdDedicacion { get; set; }
        public Guid IdTipoTurno { get; set; }
        public Guid IdStatus { get; set; }
        public Guid IdPersona { get; set; }
        public Guid? TipoVacunacion { get; set; }
    }
}
