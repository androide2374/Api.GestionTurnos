using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class DefensaConsumidor
    {
        public int Id { get; set; }
        public int? IdPersona { get; set; }
        public string Hecho { get; set; }
        public string Pretension { get; set; }
        public DateTime? Fecha { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public string Archivo4 { get; set; }
        public string Archivo5 { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaEstado { get; set; }
        public DateTime? FechaAudiencia { get; set; }
        public string DenunciadosDeAudiencia { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public string CorreoEnviado { get; set; }
        public string Archivo6 { get; set; }
        public string Observacion { get; set; }
        public string TutNombre { get; set; }
        public string TutDocumento { get; set; }
        public int? IdTipoSolicitud { get; set; }
        public string NumExpediente { get; set; }
        public int? IdHorario { get; set; }
    }
}
