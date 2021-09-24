using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarRemitoDet
    {
        public Guid Orid { get; set; }
        public Guid? IdRemito { get; set; }
        public Guid? IdInsumo { get; set; }
        public int Cantidad { get; set; }

        public virtual FarInsumo IdInsumoNavigation { get; set; }
        public virtual FarRemitoCab IdRemitoNavigation { get; set; }
    }
}
