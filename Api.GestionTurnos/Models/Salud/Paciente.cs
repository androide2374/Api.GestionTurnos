using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Paciente
    {
        public Paciente()
        {
            Antibioticos = new HashSet<Antibiotico>();
            AtencionMedicaHistorialCes = new HashSet<AtencionMedicaHistorialCe>();
            AtencionMedicaHistorials = new HashSet<AtencionMedicaHistorial>();
            CamasHistorials = new HashSet<CamasHistorial>();
            ClasificacionDeRiesgoHistorials = new HashSet<ClasificacionDeRiesgoHistorial>();
            Cultivos = new HashSet<Cultivo>();
            Epicrises = new HashSet<Epicrisis>();
            EstadoHistorials = new HashSet<EstadoHistorial>();
            ExternoCardiologia = new HashSet<ExternoCardiologium>();
            ExternoClinicoAdultos = new HashSet<ExternoClinicoAdulto>();
            ExternoClinicoPediatras = new HashSet<ExternoClinicoPediatra>();
            ExternoDiabetologia = new HashSet<ExternoDiabetologium>();
            ExternoEcoCardiografia = new HashSet<ExternoEcoCardiografium>();
            ExternoEcografia = new HashSet<ExternoEcografium>();
            ExternoElectrocardiogramas = new HashSet<ExternoElectrocardiograma>();
            ExternoGastroenterologia = new HashSet<ExternoGastroenterologium>();
            ExternoGinecologia = new HashSet<ExternoGinecologium>();
            ExternoLaboratorioPs = new HashSet<ExternoLaboratorioP>();
            ExternoLaboratorios = new HashSet<ExternoLaboratorio>();
            ExternoRayosXes = new HashSet<ExternoRayosX>();
            ExternoRayosXps = new HashSet<ExternoRayosXp>();
            ExternoTomografia = new HashSet<ExternoTomografium>();
            ExternoTomografiaPs = new HashSet<ExternoTomografiaP>();
            ExternoTraumatologia = new HashSet<ExternoTraumatologium>();
            ExternoUrologia = new HashSet<ExternoUrologium>();
            FarPrescripcionCabs = new HashSet<FarPrescripcionCab>();
            FichaIngresos = new HashSet<FichaIngreso>();
            GlasgowHistoricos = new HashSet<GlasgowHistorico>();
            Indicaciones = new HashSet<Indicacione>();
            Internaciones = new HashSet<Internacione>();
            IrabHistorials = new HashSet<IrabHistorial>();
            Llamadors = new HashSet<Llamador>();
            Medicamentos = new HashSet<Medicamento>();
            Neonatologia = new HashSet<Neonatologium>();
            Observaciones = new HashSet<Observacione>();
            Paralelos = new HashSet<Paralelo>();
            PediatriaHistorialCes = new HashSet<PediatriaHistorialCe>();
            PediatriaHistorials = new HashSet<PediatriaHistorial>();
            Phps = new HashSet<Php>();
            Procedimientos = new HashSet<Procedimiento>();
            Quirofanos = new HashSet<Quirofano>();
            SedacionAnalgesia = new HashSet<SedacionAnalgesium>();
            ShockRooms = new HashSet<ShockRoom>();
            Terapia = new HashSet<Terapium>();
            Tocoginecologia = new HashSet<Tocoginecologium>();
            Traumatologia = new HashSet<Traumatologium>();
            UtiCes = new HashSet<UtiCe>();
            Utis = new HashSet<Uti>();
        }

        public Guid Orid { get; set; }
        public int? NroCarnet { get; set; }
        public bool? Titular { get; set; }
        public decimal? Peso { get; set; }
        public int? Altura { get; set; }
        public bool? Discapacitado { get; set; }
        public int? Edad { get; set; }
        public Guid IdObraSocial { get; set; }
        public Guid? IdPersona { get; set; }
        public Guid? IdNn { get; set; }
        public string Imc { get; set; }

        public virtual Nn IdNnNavigation { get; set; }
        public virtual ObraSocial IdObraSocialNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Antibiotico> Antibioticos { get; set; }
        public virtual ICollection<AtencionMedicaHistorialCe> AtencionMedicaHistorialCes { get; set; }
        public virtual ICollection<AtencionMedicaHistorial> AtencionMedicaHistorials { get; set; }
        public virtual ICollection<CamasHistorial> CamasHistorials { get; set; }
        public virtual ICollection<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
        public virtual ICollection<Cultivo> Cultivos { get; set; }
        public virtual ICollection<Epicrisis> Epicrises { get; set; }
        public virtual ICollection<EstadoHistorial> EstadoHistorials { get; set; }
        public virtual ICollection<ExternoCardiologium> ExternoCardiologia { get; set; }
        public virtual ICollection<ExternoClinicoAdulto> ExternoClinicoAdultos { get; set; }
        public virtual ICollection<ExternoClinicoPediatra> ExternoClinicoPediatras { get; set; }
        public virtual ICollection<ExternoDiabetologium> ExternoDiabetologia { get; set; }
        public virtual ICollection<ExternoEcoCardiografium> ExternoEcoCardiografia { get; set; }
        public virtual ICollection<ExternoEcografium> ExternoEcografia { get; set; }
        public virtual ICollection<ExternoElectrocardiograma> ExternoElectrocardiogramas { get; set; }
        public virtual ICollection<ExternoGastroenterologium> ExternoGastroenterologia { get; set; }
        public virtual ICollection<ExternoGinecologium> ExternoGinecologia { get; set; }
        public virtual ICollection<ExternoLaboratorioP> ExternoLaboratorioPs { get; set; }
        public virtual ICollection<ExternoLaboratorio> ExternoLaboratorios { get; set; }
        public virtual ICollection<ExternoRayosX> ExternoRayosXes { get; set; }
        public virtual ICollection<ExternoRayosXp> ExternoRayosXps { get; set; }
        public virtual ICollection<ExternoTomografium> ExternoTomografia { get; set; }
        public virtual ICollection<ExternoTomografiaP> ExternoTomografiaPs { get; set; }
        public virtual ICollection<ExternoTraumatologium> ExternoTraumatologia { get; set; }
        public virtual ICollection<ExternoUrologium> ExternoUrologia { get; set; }
        public virtual ICollection<FarPrescripcionCab> FarPrescripcionCabs { get; set; }
        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
        public virtual ICollection<GlasgowHistorico> GlasgowHistoricos { get; set; }
        public virtual ICollection<Indicacione> Indicaciones { get; set; }
        public virtual ICollection<Internacione> Internaciones { get; set; }
        public virtual ICollection<IrabHistorial> IrabHistorials { get; set; }
        public virtual ICollection<Llamador> Llamadors { get; set; }
        public virtual ICollection<Medicamento> Medicamentos { get; set; }
        public virtual ICollection<Neonatologium> Neonatologia { get; set; }
        public virtual ICollection<Observacione> Observaciones { get; set; }
        public virtual ICollection<Paralelo> Paralelos { get; set; }
        public virtual ICollection<PediatriaHistorialCe> PediatriaHistorialCes { get; set; }
        public virtual ICollection<PediatriaHistorial> PediatriaHistorials { get; set; }
        public virtual ICollection<Php> Phps { get; set; }
        public virtual ICollection<Procedimiento> Procedimientos { get; set; }
        public virtual ICollection<Quirofano> Quirofanos { get; set; }
        public virtual ICollection<SedacionAnalgesium> SedacionAnalgesia { get; set; }
        public virtual ICollection<ShockRoom> ShockRooms { get; set; }
        public virtual ICollection<Terapium> Terapia { get; set; }
        public virtual ICollection<Tocoginecologium> Tocoginecologia { get; set; }
        public virtual ICollection<Traumatologium> Traumatologia { get; set; }
        public virtual ICollection<UtiCe> UtiCes { get; set; }
        public virtual ICollection<Uti> Utis { get; set; }
    }
}
