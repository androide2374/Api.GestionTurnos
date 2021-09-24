using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class RolRule
    {
        public int RuleId { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Rule Rule { get; set; }
    }
}
