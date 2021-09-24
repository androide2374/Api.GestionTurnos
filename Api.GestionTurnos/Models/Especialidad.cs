using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            EnteEspecialidads = new HashSet<EnteEspecialidad>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EnteEspecialidad> EnteEspecialidads { get; set; }
    }
}
