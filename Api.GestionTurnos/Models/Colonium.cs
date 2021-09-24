using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Colonium
    {
        public int Id { get; set; }
        public int IdCuposDelegacion { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int IdTipoDocumento { get; set; }
        public int Dni { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int IdLocalidad { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Correo { get; set; }
        public string MadreTutora { get; set; }
        public int? DniMadreTutora { get; set; }
        public string PadreTutor { get; set; }
        public int? DniPadretutor { get; set; }
        public string TelefonoPadreTutor { get; set; }
        public string AutorizacionPadres { get; set; }
        public bool? DerechoImagen { get; set; }
        public int? FichaMedica { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
