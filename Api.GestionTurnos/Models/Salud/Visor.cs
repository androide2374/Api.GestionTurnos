using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Visor
    {
        public string Paciente { get; set; }
        public string Puesto { get; set; }
        public string Hora { get; set; }
        public Guid? IdPaciente { get; set; }
    }
}
