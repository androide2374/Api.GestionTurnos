using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarPrescripcionCab
    {
        public FarPrescripcionCab()
        {
            FarPrescipcionDets = new HashSet<FarPrescipcionDet>();
        }

        public Guid Orid { get; set; }
        public long? IdUsuario { get; set; }
        public Guid? IdServicio { get; set; }
        public Guid? IdPaciente { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Area IdServicioNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<FarPrescipcionDet> FarPrescipcionDets { get; set; }
    }
}
