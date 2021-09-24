using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ClasificacionDeRiesgoHistorial
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string Medicamentos { get; set; }
        public string MotivoConsulta { get; set; }
        public string Observaciones { get; set; }
        public string OtrosDescripcion { get; set; }
        public string AlergiasDetalle { get; set; }
        public string Sintoma { get; set; }
        public bool? Alergias { get; set; }
        public bool? Corazon { get; set; }
        public bool? Diabetes { get; set; }
        public bool? Hipertension { get; set; }
        public bool? Otros { get; set; }
        public bool? RenalCronica { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }
        public int? Hgt { get; set; }
        public int PresionAlta { get; set; }
        public int PresionBaja { get; set; }
        public int? Saturacion { get; set; }
        public decimal? Temperatura { get; set; }
        public bool? Atendido { get; set; }
        public bool? Ausente { get; set; }
        public Guid IdEspecialidad { get; set; }
        public Guid IdNivelDeConciencia { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdTipoClasificacionDeRiesgo { get; set; }
        public long IdUsuario { get; set; }
        public string MedicamentosR { get; set; }
        public string InyectablesR { get; set; }
        public string PerimetroCefalico { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; }
        public virtual NivelDeConciencium IdNivelDeConcienciaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual TipoClasificacionDeRiesgo IdTipoClasificacionDeRiesgoNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
