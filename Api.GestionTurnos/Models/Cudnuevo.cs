using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Cudnuevo
    {
        public int Id { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Estado { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Archivo4 { get; set; }
        public string Archivo5 { get; set; }
        public string Archivo6 { get; set; }
        public string Archivo7 { get; set; }
        public string Archivo8 { get; set; }
        public string Archivo9 { get; set; }
        public string Archivo10 { get; set; }
        public string Archivo11 { get; set; }
        public string Discapacidad { get; set; }
        public string CorreoEnviado { get; set; }
        public int? EsRenovacion { get; set; }
        public int? EsReingresoXprot { get; set; }
        public int? EsReagravamiento { get; set; }
    }
}
