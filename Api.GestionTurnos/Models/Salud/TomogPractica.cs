using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TomogPractica
    {
        public TomogPractica()
        {
            ExternoTomografiaPracticas = new HashSet<ExternoTomografiaPractica>();
            TomogPracticaSolicituds = new HashSet<TomogPracticaSolicitud>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ExternoTomografiaPractica> ExternoTomografiaPracticas { get; set; }
        public virtual ICollection<TomogPracticaSolicitud> TomogPracticaSolicituds { get; set; }
    }
}
