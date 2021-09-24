using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoCaso
    {
        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
    }
}
