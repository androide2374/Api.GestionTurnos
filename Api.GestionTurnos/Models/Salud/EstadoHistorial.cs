using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class EstadoHistorial
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public Guid IdTipoEstado { get; set; }
        public Guid? IdPaciente { get; set; }
        public Guid? IdDerivacion { get; set; }

        public virtual Derivacion IdDerivacionNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual TipoEstado IdTipoEstadoNavigation { get; set; }
    }
}
