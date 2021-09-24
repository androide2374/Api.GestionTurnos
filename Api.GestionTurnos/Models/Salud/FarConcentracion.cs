using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarConcentracion
    {
        public FarConcentracion()
        {
            FarContenidos = new HashSet<FarContenido>();
        }

        public Guid Orid { get; set; }
        public string Descripcion { get; set; }
        public decimal? CapacidadValue { get; set; }
        public Guid? IdCapacidad { get; set; }

        public virtual ICollection<FarContenido> FarContenidos { get; set; }
    }
}
