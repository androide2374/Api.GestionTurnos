using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Api.GestionTurnos.Models.Request
{
    public class RegisterReq
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string Password { get; set; }
        public int IdSexo { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public string Piso { get; set; }
        public string Depto { get; set; }
        public string Cp { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? Habilitado { get; set; }
    }
}
