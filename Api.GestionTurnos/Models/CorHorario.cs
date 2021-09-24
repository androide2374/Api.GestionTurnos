using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class CorHorario
    {
        public int Id { get; set; }
        public string Rango { get; set; }
        public int? Maximo { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
