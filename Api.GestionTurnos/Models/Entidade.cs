using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Entidade
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? TipoEntidad { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public string Piso { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
    }
}
