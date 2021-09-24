using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Area
    {
        public Area()
        {
            Antibioticos = new HashSet<Antibiotico>();
            Camas = new HashSet<Cama>();
            Contactos = new HashSet<Contacto>();
            Cultivos = new HashSet<Cultivo>();
            DerivacionIdAreaDestinoNavigations = new HashSet<Derivacion>();
            DerivacionIdAreaOrigenNavigations = new HashSet<Derivacion>();
            FarPrescripcionCabs = new HashSet<FarPrescripcionCab>();
            FarRemitoCabs = new HashSet<FarRemitoCab>();
            FichaIngresos = new HashSet<FichaIngreso>();
            Indicaciones = new HashSet<Indicacione>();
            Medicamentos = new HashSet<Medicamento>();
            Paralelos = new HashSet<Paralelo>();
            Phps = new HashSet<Php>();
            Quirofanos = new HashSet<Quirofano>();
            SedacionAnalgesia = new HashSet<SedacionAnalgesium>();
            UserAreas = new HashSet<UserArea>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public Guid IdEnte { get; set; }
        public Guid IdTipoRecepcion { get; set; }
        public bool? EsMedica { get; set; }
        public bool? EsExterna { get; set; }
        public bool? AplicaInternacion { get; set; }
        public Guid? IdFarmacia { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
        public virtual TipoRecepcion IdTipoRecepcionNavigation { get; set; }
        public virtual ICollection<Antibiotico> Antibioticos { get; set; }
        public virtual ICollection<Cama> Camas { get; set; }
        public virtual ICollection<Contacto> Contactos { get; set; }
        public virtual ICollection<Cultivo> Cultivos { get; set; }
        public virtual ICollection<Derivacion> DerivacionIdAreaDestinoNavigations { get; set; }
        public virtual ICollection<Derivacion> DerivacionIdAreaOrigenNavigations { get; set; }
        public virtual ICollection<FarPrescripcionCab> FarPrescripcionCabs { get; set; }
        public virtual ICollection<FarRemitoCab> FarRemitoCabs { get; set; }
        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
        public virtual ICollection<Indicacione> Indicaciones { get; set; }
        public virtual ICollection<Medicamento> Medicamentos { get; set; }
        public virtual ICollection<Paralelo> Paralelos { get; set; }
        public virtual ICollection<Php> Phps { get; set; }
        public virtual ICollection<Quirofano> Quirofanos { get; set; }
        public virtual ICollection<SedacionAnalgesium> SedacionAnalgesia { get; set; }
        public virtual ICollection<UserArea> UserAreas { get; set; }
    }
}
