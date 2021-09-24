using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class ObraSocial
    {
        public ObraSocial()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int? Cp { get; set; }
        public string Loc { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public Guid? IdAnexoSamo { get; set; }

        public virtual AnexoSamo IdAnexoSamoNavigation { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
