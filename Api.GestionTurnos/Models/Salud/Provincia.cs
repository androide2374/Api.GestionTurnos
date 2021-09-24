using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Provincia
    {
        public Provincia()
        {
            Partidos = new HashSet<Partido>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Partido> Partidos { get; set; }
    }
}
