using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class VariablesGlasgow
    {
        public VariablesGlasgow()
        {
            RespuestasGlasgows = new HashSet<RespuestasGlasgow>();
        }

        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public string Code { get; set; }

        public virtual ICollection<RespuestasGlasgow> RespuestasGlasgows { get; set; }
    }
}
