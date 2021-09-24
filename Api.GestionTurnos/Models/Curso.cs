using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Curso
    {
        public int Id { get; set; }
        public int IdEnte { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public bool? Estado { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? Cupos { get; set; }
    }
}
