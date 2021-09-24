using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Indicacione
    {
        public Indicacione()
        {
            InternacionesEnfermeria = new HashSet<InternacionesEnfermerium>();
            ObservacionesEnfermeria = new HashSet<ObservacionesEnfermerium>();
            ShockRoomEnfermeria = new HashSet<ShockRoomEnfermerium>();
            TerapiaEnfermeria = new HashSet<TerapiaEnfermerium>();
        }

        public Guid Orid { get; set; }
        public DateTime Fecha { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Observaciones { get; set; }
        public string Procedimiento { get; set; }
        public int? Php { get; set; }
        public string Phpvalor { get; set; }
        public int? Gotas { get; set; }
        public bool? Bomba { get; set; }
        public string BombaMedicamento { get; set; }
        public string BombaFrecuencia { get; set; }
        public DateTime? BajaLogica { get; set; }
        public Guid? IdVia { get; set; }
        public long IdUsuario { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid? IdDieta { get; set; }
        public Guid? IdArea { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual Vium IdViaNavigation { get; set; }
        public virtual ICollection<InternacionesEnfermerium> InternacionesEnfermeria { get; set; }
        public virtual ICollection<ObservacionesEnfermerium> ObservacionesEnfermeria { get; set; }
        public virtual ICollection<ShockRoomEnfermerium> ShockRoomEnfermeria { get; set; }
        public virtual ICollection<TerapiaEnfermerium> TerapiaEnfermeria { get; set; }
    }
}
