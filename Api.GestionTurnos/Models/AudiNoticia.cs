using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class AudiNoticia
    {
        public int NotId { get; set; }
        public string NotTitulo { get; set; }
        public string NotTema { get; set; }
        public string NotDescripcion { get; set; }
        public DateTime? NotFecha { get; set; }
        public int? TnotId { get; set; }
        public string NotFoto { get; set; }
        public int? DelId { get; set; }
        public int? GestId { get; set; }
        public bool? NotPrincipal { get; set; }
        public DateTime? NotBajaLogica { get; set; }
        public int? UsrId { get; set; }
        public string AudiAccion { get; set; }
        public DateTime? AudiFecha { get; set; }
    }
}
