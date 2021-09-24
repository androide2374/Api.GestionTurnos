using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class CorCorteCancelado
    {
        public int Id { get; set; }
        public int IdTipoCorte { get; set; }
        public int IdSolicitante { get; set; }
        public DateTime? FechaDeSolicitud { get; set; }
        public DateTime FechaDelCorte { get; set; }
        public DateTime? Confirmacion { get; set; }
        public string Domicilio { get; set; }
        public int IdHorario { get; set; }
        public string OtroHorario { get; set; }
        public string EntreCalle1 { get; set; }
        public string EntreCalle2 { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Derivado { get; set; }
        public int IdStatus { get; set; }
        public int IdTipoSolicitud { get; set; }
        public DateTime Cancelado { get; set; }
        public string CorreoEnviado { get; set; }
        public bool? Chk1 { get; set; }
        public bool? Chk2 { get; set; }
        public bool? Chk3 { get; set; }
        public bool? Chk4 { get; set; }
        public bool? Chk5 { get; set; }
        public bool? Chk6 { get; set; }
        public bool? Chk7 { get; set; }
        public bool? Chk8 { get; set; }
        public bool? Chk9 { get; set; }
    }
}
