using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Llamador
    {
        public Guid Orid { get; set; }
        public Guid IdPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public Guid IdPuesto { get; set; }
        public bool? Valor { get; set; }
        public bool? EsExterno { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Puesto IdPuestoNavigation { get; set; }
    }
}
