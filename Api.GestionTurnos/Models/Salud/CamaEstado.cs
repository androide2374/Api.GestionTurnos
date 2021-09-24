using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class CamaEstado
    {
        public CamaEstado()
        {
            Camas = new HashSet<Cama>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cama> Camas { get; set; }
    }
}
