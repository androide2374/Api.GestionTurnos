using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarInsumosVinculado
    {
        public Guid? IdInsumoPrincipal { get; set; }
        public Guid? IdInsumoRequerido { get; set; }
        public decimal? Cantidad { get; set; }

        public virtual FarInsumo IdInsumoPrincipalNavigation { get; set; }
        public virtual FarInsumo IdInsumoRequeridoNavigation { get; set; }
    }
}
