using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class UnidadesSanitariasNuevo
    {
        public int UniId { get; set; }
        public string UniEstablecimiento { get; set; }
        public string UniDireccion { get; set; }
        public string UniBarrio { get; set; }
        public string UniTelefono { get; set; }
        public string UniAtencion { get; set; }
    }
}
