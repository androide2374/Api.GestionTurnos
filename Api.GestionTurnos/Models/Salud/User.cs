using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class User
    {
        public User()
        {
            Antibioticos = new HashSet<Antibiotico>();
            AtencionMedicaHistorialCes = new HashSet<AtencionMedicaHistorialCe>();
            AtencionMedicaHistorials = new HashSet<AtencionMedicaHistorial>();
            ClasificacionDeRiesgoHistorials = new HashSet<ClasificacionDeRiesgoHistorial>();
            Cultivos = new HashSet<Cultivo>();
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
            FarRemitoCabs = new HashSet<FarRemitoCab>();
            FichaIngresos = new HashSet<FichaIngreso>();
            Indicaciones = new HashSet<Indicacione>();
            Internaciones = new HashSet<Internacione>();
            InternacionesEnfermeria = new HashSet<InternacionesEnfermerium>();
            IrabHistorials = new HashSet<IrabHistorial>();
            Medicamentos = new HashSet<Medicamento>();
            Neonatologia = new HashSet<Neonatologium>();
            Observaciones = new HashSet<Observacione>();
            ObservacionesEnfermeria = new HashSet<ObservacionesEnfermerium>();
            Paralelos = new HashSet<Paralelo>();
            ParteAnestesista = new HashSet<ParteAnestesistum>();
            ParteInstrumentadors = new HashSet<ParteInstrumentador>();
            PediatriaHistorialCes = new HashSet<PediatriaHistorialCe>();
            PediatriaHistorials = new HashSet<PediatriaHistorial>();
            Phps = new HashSet<Php>();
            Procedimientos = new HashSet<Procedimiento>();
            Quirofanos = new HashSet<Quirofano>();
            SedacionAnalgesia = new HashSet<SedacionAnalgesium>();
            ShockRoomEnfermeria = new HashSet<ShockRoomEnfermerium>();
            ShockRooms = new HashSet<ShockRoom>();
            Terapia = new HashSet<Terapium>();
            TerapiaEnfermeria = new HashSet<TerapiaEnfermerium>();
            Tocoginecologia = new HashSet<Tocoginecologium>();
            Traumatologia = new HashSet<Traumatologium>();
            TurDedicacions = new HashSet<TurDedicacion>();
            UserAreas = new HashSet<UserArea>();
            UserEspecialidads = new HashSet<UserEspecialidad>();
            UserRols = new HashSet<UserRol>();
            UtiCes = new HashSet<UtiCe>();
            Utis = new HashSet<Uti>();
        }

        public long UserId { get; set; }
        public string Usuario { get; set; }
        public string PasswordHash { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Matricula { get; set; }
        public bool? Visitas { get; set; }
        public bool Active { get; set; }
        public string Foto { get; set; }
        public Guid IdEnte { get; set; }
        public bool? EsInterno { get; set; }

        public virtual Ente IdEnteNavigation { get; set; }
        public virtual ICollection<Antibiotico> Antibioticos { get; set; }
        public virtual ICollection<AtencionMedicaHistorialCe> AtencionMedicaHistorialCes { get; set; }
        public virtual ICollection<AtencionMedicaHistorial> AtencionMedicaHistorials { get; set; }
        public virtual ICollection<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
        public virtual ICollection<Cultivo> Cultivos { get; set; }
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
        public virtual ICollection<FarRemitoCab> FarRemitoCabs { get; set; }
        public virtual ICollection<FichaIngreso> FichaIngresos { get; set; }
        public virtual ICollection<Indicacione> Indicaciones { get; set; }
        public virtual ICollection<Internacione> Internaciones { get; set; }
        public virtual ICollection<InternacionesEnfermerium> InternacionesEnfermeria { get; set; }
        public virtual ICollection<IrabHistorial> IrabHistorials { get; set; }
        public virtual ICollection<Medicamento> Medicamentos { get; set; }
        public virtual ICollection<Neonatologium> Neonatologia { get; set; }
        public virtual ICollection<Observacione> Observaciones { get; set; }
        public virtual ICollection<ObservacionesEnfermerium> ObservacionesEnfermeria { get; set; }
        public virtual ICollection<Paralelo> Paralelos { get; set; }
        public virtual ICollection<ParteAnestesistum> ParteAnestesista { get; set; }
        public virtual ICollection<ParteInstrumentador> ParteInstrumentadors { get; set; }
        public virtual ICollection<PediatriaHistorialCe> PediatriaHistorialCes { get; set; }
        public virtual ICollection<PediatriaHistorial> PediatriaHistorials { get; set; }
        public virtual ICollection<Php> Phps { get; set; }
        public virtual ICollection<Procedimiento> Procedimientos { get; set; }
        public virtual ICollection<Quirofano> Quirofanos { get; set; }
        public virtual ICollection<SedacionAnalgesium> SedacionAnalgesia { get; set; }
        public virtual ICollection<ShockRoomEnfermerium> ShockRoomEnfermeria { get; set; }
        public virtual ICollection<ShockRoom> ShockRooms { get; set; }
        public virtual ICollection<Terapium> Terapia { get; set; }
        public virtual ICollection<TerapiaEnfermerium> TerapiaEnfermeria { get; set; }
        public virtual ICollection<Tocoginecologium> Tocoginecologia { get; set; }
        public virtual ICollection<Traumatologium> Traumatologia { get; set; }
        public virtual ICollection<TurDedicacion> TurDedicacions { get; set; }
        public virtual ICollection<UserArea> UserAreas { get; set; }
        public virtual ICollection<UserEspecialidad> UserEspecialidads { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
        public virtual ICollection<UtiCe> UtiCes { get; set; }
        public virtual ICollection<Uti> Utis { get; set; }
    }
}
