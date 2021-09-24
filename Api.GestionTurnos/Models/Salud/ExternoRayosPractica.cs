using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoRayosPractica
    {
        public Guid IdExterno { get; set; }
        public Guid IdPractica { get; set; }

        public virtual ExternoRayosXp IdExternoNavigation { get; set; }
        public virtual RxPractica IdPracticaNavigation { get; set; }
    }
}
