using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Luminaria
    {
        public int LumId { get; set; }
        public string LumApellido { get; set; }
        public string LumNombres { get; set; }
        public string LumDomicilio { get; set; }
        public int? LumDni { get; set; }
        public string LumTelefono { get; set; }
        public string LumCorreo { get; set; }
        public string LumSugerencia { get; set; }
        public DateTime? LumAlta { get; set; }
        public string LumCalle1 { get; set; }
        public string LumCalle2 { get; set; }
        public string LumLocalidad { get; set; }
        public string LumPadron { get; set; }
        public int? TlumId { get; set; }
        public string LumCalleL { get; set; }
        public string LumCalleL1 { get; set; }
        public string LumCalleL2 { get; set; }
    }
}
