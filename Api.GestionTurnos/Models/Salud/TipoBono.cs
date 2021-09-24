using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoBono
    {
        public TipoBono()
        {
            BonosAdmisions = new HashSet<BonosAdmision>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public bool? EsLomas { get; set; }
        public int? Dias { get; set; }
        public int? DiasFin { get; set; }

        public virtual ICollection<BonosAdmision> BonosAdmisions { get; set; }
    }
}
