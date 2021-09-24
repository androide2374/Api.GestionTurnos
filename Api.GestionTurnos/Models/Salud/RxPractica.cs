using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class RxPractica
    {
        public RxPractica()
        {
            ExternoRayosPracticas = new HashSet<ExternoRayosPractica>();
            RxPracticaSolicituds = new HashSet<RxPracticaSolicitud>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ExternoRayosPractica> ExternoRayosPracticas { get; set; }
        public virtual ICollection<RxPracticaSolicitud> RxPracticaSolicituds { get; set; }
    }
}
