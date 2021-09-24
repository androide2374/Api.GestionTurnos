using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class DynamicQr
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int? Usuario { get; set; }
        public DateTime? BajaLogica { get; set; }
    }
}
