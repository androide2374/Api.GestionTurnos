using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurStatusNuevo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
