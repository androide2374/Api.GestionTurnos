using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Nn
    {
        public Nn()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public Guid Orid { get; set; }
        public decimal Estatura { get; set; }
        public decimal? Peso { get; set; }
        public string SenasParticulares { get; set; }
        public Guid? SexoId { get; set; }
        public long Id { get; set; }
        public string Nombre { get; set; }

        public virtual Sexo Sexo { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
