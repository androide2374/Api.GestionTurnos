using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarInsumo
    {
        public FarInsumo()
        {
            FarPrescipcionDets = new HashSet<FarPrescipcionDet>();
            FarRemitoDets = new HashSet<FarRemitoDet>();
            FarStocks = new HashSet<FarStock>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdContenido { get; set; }
        public Guid? IdEmpaque { get; set; }
        public string CodigoBarras { get; set; }
        public string Indicaciones { get; set; }
        public string ContraIndicaciones { get; set; }
        public string InformacionAlergicos { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual FarContenido IdContenidoNavigation { get; set; }
        public virtual FarEmpaque IdEmpaqueNavigation { get; set; }
        public virtual ICollection<FarPrescipcionDet> FarPrescipcionDets { get; set; }
        public virtual ICollection<FarRemitoDet> FarRemitoDets { get; set; }
        public virtual ICollection<FarStock> FarStocks { get; set; }
    }
}
