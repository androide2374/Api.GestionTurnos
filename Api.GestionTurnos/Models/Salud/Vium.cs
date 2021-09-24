using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Vium
    {
        public Vium()
        {
            Antibioticos = new HashSet<Antibiotico>();
            Indicaciones = new HashSet<Indicacione>();
            Medicamentos = new HashSet<Medicamento>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Antibiotico> Antibioticos { get; set; }
        public virtual ICollection<Indicacione> Indicaciones { get; set; }
        public virtual ICollection<Medicamento> Medicamentos { get; set; }
    }
}
