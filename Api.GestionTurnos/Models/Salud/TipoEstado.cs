using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoEstado
    {
        public TipoEstado()
        {
            Derivacions = new HashSet<Derivacion>();
            EstadoHistorials = new HashSet<EstadoHistorial>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public bool? AplicaEgreso { get; set; }

        public virtual ICollection<Derivacion> Derivacions { get; set; }
        public virtual ICollection<EstadoHistorial> EstadoHistorials { get; set; }
    }
}
