using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class InscripcionTeatro
    {
        public int Id { get; set; }
        public int? IdInscripcion { get; set; }
        public string Archivo { get; set; }
        public bool? EsEsencial { get; set; }
        public string Area { get; set; }
        public bool? PacienteCovid { get; set; }
        public string Padron { get; set; }
        public bool? Docente { get; set; }
    }
}
