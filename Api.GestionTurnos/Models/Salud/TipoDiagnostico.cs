using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoDiagnostico
    {
        public TipoDiagnostico()
        {
            Diagnosticos = new HashSet<Diagnostico>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Diagnostico> Diagnosticos { get; set; }
    }
}
