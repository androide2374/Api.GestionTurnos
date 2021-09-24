using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Calle
    {
        public Guid Orid { get; set; }
        public int? Oficina { get; set; }
        public string NombreCalle { get; set; }
        public int? AlturaDesde { get; set; }
        public int? AlturaHasta { get; set; }
        public int? Lado { get; set; }
    }
}
