using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Imagene
    {
        public int ImgId { get; set; }
        public string ImgDescripcion { get; set; }
        public string ImgPath { get; set; }
        public int? ImgTipo { get; set; }
        public int? DelId { get; set; }
        public int? GestId { get; set; }
        public bool? ImgPrincipal { get; set; }
        public int? ImgIframe { get; set; }
    }
}
