using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoAtencion
    {
        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdEspecialidad { get; set; }
        public string Informacion { get; set; }
        public DateTime? BajaLogica { get; set; }
        public string RequisitosHtml { get; set; }
    }
}
