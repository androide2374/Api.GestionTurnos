using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Cartelera
    {
        public int CarId { get; set; }
        public DateTime? CarFecha { get; set; }
        public string CarTitulo { get; set; }
        public string CarDescripcion { get; set; }
        public string CarFoto { get; set; }
        public int? GenId { get; set; }
    }
}
