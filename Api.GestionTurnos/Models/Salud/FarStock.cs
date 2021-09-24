using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarStock
    {
        public Guid Orid { get; set; }
        public Guid IdFarmacia { get; set; }
        public Guid IdInsumo { get; set; }
        public string Lote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string NroRemito { get; set; }
        public string OrdenCompra { get; set; }
        public Guid IdProveedor { get; set; }

        public virtual FarFarmacium IdFarmaciaNavigation { get; set; }
        public virtual FarInsumo IdInsumoNavigation { get; set; }
        public virtual FarProveedor IdProveedorNavigation { get; set; }
    }
}
