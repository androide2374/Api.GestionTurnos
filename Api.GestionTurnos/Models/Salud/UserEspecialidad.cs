using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class UserEspecialidad
    {
        public long UserId { get; set; }
        public Guid IdEspecialidad { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
