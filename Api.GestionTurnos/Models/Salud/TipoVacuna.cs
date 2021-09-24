using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoVacuna
    {
        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public DateTime? BajaLogica { get; set; }
        public string Informacion { get; set; }
        public int? Cantidad { get; set; }
    }
}
