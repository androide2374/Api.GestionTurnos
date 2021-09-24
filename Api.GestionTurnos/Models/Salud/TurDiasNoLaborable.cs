using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurDiasNoLaborable
    {
        public Guid Orid { get; set; }
        public Guid IdEnte { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public long? IdUser { get; set; }
        public DateTime? Registro { get; set; }
        public long? UserIdCarga { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
    }
}
