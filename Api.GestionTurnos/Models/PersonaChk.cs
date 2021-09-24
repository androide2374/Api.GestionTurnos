using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class PersonaChk
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public int? Piso { get; set; }
        public string Depto { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAlternativo { get; set; }
        public string Mail { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string CodigoPostal { get; set; }
        public string Padron { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdLocalidad { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdObraSocial { get; set; }
        public int IdTipoPersona { get; set; }
        public string EntreCalle1 { get; set; }
        public string EntreCalle2 { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Archivo4 { get; set; }
        public string Archivo5 { get; set; }
        public string Archivo6 { get; set; }
    }
}
