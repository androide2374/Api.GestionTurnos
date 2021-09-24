using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TempHoja21TotalesArea
    {
        public string Servicio { get; set; }
        public string Codigo { get; set; }
        public int? Total { get; set; }
        public int? OsSi { get; set; }
        public int? OsNo { get; set; }
    }
}
