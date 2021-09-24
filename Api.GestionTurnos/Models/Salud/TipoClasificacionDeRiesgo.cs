using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoClasificacionDeRiesgo
    {
        public TipoClasificacionDeRiesgo()
        {
            ClasificacionDeRiesgoHistorials = new HashSet<ClasificacionDeRiesgoHistorial>();
        }

        public Guid Orid { get; set; }
        public int Nivel { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int TiempoDeAtencion { get; set; }

        public virtual ICollection<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
    }
}
