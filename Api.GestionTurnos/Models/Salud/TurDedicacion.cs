using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TurDedicacion
    {
        public Guid Orid { get; set; }
        public Guid IdEnte { get; set; }
        public long IdUser { get; set; }
        public Guid IdEspecialidad { get; set; }
        public int DiaSemana { get; set; }
        public TimeSpan Desde { get; set; }
        public TimeSpan Hasta { get; set; }
        public int DuracionTurno { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
        public virtual Especialidad IdEspecialidadNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
