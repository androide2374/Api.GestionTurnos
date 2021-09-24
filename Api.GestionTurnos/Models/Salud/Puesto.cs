using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Puesto
    {
        public Puesto()
        {
            FichaIngresos = new HashSet<FichaIngreso>();
            Llamadors = new HashSet<Llamador>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public int Numero { get; set; }
        public Guid IdArea { get; set; }

        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
        public virtual ICollection<Llamador> Llamadors { get; set; }
    }
}
