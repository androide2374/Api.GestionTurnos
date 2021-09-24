using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class BonosAdmision
    {
        public Guid Orid { get; set; }
        public Guid? IdPersona { get; set; }
        public Guid? IdTipoBono { get; set; }
        public string Valor { get; set; }
        public string Numero { get; set; }
        public Guid? IdFichaIngreso { get; set; }
        public DateTime? Fecha { get; set; }
        public long? IdUsuario { get; set; }

        public virtual TipoBono IdTipoBonoNavigation { get; set; }
    }
}
