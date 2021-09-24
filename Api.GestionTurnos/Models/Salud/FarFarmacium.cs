using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarFarmacium
    {
        public FarFarmacium()
        {
            FarStocks = new HashSet<FarStock>();
            InverseParentNavigation = new HashSet<FarFarmacium>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Piso { get; set; }
        public string Sector { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdEnte { get; set; }
        public Guid? Parent { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
        public virtual FarFarmacium ParentNavigation { get; set; }
        public virtual ICollection<FarStock> FarStocks { get; set; }
        public virtual ICollection<FarFarmacium> InverseParentNavigation { get; set; }
    }
}
