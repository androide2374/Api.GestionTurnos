using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class MotivoConsultum
    {
        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public Guid IdEspecialidad { get; set; }
    }
}
