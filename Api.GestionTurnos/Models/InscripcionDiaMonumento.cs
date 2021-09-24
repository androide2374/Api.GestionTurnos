using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class InscripcionDiaMonumento
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Comentario { get; set; }
        public string EspacioAvisitar { get; set; }
    }
}
