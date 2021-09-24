using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TempHoja20Base
    {
        public string Mes { get; set; }
        public string Año { get; set; }
        public string Establecimiento { get; set; }
        public string CodigoEstablecimiento { get; set; }
        public string Servicio { get; set; }
        public string CodigoServicio { get; set; }
        public string CodigoPartido { get; set; }
        public string RegionSanitaria { get; set; }
        public int? Dia { get; set; }
        public string ApellidoNombre { get; set; }
        public string Dni { get; set; }
        public int? VMen1 { get; set; }
        public int? MMen1 { get; set; }
        public int? V1a4 { get; set; }
        public int? M1a4 { get; set; }
        public int? V5a9 { get; set; }
        public int? M5a9 { get; set; }
        public int? V10a14 { get; set; }
        public int? M10a14 { get; set; }
        public int? V15a19 { get; set; }
        public int? M15a19 { get; set; }
        public int? V20a34 { get; set; }
        public int? M20a34 { get; set; }
        public int? V35a49 { get; set; }
        public int? M35a49 { get; set; }
        public int? V50a64 { get; set; }
        public int? M50a64 { get; set; }
        public int? V65 { get; set; }
        public int? M65 { get; set; }
        public string Partido { get; set; }
        public string Diagnostico { get; set; }
        public int? OsNo { get; set; }
        public int? OsSi { get; set; }
        public string PrimerVisita { get; set; }
    }
}
