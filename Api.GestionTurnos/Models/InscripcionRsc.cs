using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class InscripcionRsc
    {
        public int Id { get; set; }
        public string NombreInstitucion { get; set; }
        public string CantidadMenores { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAlt { get; set; }
        public bool? Validado { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Anotaciones { get; set; }
    }
}
