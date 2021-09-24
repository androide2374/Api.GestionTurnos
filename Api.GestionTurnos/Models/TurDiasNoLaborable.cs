using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurDiasNoLaborable
    {
        public int Id { get; set; }
        public int IdEnte { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public long? IdUser { get; set; }
    }
}
