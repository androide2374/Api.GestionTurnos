using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoRecepcion
    {
        public TipoRecepcion()
        {
            Areas = new HashSet<Area>();
            FichaIngresos = new HashSet<FichaIngreso>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public Guid IdEntidad { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
    }
}
