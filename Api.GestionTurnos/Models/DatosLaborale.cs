using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class DatosLaborale
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Actividad { get; set; }
        public string Horario { get; set; }
        public int? IdObraSocial { get; set; }
    }
}
