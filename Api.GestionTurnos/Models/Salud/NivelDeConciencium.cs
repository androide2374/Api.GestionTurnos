using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class NivelDeConciencium
    {
        public NivelDeConciencium()
        {
            ClasificacionDeRiesgoHistorials = new HashSet<ClasificacionDeRiesgoHistorial>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
    }
}
