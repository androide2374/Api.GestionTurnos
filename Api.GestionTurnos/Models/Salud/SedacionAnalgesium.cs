using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class SedacionAnalgesium
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public Guid? IdSolucion { get; set; }
        public Guid? IdMedicacion { get; set; }
        public int? Goteo { get; set; }
        public int? Cantidad { get; set; }
        public string Observacion { get; set; }
        public DateTime? Suspendido { get; set; }
        public long IdUsuario { get; set; }
        public Guid IdArea { get; set; }
        public Guid IdPaciente { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual TipoMedicamento IdMedicacionNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual TipoSolucion IdSolucionNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
