using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class AnexoSamo
    {
        public AnexoSamo()
        {
            ObraSocials = new HashSet<ObraSocial>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string Archivo { get; set; }

        public virtual ICollection<ObraSocial> ObraSocials { get; set; }
    }
}
