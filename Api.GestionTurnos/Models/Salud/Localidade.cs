using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Localidade
    {
        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public string Code { get; set; }
        public Guid IdPartido { get; set; }

        public virtual Partido IdPartidoNavigation { get; set; }
    }
}
