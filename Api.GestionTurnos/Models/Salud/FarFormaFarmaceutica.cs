using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarFormaFarmaceutica
    {
        public FarFormaFarmaceutica()
        {
            FarEmpaques = new HashSet<FarEmpaque>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual ICollection<FarEmpaque> FarEmpaques { get; set; }
    }
}
