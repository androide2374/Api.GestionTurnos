using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class LuminariasFoto
    {
        public int FotId { get; set; }
        public string LumId { get; set; }
        public string FotDescripcion { get; set; }
        public DateTime? FotAlta { get; set; }
    }
}
