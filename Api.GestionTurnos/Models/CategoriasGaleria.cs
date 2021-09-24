using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class CategoriasGaleria
    {
        public int CatId { get; set; }
        public int? GruId { get; set; }
        public string CatDescripcion { get; set; }
        public string CatFiltro { get; set; }
        public string CatFoto { get; set; }
    }
}
