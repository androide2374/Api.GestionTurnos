using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Inscripto
    {
        public int Id { get; set; }
        public int IdEnte { get; set; }
        public int IdCurso { get; set; }
        public int IdPersona { get; set; }
        public int? IdTutor { get; set; }
        public DateTime? Alta { get; set; }
        public bool? Aprobado { get; set; }
        public DateTime? FechaAprobado { get; set; }
    }
}
