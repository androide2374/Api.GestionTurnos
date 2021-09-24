using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoElectrocardiograma
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public Guid IdPaciente { get; set; }
        public long IdUsuario { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
