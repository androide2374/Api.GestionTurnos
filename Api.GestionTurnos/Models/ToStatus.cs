using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ToStatus
    {
        public ToStatus()
        {
            ToSolicitudes = new HashSet<ToSolicitude>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ToSolicitude> ToSolicitudes { get; set; }
    }
}
