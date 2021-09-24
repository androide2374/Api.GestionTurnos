using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoEnte
    {
        public TipoEnte()
        {
            Entes = new HashSet<Ente>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ente> Entes { get; set; }
    }
}
