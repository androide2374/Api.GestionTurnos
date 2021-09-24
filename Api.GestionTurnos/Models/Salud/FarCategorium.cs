using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarCategorium
    {
        public FarCategorium()
        {
            FarContenidos = new HashSet<FarContenido>();
            InverseParentNavigation = new HashSet<FarCategorium>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public Guid? Parent { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual FarCategorium ParentNavigation { get; set; }
        public virtual ICollection<FarContenido> FarContenidos { get; set; }
        public virtual ICollection<FarCategorium> InverseParentNavigation { get; set; }
    }
}
