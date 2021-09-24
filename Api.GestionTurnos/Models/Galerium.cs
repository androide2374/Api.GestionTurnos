using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Galerium
    {
        public int GalId { get; set; }
        public string GalTitulo { get; set; }
        public int CatId { get; set; }
        public string GalFull { get; set; }
        public string GalPreview { get; set; }
        public string VidId { get; set; }
    }
}
