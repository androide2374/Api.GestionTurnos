using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Difunto
    {
        public int Id { get; set; }
        public int IdCementerio { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? Documento { get; set; }
        public string Acta { get; set; }
        public string Tomo { get; set; }
        public string Folio { get; set; }
        public string Año { get; set; }
        public string RegistroCivil { get; set; }
    }
}
