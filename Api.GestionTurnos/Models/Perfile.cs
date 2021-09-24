using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Perfile
    {
        public int PerId { get; set; }
        public int PerOrden { get; set; }
        public int AgesId { get; set; }
        public string PerNombre { get; set; }
        public int CarId { get; set; }
        public string PerDescripcionBreve { get; set; }
        public string PerDescripcion { get; set; }
        public string PerHtml { get; set; }
        public string PerImagen { get; set; }
    }
}
