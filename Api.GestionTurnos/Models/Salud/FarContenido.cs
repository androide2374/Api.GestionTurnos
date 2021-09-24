using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarContenido
    {
        public FarContenido()
        {
            FarInsumos = new HashSet<FarInsumo>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Guid? IdCategoria { get; set; }
        public Guid? IdConcentracion { get; set; }
        public string Receta { get; set; }
        public bool? ImplicaPrecursoresQuimicos { get; set; }
        public DateTime? BajaLogica { get; set; }
        public Guid IdFabricante { get; set; }

        public virtual FarCategorium IdCategoriaNavigation { get; set; }
        public virtual FarConcentracion IdConcentracionNavigation { get; set; }
        public virtual ICollection<FarInsumo> FarInsumos { get; set; }
    }
}
