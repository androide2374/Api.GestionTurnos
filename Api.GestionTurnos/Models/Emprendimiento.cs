using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Emprendimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Emprendedor { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Web { get; set; }
        public string Logo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? EcoFriendly { get; set; }
        public DateTime? BajaLogica { get; set; }
        public string Web2 { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Logo2 { get; set; }
        public string Logo3 { get; set; }
        public string Logo4 { get; set; }
        public string Logo5 { get; set; }
        public int? Estado { get; set; }
        public bool? Sistema { get; set; }
        public string Partido { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string Documento { get; set; }
    }
}
