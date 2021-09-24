using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Renta
    {
        public double? Cuenta { get; set; }
        public string Tasa { get; set; }
        public string ApellidoYNombre { get; set; }
        public double? TipoDocumento { get; set; }
        public string DocuDescripcion { get; set; }
        public double? DocuPersona { get; set; }
        public string DocuNumero { get; set; }
        public string Calle { get; set; }
        public double? Altura { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Localidad { get; set; }
        public double? CodPostal { get; set; }
    }
}
