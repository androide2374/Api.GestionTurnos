using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class UserArea
    {
        public Guid Orid { get; set; }
        public long UserId { get; set; }

        public virtual Area Or { get; set; }
        public virtual User User { get; set; }
    }
}
