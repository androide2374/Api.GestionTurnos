using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FichaIngreso
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Atendido { get; set; }
        public int? Ausente { get; set; }
        public string Parentezco { get; set; }
        public Guid? IdAcompanante { get; set; }
        public Guid IdArea { get; set; }
        public Guid IdComoLlego { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdPuesto { get; set; }
        public Guid IdTipoDeRecepcion { get; set; }
        public long IdUsuario { get; set; }
        public bool? Externo { get; set; }

        public virtual Persona IdAcompananteNavigation { get; set; }
        public virtual Area IdAreaNavigation { get; set; }
        public virtual ComoLlego IdComoLlegoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Puesto IdPuestoNavigation { get; set; }
        public virtual TipoRecepcion IdTipoDeRecepcionNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
