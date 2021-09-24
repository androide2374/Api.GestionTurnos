using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ParteInstrumentador
    {
        public Guid Orid { get; set; }
        public Guid IdQuirofano { get; set; }
        public DateTime Fecha { get; set; }
        public Guid IdEspecialidadQuirurgica { get; set; }
        public string ProcedimientoQuirurgico { get; set; }
        public string Ayudante1 { get; set; }
        public string Ayudante2 { get; set; }
        public string Observacion { get; set; }
        public long UserId { get; set; }
        public DateTime? BajaLogica { get; set; }
        public string NombreCirujano { get; set; }

        public virtual EspecialidadQuirurgica IdEspecialidadQuirurgicaNavigation { get; set; }
        public virtual Quirofano IdQuirofanoNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
