using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class UserRol
    {
        public long RolId { get; set; }
        public long UserId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual User User { get; set; }
    }
}
