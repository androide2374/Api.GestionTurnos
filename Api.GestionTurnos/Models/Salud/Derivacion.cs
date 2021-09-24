using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Derivacion
    {
        public Derivacion()
        {
            EstadoHistorials = new HashSet<EstadoHistorial>();
        }

        public Guid Orid { get; set; }
        public Guid IdAreaOrigen { get; set; }
        public string DescAreaOrigen { get; set; }
        public Guid IdAreaDestino { get; set; }
        public string DescAreaDestino { get; set; }
        public Guid IdTipoEstado { get; set; }
        public bool? AplicaLista { get; set; }
        public Guid IdEnte { get; set; }

        public virtual Area IdAreaDestinoNavigation { get; set; }
        public virtual Area IdAreaOrigenNavigation { get; set; }
        public virtual Ente IdEnteNavigation { get; set; }
        public virtual TipoEstado IdTipoEstadoNavigation { get; set; }
        public virtual ICollection<EstadoHistorial> EstadoHistorials { get; set; }
    }
}
