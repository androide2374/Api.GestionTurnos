using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class ToProfesional
    {
        public Guid Orid { get; set; }
        public int IdPersona { get; set; }
        public Guid IdProfesion { get; set; }
        public Guid IdTipoProfesional { get; set; }
        public string MatriculaProfesional { get; set; }
        public string MatriculaMunicipal { get; set; }

        public virtual ToProfesion IdProfesionNavigation { get; set; }
        public virtual ToTipoProfesional IdTipoProfesionalNavigation { get; set; }
    }
}
