using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Buscador
    {
        public int BusId { get; set; }
        public string BusTitulo { get; set; }
        public string BusFiltro { get; set; }
        public string BusTema { get; set; }
        public string BusLink { get; set; }
        public int? BusOrden { get; set; }
    }
}
