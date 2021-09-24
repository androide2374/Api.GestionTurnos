using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class TipoMedicamento
    {
        public TipoMedicamento()
        {
            Paralelos = new HashSet<Paralelo>();
            Phps = new HashSet<Php>();
            SedacionAnalgesia = new HashSet<SedacionAnalgesium>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? Indicacion { get; set; }
        public string IndicacionDesc { get; set; }

        public virtual ICollection<Paralelo> Paralelos { get; set; }
        public virtual ICollection<Php> Phps { get; set; }
        public virtual ICollection<SedacionAnalgesium> SedacionAnalgesia { get; set; }
    }
}
