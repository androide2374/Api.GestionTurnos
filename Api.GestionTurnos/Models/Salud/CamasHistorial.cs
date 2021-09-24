using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class CamasHistorial
    {
        public Guid Orid { get; set; }
        public Guid IdCama { get; set; }
        public Guid IdPaciente { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Salida { get; set; }

        public virtual Cama IdCamaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
