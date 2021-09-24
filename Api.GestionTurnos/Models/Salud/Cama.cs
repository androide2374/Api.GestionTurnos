using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Cama
    {
        public Cama()
        {
            CamasHistorials = new HashSet<CamasHistorial>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdArea { get; set; }
        public Guid? IdEstado { get; set; }
        public bool? Activa { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual CamaEstado IdEstadoNavigation { get; set; }
        public virtual ICollection<CamasHistorial> CamasHistorials { get; set; }
    }
}
