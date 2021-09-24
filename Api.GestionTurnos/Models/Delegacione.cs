using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Delegacione
    {
        public int DelId { get; set; }
        public string DelDescripcion { get; set; }
        public DateTime? DelBajaLogica { get; set; }
    }
}
