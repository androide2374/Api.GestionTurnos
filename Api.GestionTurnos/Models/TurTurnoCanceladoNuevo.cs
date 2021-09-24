using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurTurnoCanceladoNuevo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Registrado { get; set; }
        public DateTime? Confirmado { get; set; }
        public int IdJunta { get; set; }
        public int IdTipoTurno { get; set; }
        public int IdStatus { get; set; }
        public int IdStatusProtocolo { get; set; }
        public int IdPersona { get; set; }
        public string Observacion { get; set; }
        public DateTime Cancelado { get; set; }
        public string ObservacionJun { get; set; }
        public bool? ConsultaFinalizada { get; set; }
    }
}
