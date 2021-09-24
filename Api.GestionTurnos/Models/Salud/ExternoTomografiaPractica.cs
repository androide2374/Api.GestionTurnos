using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoTomografiaPractica
    {
        public Guid IdExterno { get; set; }
        public Guid IdPractica { get; set; }

        public virtual ExternoTomografiaP IdExternoNavigation { get; set; }
        public virtual TomogPractica IdPracticaNavigation { get; set; }
    }
}
