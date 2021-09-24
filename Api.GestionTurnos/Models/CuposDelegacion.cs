using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class CuposDelegacion
    {
        public int Id { get; set; }
        public int IdDelegacion { get; set; }
        public int Cupo { get; set; }
        public int? Semana { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
