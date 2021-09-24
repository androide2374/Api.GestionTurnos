using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Buscador
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Filtro { get; set; }
        public string Tema { get; set; }
        public string Link { get; set; }
        public int? Orden { get; set; }
        public bool? EsVideo { get; set; }
    }
}
