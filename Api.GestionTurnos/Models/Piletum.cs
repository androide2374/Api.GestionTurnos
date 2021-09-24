using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Piletum
    {
        public int Id { get; set; }
        public DateTime FechaCupo { get; set; }
        public int IdPersona1 { get; set; }
        public int? IdPersona2 { get; set; }
        public int? IdPersona3 { get; set; }
        public int? IdPersona4 { get; set; }
        public int? IdPersona5 { get; set; }
    }
}
