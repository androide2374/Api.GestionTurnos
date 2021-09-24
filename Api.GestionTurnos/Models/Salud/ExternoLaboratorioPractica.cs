using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoLaboratorioPractica
    {
        public Guid IdExterno { get; set; }
        public Guid IdPractica { get; set; }

        public virtual ExternoLaboratorioP IdExternoNavigation { get; set; }
        public virtual LaboratorioPractica IdPracticaNavigation { get; set; }
    }
}
