using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Internacione
    {
        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string DiagnosticoPresuntivo { get; set; }
        public string HistoriaClinica { get; set; }
        public string Indicaciones { get; set; }
        public string MotivoConsulta { get; set; }
        public string OtraInstitucion { get; set; }
        public int? FrecuenciaCardiaca { get; set; }
        public int? FrecuenciaRespiratoria { get; set; }
        public int? Hgt { get; set; }
        public int? PresionAlta { get; set; }
        public int? PresionBaja { get; set; }
        public int? Saturacion { get; set; }
        public decimal? Temperatura { get; set; }
        public Guid IdDiagPrim { get; set; }
        public Guid? IdDiagSec { get; set; }
        public Guid IdPaciente { get; set; }
        public long IdUsuario { get; set; }
        public string Obito { get; set; }
        public bool? SignosVitales { get; set; }
        public Guid? IdArea { get; set; }
        public string ProlongacionEstadia { get; set; }
        public int? DiasDeProlongacion { get; set; }
        public bool FinF10 { get; set; }
        public int? Ingresos { get; set; }
        public int? Egresos { get; set; }
        public int? PerdidasInsensibles { get; set; }
        public int? BalanceHidrico { get; set; }
        public DateTime? ViaCentral { get; set; }
        public DateTime? Sng { get; set; }
        public DateTime? K108 { get; set; }
        public DateTime? Sv { get; set; }
        public string Ekg { get; set; }
        public Guid? IdTipoNutricion { get; set; }
        public string Volumen { get; set; }
        public string EstudiosComplementarios { get; set; }
        public string LaboratorioAnormal { get; set; }
        public string Evolucion { get; set; }
        public string PlanTerapeutico { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual TipoNutricion IdTipoNutricionNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
