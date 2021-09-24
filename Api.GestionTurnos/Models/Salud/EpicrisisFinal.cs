using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class EpicrisisFinal
    {
        public string PacienteIndex { get; set; }
        public string Documento { get; set; }
        public string Ingreso { get; set; }
        public string Egreso { get; set; }
        public int? Edad { get; set; }
        public string Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string ObraSocial { get; set; }
        public string MotivoIngreso { get; set; }
        public string AntecedentesRelevantes { get; set; }
        public string EnfermedadActual { get; set; }
        public string Estudios { get; set; }
        public string Tratamiento { get; set; }
        public string Intercurrencias { get; set; }
        public string Evolucion { get; set; }
        public string IndicacionesEgreso { get; set; }
        public string DiagnosticoIngreso { get; set; }
        public string DiagnosticoEgreso { get; set; }
        public string Destino { get; set; }
        public string MotivoInternacion { get; set; }
        public string TratamientoInstaurado { get; set; }
    }
}
