using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class VehiculosCompactado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Archivo { get; set; }
        public int Tipo { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUser { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? IdSubSeccion { get; set; }
    }
}
