using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Denunciado
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int? IdDefensaConsumidor { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Localidad { get; set; }
        public string Cp { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
    }
}
