using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarRemitoCab
    {
        public FarRemitoCab()
        {
            FarRemitoDets = new HashSet<FarRemitoDet>();
        }

        public Guid Orid { get; set; }
        public int Numero { get; set; }
        public Guid IdArea { get; set; }
        public DateTime Fecha { get; set; }
        public long IdUsuario { get; set; }
        public Guid IdEstado { get; set; }

        public virtual Area IdAreaNavigation { get; set; }
        public virtual FarRemitoEstado IdEstadoNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
        public virtual ICollection<FarRemitoDet> FarRemitoDets { get; set; }
    }
}
