using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class LaboratorioPracticaSolicitud
    {
        public Guid IdPractica { get; set; }
        public Guid IdLaboratorioSolicitud { get; set; }
        public bool Realizado { get; set; }

        public virtual LaboratorioSolicitudHistorial IdLaboratorioSolicitudNavigation { get; set; }
        public virtual LaboratorioPractica IdPracticaNavigation { get; set; }
    }
}
