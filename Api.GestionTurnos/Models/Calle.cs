using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Calle
    {
        public int Id { get; set; }
        public int? Oficina { get; set; }
        public string NombreCalle { get; set; }
        public int? AlturaDesde { get; set; }
        public int? AlturaHasta { get; set; }
        public int? Lado { get; set; }
    }
}
