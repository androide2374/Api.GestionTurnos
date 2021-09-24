using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class DenunciaEmpleadosPublico
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Denunciado { get; set; }
        public string Resumen { get; set; }
        public DateTime Fecha { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Archivo4 { get; set; }
        public string Archivo5 { get; set; }
    }
}
