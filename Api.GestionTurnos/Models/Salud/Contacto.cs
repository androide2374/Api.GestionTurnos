using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Contacto
    {
        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public Guid IdTipoContacto { get; set; }
        public Guid IdArea { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual TipoContacto IdTipoContactoNavigation { get; set; }
    }
}
