using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Menu
    {
        public int MnuId { get; set; }
        public int MnuNivel { get; set; }
        public string MnuDescripcion { get; set; }
        public string MnuUrl { get; set; }
        public int? MnuOrden { get; set; }
        public int? MnuPadre { get; set; }
        public int? MnuSistema { get; set; }
        public string MnuTarget { get; set; }
        public string MnuClase { get; set; }
    }
}
