using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ToSolicitude
    {
        public Guid Orid { get; set; }
        public int Numero { get; set; }
        public int IdPersona { get; set; }
        public Guid IdTipoProfesional { get; set; }
        public Guid IdProfesion { get; set; }
        public string MatriculaProfesional { get; set; }
        public DateTime? FechaEmisionMatriculaProfesional { get; set; }
        public string MatriculaMunicipal { get; set; }
        public DateTime? FechaEmisionMatriculaMunicipal { get; set; }
        public string ScanDniFrente { get; set; }
        public string ScanDniDorso { get; set; }
        public string ScanTituloHabilitante { get; set; }
        public string ScanPagoMatricula { get; set; }
        public string ScanPagoRegistro { get; set; }
        public byte[] FotoCarnet { get; set; }
        public int IdStatus { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaAprobacionDocumentacion { get; set; }
        public DateTime? FechaRegistroComprobantePago { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public DateTime? FechaArchivado { get; set; }

        public virtual ToProfesion IdProfesionNavigation { get; set; }
        public virtual ToStatus IdStatusNavigation { get; set; }
        public virtual ToTipoProfesional IdTipoProfesionalNavigation { get; set; }
    }
}
