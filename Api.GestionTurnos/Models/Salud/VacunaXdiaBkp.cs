using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class VacunaXdiaBkp
    {
        public Guid Orid { get; set; }
        public Guid? IdVacuna { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? CantidadTotal { get; set; }
        public int? CantidadRestante { get; set; }
    }
}
