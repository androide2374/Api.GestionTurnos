using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class UserRol
    {
        public int RolId { get; set; }
        public int UserId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual User User { get; set; }
    }
}
