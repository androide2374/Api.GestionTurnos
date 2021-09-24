using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class LaboratorioPractica
    {
        public LaboratorioPractica()
        {
            ExternoLaboratorioPracticas = new HashSet<ExternoLaboratorioPractica>();
            LaboratorioPracticaSolicituds = new HashSet<LaboratorioPracticaSolicitud>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ExternoLaboratorioPractica> ExternoLaboratorioPracticas { get; set; }
        public virtual ICollection<LaboratorioPracticaSolicitud> LaboratorioPracticaSolicituds { get; set; }
    }
}
