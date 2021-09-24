using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class GlasgowHistorico
    {
        public Guid Orid { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdRespuestaGlasgow { get; set; }
        public Guid IdVariablesGlasgow { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
