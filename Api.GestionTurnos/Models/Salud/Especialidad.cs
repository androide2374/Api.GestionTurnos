using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            ClasificacionDeRiesgoHistorials = new HashSet<ClasificacionDeRiesgoHistorial>();
            EnteEspecialidads = new HashSet<EnteEspecialidad>();
            TurDedicacions = new HashSet<TurDedicacion>();
            UserEspecialidads = new HashSet<UserEspecialidad>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
        public virtual ICollection<EnteEspecialidad> EnteEspecialidads { get; set; }
        public virtual ICollection<TurDedicacion> TurDedicacions { get; set; }
        public virtual ICollection<UserEspecialidad> UserEspecialidads { get; set; }
    }
}
