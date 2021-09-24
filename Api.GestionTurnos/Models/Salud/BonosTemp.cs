using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class BonosTemp
    {
        public Guid? Orid { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string TipoAdmision { get; set; }
        public Guid? IdTipoAdmision { get; set; }
        public int? Usuario { get; set; }
        public string TipoBono { get; set; }
        public string Valor { get; set; }
        public string Numero { get; set; }
        public bool? Tipo { get; set; }
        public Guid? IdTipoBono { get; set; }
        public string NombreNn { get; set; }
    }
}
