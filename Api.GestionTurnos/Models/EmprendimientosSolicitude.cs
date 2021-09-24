using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class EmprendimientosSolicitude
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Detalle { get; set; }
        public DateTime? Estado { get; set; }
    }
}
