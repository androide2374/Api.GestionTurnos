using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Rol
    {
        public Rol()
        {
            RolRules = new HashSet<RolRule>();
            UserRols = new HashSet<UserRol>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<RolRule> RolRules { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}
