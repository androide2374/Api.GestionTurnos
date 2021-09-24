using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class VoluntariosCovid
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Carrera { get; set; }
        public string OtraCar { get; set; }
        public string Materias { get; set; }
        public bool? Chk1 { get; set; }
        public bool? Chk2 { get; set; }
        public bool? Chk3 { get; set; }
        public bool? Chk4 { get; set; }
        public bool? Chk5 { get; set; }
        public bool? Chk6 { get; set; }
        public string Embarazo { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? Estado { get; set; }
        public string DispHoraria { get; set; }
    }
}
