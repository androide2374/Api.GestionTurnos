using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurStatus
    {
        public TurStatus()
        {
            TurTurnos = new HashSet<TurTurno>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TurTurno> TurTurnos { get; set; }
    }
}
