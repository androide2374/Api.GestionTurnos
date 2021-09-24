using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Usuario
    {
        public int UsrId { get; set; }
        public string UsrUsuario { get; set; }
        public byte[] UsrPassword { get; set; }
        public string UsrNombre { get; set; }
        public string UsrApellido { get; set; }
        public bool? UsrHabilitado { get; set; }
        public DateTime? UsrFechaAlta { get; set; }
        public DateTime? UsrBajaLogica { get; set; }
        public string UsrMail { get; set; }
        public int? RolId { get; set; }
    }
}
