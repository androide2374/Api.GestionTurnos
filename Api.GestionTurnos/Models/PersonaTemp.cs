using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class PersonaTemp
    {
        public int Id { get; set; }
        public int IdTipoPersona { get; set; }
        public int IdTipoDocumento { get; set; }
        public bool? Titular { get; set; }
        public string Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public DateTime? Nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Correo { get; set; }
        public int? IdLocalidad { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public string Piso { get; set; }
        public string Depto { get; set; }
        public int? IdSexo { get; set; }
        public bool? Discapacitado { get; set; }
        public string Cp { get; set; }
        public string Padron { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? IdEstadoCivil { get; set; }
    }
}
