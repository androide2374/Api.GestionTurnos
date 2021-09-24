using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Rule
    {
        public Rule()
        {
            RolRules = new HashSet<RolRule>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Definicion { get; set; }

        public virtual ICollection<RolRule> RolRules { get; set; }
    }
}
