using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurBono
    {
        public Guid Orid { get; set; }
        public Guid IdTurno { get; set; }
        public Guid IdTipoBono { get; set; }
        public int? Valor { get; set; }
        public int? NroBono { get; set; }
    }
}
