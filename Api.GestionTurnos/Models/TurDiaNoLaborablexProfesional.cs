using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class TurDiaNoLaborablexProfesional
    {
        public int Id { get; set; }
        public int IdEnte { get; set; }
        public DateTime? Fecha { get; set; }
        public string Descripcion { get; set; }
        public int? IdUser { get; set; }
        public DateTime? Registro { get; set; }
        public int? IdUserBajaConsola { get; set; }
    }
}
