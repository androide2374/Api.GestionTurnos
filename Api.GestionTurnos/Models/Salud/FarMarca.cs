using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarMarca
    {
        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdFabricante { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
