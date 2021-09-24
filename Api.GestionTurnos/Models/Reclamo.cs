using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Reclamo
    {
        public int RecId { get; set; }
        public string RecApellido { get; set; }
        public string RecNombres { get; set; }
        public string RecDomicilio { get; set; }
        public int? RecDni { get; set; }
        public string RecTelefono { get; set; }
        public string RecCorreo { get; set; }
        public string RecSugerencia { get; set; }
        public DateTime? RecAlta { get; set; }
        public string RecCalle1 { get; set; }
        public string RecCalle2 { get; set; }
        public string RecLocalidad { get; set; }
        public string RecPadron { get; set; }
        public string RecCalleR { get; set; }
        public string RecCalleR1 { get; set; }
        public string RecCalleR2 { get; set; }
    }
}
