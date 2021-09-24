using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TerapiaEnfermerium
    {
        public Guid Orid { get; set; }
        public Guid IdIndicaciones { get; set; }
        public DateTime FechaHora { get; set; }
        public string Observacion { get; set; }
        public long? IdUsuario { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }
        public int? Hgt { get; set; }
        public int? PresionAlta { get; set; }
        public int? PresionBaja { get; set; }
        public int? Saturacion { get; set; }
        public decimal? Temperatura { get; set; }

        public virtual Indicacione IdIndicacionesNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
