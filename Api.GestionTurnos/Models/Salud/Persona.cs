using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Persona
    {
        public Persona()
        {
            FichaIngresos = new HashSet<FichaIngreso>();
            Pacientes = new HashSet<Paciente>();
        }

        public Guid Orid { get; set; }
        public string Documento { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string Calle { get; set; }
        public int? Altura { get; set; }
        public string Depto { get; set; }
        public int? Piso { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Mail { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public Guid IdSexo { get; set; }
        public Guid IdLocalidad { get; set; }
        public Guid IdTipoDocumento { get; set; }
        public Guid IdEstadoCivil { get; set; }
        public Guid IdGrupoSanguineo { get; set; }
        public Guid? IdProfesion { get; set; }

        public virtual EstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual GrupoSanguineo IdGrupoSanguineoNavigation { get; set; }
        public virtual Localidad IdLocalidadNavigation { get; set; }
        public virtual Profesion IdProfesionNavigation { get; set; }
        public virtual Sexo IdSexoNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
