using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Ente
    {
        public Ente()
        {
            Areas = new HashSet<Area>();
            Derivacions = new HashSet<Derivacion>();
            EnteEspecialidads = new HashSet<EnteEspecialidad>();
            FarFarmacia = new HashSet<FarFarmacium>();
            TurDedicacions = new HashSet<TurDedicacion>();
            TurDiasNoLaborables = new HashSet<TurDiasNoLaborable>();
            Users = new HashSet<User>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public Guid IdLocalidad { get; set; }
        public Guid IdTipoEnte { get; set; }
        public bool AplicaTriage { get; set; }
        public string Foto { get; set; }
        public bool? AplicaTurnoOnLine { get; set; }

        public virtual Localidad IdLocalidadNavigation { get; set; }
        public virtual TipoEnte IdTipoEnteNavigation { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Derivacion> Derivacions { get; set; }
        public virtual ICollection<EnteEspecialidad> EnteEspecialidads { get; set; }
        public virtual ICollection<FarFarmacium> FarFarmacia { get; set; }
        public virtual ICollection<TurDedicacion> TurDedicacions { get; set; }
        public virtual ICollection<TurDiasNoLaborable> TurDiasNoLaborables { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
