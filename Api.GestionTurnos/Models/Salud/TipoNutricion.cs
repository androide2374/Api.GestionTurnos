using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoNutricion
    {
        public TipoNutricion()
        {
            Internaciones = new HashSet<Internacione>();
            UtiCes = new HashSet<UtiCe>();
            Utis = new HashSet<Uti>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Internacione> Internaciones { get; set; }
        public virtual ICollection<UtiCe> UtiCes { get; set; }
        public virtual ICollection<Uti> Utis { get; set; }
    }
}
