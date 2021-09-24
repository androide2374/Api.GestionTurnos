using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ParteAnestesistum
    {
        public Guid Orid { get; set; }
        public Guid IdQuirofano { get; set; }
        public DateTime Fecha { get; set; }
        public long UserId { get; set; }
        public string Observacion { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual Quirofano IdQuirofanoNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
