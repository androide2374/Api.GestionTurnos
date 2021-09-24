using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ObraSocial
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int? Cp { get; set; }
        public string Loc { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
    }
}
