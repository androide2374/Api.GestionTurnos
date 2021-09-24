using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarCapacidad
    {
        public FarCapacidad()
        {
            FarPresentacions = new HashSet<FarPresentacion>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual ICollection<FarPresentacion> FarPresentacions { get; set; }
    }
}
