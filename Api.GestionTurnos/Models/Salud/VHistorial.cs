using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class VHistorial
    {
        public Guid Orid { get; set; }
        public DateTime? Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Medico { get; set; }
        public Guid IdPaciente { get; set; }
        public string Documento { get; set; }
        public string Area { get; set; }
        public string Code { get; set; }
        public Guid IdEnte { get; set; }
        public long? IdNn { get; set; }
    }
}
