﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class FarProveedor
    {
        public FarProveedor()
        {
            FarStocks = new HashSet<FarStock>();
        }

        public Guid Orid { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime? BajaLogica { get; set; }

        public virtual ICollection<FarStock> FarStocks { get; set; }
    }
}
