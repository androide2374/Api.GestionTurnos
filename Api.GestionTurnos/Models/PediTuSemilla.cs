using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class PediTuSemilla
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string TieneHuerta { get; set; }
        public string TipoHuerta { get; set; }
        public string DondeConsigueSemillas { get; set; }
        public string ParticiparHuerta { get; set; }
        public string RealizaCompost { get; set; }
        public string ParticiparCompostComunitario { get; set; }
        public string InformacionCompostaje { get; set; }
        public string ConocerResiduosReciclables { get; set; }
        public string SeparaResiduos { get; set; }
        public string QhacesConMaterialReciclable { get; set; }
        public string ConocePuntoVerde { get; set; }
        public string ConoceReserva { get; set; }
        public string VisitoReserva { get; set; }
        public string TieneArbol { get; set; }
        public string QueEspecieEs { get; set; }
        public int? IdDelegacion { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Entregado { get; set; }
    }
}
