﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class EspecialidadQuirurgica
    {
        public EspecialidadQuirurgica()
        {
            ParteInstrumentadors = new HashSet<ParteInstrumentador>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ParteInstrumentador> ParteInstrumentadors { get; set; }
    }
}
