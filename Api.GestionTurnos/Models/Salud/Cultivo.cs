using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Cultivo
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Resultado { get; set; }
        public DateTime? BajaLogica { get; set; }
        public long IdUsuario { get; set; }
        public Guid IdArea { get; set; }
        public Guid IdPaciente { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
