using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class LuminariasTipo
    {
        public int TlumId { get; set; }
        public string TlumDescripcion { get; set; }
        public DateTime? TlumBajaLogica { get; set; }
    }
}
