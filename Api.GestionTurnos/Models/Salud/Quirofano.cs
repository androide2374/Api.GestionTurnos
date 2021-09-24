using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Quirofano
    {
        public Quirofano()
        {
            ParteAnestesista = new HashSet<ParteAnestesistum>();
            ParteInstrumentadors = new HashSet<ParteInstrumentador>();
        }

        public Guid Orid { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid AreaProcedencia { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public long Cirujano { get; set; }
        public bool Finalizado { get; set; }
        public bool? Obito { get; set; }

        public virtual Area AreaProcedenciaNavigation { get; set; }
        public virtual User CirujanoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual ICollection<ParteAnestesistum> ParteAnestesista { get; set; }
        public virtual ICollection<ParteInstrumentador> ParteInstrumentadors { get; set; }
    }
}
