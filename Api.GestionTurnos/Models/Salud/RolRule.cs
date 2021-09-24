using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class RolRule
    {
        public int RuleId { get; set; }
        public long RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Rule Rule { get; set; }
    }
}
