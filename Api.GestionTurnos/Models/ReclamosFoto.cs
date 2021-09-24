using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ReclamosFoto
    {
        public int FotId { get; set; }
        public string RecId { get; set; }
        public string FotDescripcion { get; set; }
        public DateTime? FotAlta { get; set; }
    }
}
