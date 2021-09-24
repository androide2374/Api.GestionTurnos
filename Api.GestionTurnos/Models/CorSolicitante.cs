using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class CorSolicitante
    {
        public int Id { get; set; }
        public int IdTipoSolicitante { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string TelefonoAlternativo { get; set; }
        public string Correo { get; set; }
        public string MatriculaMunicipal { get; set; }
        public string MatriculaProfesional { get; set; }
        public string NumeroExpediente { get; set; }
        public string Institucion { get; set; }
        public string Padron { get; set; }
    }
}
