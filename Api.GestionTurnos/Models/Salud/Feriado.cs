using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Feriado
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
