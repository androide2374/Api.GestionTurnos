using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ExternoRayosXp
    {
        public ExternoRayosXp()
        {
            ExternoRayosPracticas = new HashSet<ExternoRayosPractica>();
        }

        public Guid Orid { get; set; }
        public string ObservacionTecnico { get; set; }
        public Guid IdPaciente { get; set; }
        public long IdUsuario { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<ExternoRayosPractica> ExternoRayosPracticas { get; set; }
    }
}
