using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Rol
    {
        public Rol()
        {
            RolRules = new HashSet<RolRule>();
            UserRols = new HashSet<UserRol>();
        }

        public long RolId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<RolRule> RolRules { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}
