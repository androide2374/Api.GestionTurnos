using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurTipoTurno
    {
        public TurTipoTurno()
        {
            TurTurnos = new HashSet<TurTurno>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public bool RequiereValidacion { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual ICollection<TurTurno> TurTurnos { get; set; }
    }
}
