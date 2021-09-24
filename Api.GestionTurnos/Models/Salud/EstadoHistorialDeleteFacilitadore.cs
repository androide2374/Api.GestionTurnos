using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class EstadoHistorialDeleteFacilitadore
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public Guid IdTipoEstado { get; set; }
        public Guid? IdPaciente { get; set; }
        public Guid? IdDerivacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public long? IdUser { get; set; }
    }
}
