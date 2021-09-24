using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TomogPracticaSolicitud
    {
        public Guid IdPractica { get; set; }
        public Guid IdTomogSolicitud { get; set; }
        public bool? Realizado { get; set; }

        public virtual TomogPractica IdPracticaNavigation { get; set; }
        public virtual TomogSolicitudHistorial IdTomogSolicitudNavigation { get; set; }
    }
}
