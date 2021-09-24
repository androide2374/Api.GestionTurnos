using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class BoletinOficial
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Archivo { get; set; }
        public int Tipo { get; set; }
        public int? SubId { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? UsrId { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
