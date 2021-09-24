using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Localidad
    {
        public int Id { get; set; }
        public int IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public DateTime? BajaLogica { get; set; }
        public bool? EsLomas { get; set; }
    }
}
