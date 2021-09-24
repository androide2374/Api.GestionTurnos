using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class GrupoSanguineo
    {
        public GrupoSanguineo()
        {
            PersonaTurnos = new HashSet<PersonaTurno>();
            PersonaTurnosps = new HashSet<PersonaTurnosp>();
            Personas = new HashSet<Persona>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PersonaTurno> PersonaTurnos { get; set; }
        public virtual ICollection<PersonaTurnosp> PersonaTurnosps { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
