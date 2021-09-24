using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurDiasEspeciale
    {
        public Guid Orid { get; set; }
        public Guid IdEnte { get; set; }
        public long IdUser { get; set; }
        public Guid IdTipoAtencion { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
