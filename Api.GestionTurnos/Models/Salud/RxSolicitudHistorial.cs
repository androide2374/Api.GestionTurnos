using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class RxSolicitudHistorial
    {
        public RxSolicitudHistorial()
        {
            RxPracticaSolicituds = new HashSet<RxPracticaSolicitud>();
        }

        public Guid Orid { get; set; }
        public Guid IdPaciente { get; set; }
        public string ObservacionMedico { get; set; }
        public string ObservacionTecnico { get; set; }
        public long IdUsuario { get; set; }
        public bool? Realizado { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<RxPracticaSolicitud> RxPracticaSolicituds { get; set; }
    }
}
