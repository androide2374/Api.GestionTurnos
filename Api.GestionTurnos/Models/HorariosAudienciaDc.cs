using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class HorariosAudienciaDc
    {
        public int Id { get; set; }
        public int IdEnte { get; set; }
        public long IdUser { get; set; }
        public int IdEspecialidad { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan Desde { get; set; }
        public TimeSpan Hasta { get; set; }
        public int Cupos { get; set; }
        public bool EsDiaEspecial { get; set; }
        public int? DuracionTurno { get; set; }
    }
}
