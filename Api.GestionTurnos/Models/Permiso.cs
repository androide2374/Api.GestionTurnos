using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Permiso
    {
        public int PerId { get; set; }
        public int RolId { get; set; }
        public int MnuId { get; set; }
        public bool? PerPermiso { get; set; }
        public DateTime? PerFechaAlta { get; set; }
        public DateTime? PerBajaLogica { get; set; }
    }
}
