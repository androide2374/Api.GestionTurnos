using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GestionTurnos.Models.ModelSaludContext
{
    public class TurnosSalud
    {
        public Guid IdTurno { get; set; }
        public DateTime FechaTurno { get; set; }
        public string Especialidad { get; set; }
        public string TipoAtencion { get; set; }
        public string Profesional { get; set; }
        public string Ente { get; set; }
    }
}
