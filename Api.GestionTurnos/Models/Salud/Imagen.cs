using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Imagen
    {
        public Guid Orid { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdArea { get; set; }
        public long IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Archivo { get; set; }
    }
}
