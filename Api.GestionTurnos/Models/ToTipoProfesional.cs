using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ToTipoProfesional
    {
        public ToTipoProfesional()
        {
            ToProfesionals = new HashSet<ToProfesional>();
            ToSolicitudes = new HashSet<ToSolicitude>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ToProfesional> ToProfesionals { get; set; }
        public virtual ICollection<ToSolicitude> ToSolicitudes { get; set; }
    }
}
