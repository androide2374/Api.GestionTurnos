using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class Html
    {
        public int HtmId { get; set; }
        public string HtmTitulo { get; set; }
        public string HtmAlias { get; set; }
        public string HtmBody { get; set; }
        public int? CatId { get; set; }
        public int? DelId { get; set; }
        public int? SubId { get; set; }
        public bool? HtmStatus { get; set; }
        public int? UsrId { get; set; }
    }
}
