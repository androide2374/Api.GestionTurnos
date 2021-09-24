using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class EnteEspecialidad
    {
        public int IdEspecialidad { get; set; }
        public int IdEnte { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; }
    }
}
