using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class SubSeccione
    {
        public int SubId { get; set; }
        public int? AgesId { get; set; }
        public string SubDescripcion { get; set; }
        public string SubTarget { get; set; }
        public bool? SubStatus { get; set; }
        public int? Orden { get; set; }
    }
}
