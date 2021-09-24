using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ComoLlego
    {
        public ComoLlego()
        {
            FichaIngresos = new HashSet<FichaIngreso>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
    }
}
