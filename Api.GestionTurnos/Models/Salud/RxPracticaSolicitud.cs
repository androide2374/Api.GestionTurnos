using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class RxPracticaSolicitud
    {
        public Guid IdPractica { get; set; }
        public Guid IdRxSolicitud { get; set; }
        public bool? Realizado { get; set; }

        public virtual RxPractica IdPracticaNavigation { get; set; }
        public virtual RxSolicitudHistorial IdRxSolicitudNavigation { get; set; }
    }
}
