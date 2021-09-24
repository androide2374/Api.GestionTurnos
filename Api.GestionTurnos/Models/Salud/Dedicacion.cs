using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Dedicacion
    {
        public Guid Orid { get; set; }
        public Guid IdEnte { get; set; }
        public long IdUser { get; set; }
        public Guid IdTipoAtencion { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan Desde { get; set; }
        public TimeSpan Hasta { get; set; }
        public int DuracionBloqueHorario { get; set; }
        public int AtencionesPorBloqueHorario { get; set; }
        public int TopeAtencionesDiarias { get; set; }
        public string GrupoAtencionSimultanea { get; set; }
        public DateTime? BajaLogica { get; set; }
        public bool? EsEspecial { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
