using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarPeriodoUnidad
    {
        public FarPeriodoUnidad()
        {
            FarPrescipcionDets = new HashSet<FarPrescipcionDet>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<FarPrescipcionDet> FarPrescipcionDets { get; set; }
    }
}
