using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarPresentacion
    {
        public FarPresentacion()
        {
            FarEmpaques = new HashSet<FarEmpaque>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public decimal? CapacidadValue { get; set; }
        public Guid? IdCapacidad { get; set; }

        public virtual FarCapacidad IdCapacidadNavigation { get; set; }
        public virtual ICollection<FarEmpaque> FarEmpaques { get; set; }
    }
}
