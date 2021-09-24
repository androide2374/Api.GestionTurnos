﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TipoDocumento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? Usuario { get; set; }
    }
}