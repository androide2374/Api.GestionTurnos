using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarEmpaque
    {
        public FarEmpaque()
        {
            FarInsumos = new HashSet<FarInsumo>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdFormaFarmaceutica { get; set; }
        public Guid? IdPresentacion { get; set; }

        public virtual FarFormaFarmaceutica IdFormaFarmaceuticaNavigation { get; set; }
        public virtual FarPresentacion IdPresentacionNavigation { get; set; }
        public virtual ICollection<FarInsumo> FarInsumos { get; set; }
    }
}
