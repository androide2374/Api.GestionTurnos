using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Login
    {
        public Guid Orid { get; set; }
        public DateTime Login1 { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdEnte { get; set; }
        public Guid IdArea { get; set; }
        public Guid IdPuesto { get; set; }
    }
}
