using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TipoSolicitud
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool RequiereValidacion { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
