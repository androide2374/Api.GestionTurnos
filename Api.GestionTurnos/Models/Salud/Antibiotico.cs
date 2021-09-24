using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Antibiotico
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string Droga { get; set; }
        public Guid? IdVia { get; set; }
        public string Dosis { get; set; }
        public DateTime? Suspendido { get; set; }
        public long IdUsuario { get; set; }
        public Guid IdArea { get; set; }
        public Guid IdPaciente { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual Vium IdViaNavigation { get; set; }
    }
}
