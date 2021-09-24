using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarPrescipcionDet
    {
        public Guid Orid { get; set; }
        public Guid? IdPrescripcion { get; set; }
        public Guid? IdInsumo { get; set; }
        public int? Periodo { get; set; }
        public Guid? IdPeriodoUnidad { get; set; }
        public int? Cantidad { get; set; }
        public Guid? IdPeriodicidad { get; set; }

        public virtual FarInsumo IdInsumoNavigation { get; set; }
        public virtual FarPeriodicidad IdPeriodicidadNavigation { get; set; }
        public virtual FarPeriodoUnidad IdPeriodoUnidadNavigation { get; set; }
        public virtual FarPrescripcionCab IdPrescripcionNavigation { get; set; }
    }
}
