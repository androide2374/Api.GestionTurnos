using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class EnteEspecialidad
    {
        public Guid IdEspecialidad { get; set; }
        public Guid IdEnte { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
        public virtual Especialidad IdEspecialidadNavigation { get; set; }
    }
}
