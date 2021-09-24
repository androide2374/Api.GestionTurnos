using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class RespuestasGlasgow
    {
        public Guid Id { get; set; }
        public Guid IdVariablesGlasgow { get; set; }
        public string Respuesta { get; set; }
        public int Puntaje { get; set; }
        public string Code { get; set; }

        public virtual VariablesGlasgow IdVariablesGlasgowNavigation { get; set; }
    }
}
