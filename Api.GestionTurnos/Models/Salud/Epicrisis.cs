using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Epicrisis
    {
        public Guid Orid { get; set; }
        public string MotivoIngreso { get; set; }
        public string AntecedentesRelevantes { get; set; }
        public string EnfermedadActual { get; set; }
        public string Estudios { get; set; }
        public string Tratamiento { get; set; }
        public string Intercurrencias { get; set; }
        public string Evolucion { get; set; }
        public string Destino { get; set; }
        public string MotivoInternacion { get; set; }
        public string TratamientoInstaurado { get; set; }
        public string IndicacionesEgreso { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid? IdDiagnosticoIngreso { get; set; }
        public Guid? IdDiagnosticoEgreso { get; set; }

        public virtual Diagnostico IdDiagnosticoEgresoNavigation { get; set; }
        public virtual Diagnostico IdDiagnosticoIngresoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
