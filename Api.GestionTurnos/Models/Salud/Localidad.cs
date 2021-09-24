using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Localidad
    {
        public Localidad()
        {
            Entes = new HashSet<Ente>();
            PersonaTurnos = new HashSet<PersonaTurno>();
            PersonaTurnosps = new HashSet<PersonaTurnosp>();
            Personas = new HashSet<Persona>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string CodigoPostal { get; set; }
        public bool? EsLomas { get; set; }
        public Guid? IdLocalidades { get; set; }

        public virtual ICollection<Ente> Entes { get; set; }
        public virtual ICollection<PersonaTurno> PersonaTurnos { get; set; }
        public virtual ICollection<PersonaTurnosp> PersonaTurnosps { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
