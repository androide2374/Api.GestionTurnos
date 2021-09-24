using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Partido
    {
        public Partido()
        {
            Localidades = new HashSet<Localidade>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public string Code { get; set; }
        public Guid IdProvincia { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual ICollection<Localidade> Localidades { get; set; }
    }
}
