using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoTomografiaP
    {
        public ExternoTomografiaP()
        {
            ExternoTomografiaPracticas = new HashSet<ExternoTomografiaPractica>();
        }

        public Guid Orid { get; set; }
        public string ObservacionTecnico { get; set; }
        public Guid IdPaciente { get; set; }
        public long IdUsuario { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<ExternoTomografiaPractica> ExternoTomografiaPracticas { get; set; }
    }
}
