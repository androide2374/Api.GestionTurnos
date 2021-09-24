using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class Diagnostico
    {
        public Diagnostico()
        {
            AtencionMedicaHistorialCeIdDiagPrimNavigations = new HashSet<AtencionMedicaHistorialCe>();
            AtencionMedicaHistorialCeIdDiagSecNavigations = new HashSet<AtencionMedicaHistorialCe>();
            AtencionMedicaHistorialIdDiagPrimNavigations = new HashSet<AtencionMedicaHistorial>();
            AtencionMedicaHistorialIdDiagSecNavigations = new HashSet<AtencionMedicaHistorial>();
            EpicrisisIdDiagnosticoEgresoNavigations = new HashSet<Epicrisis>();
            EpicrisisIdDiagnosticoIngresoNavigations = new HashSet<Epicrisis>();
            ExternoCardiologia = new HashSet<ExternoCardiologium>();
            ExternoClinicoAdultos = new HashSet<ExternoClinicoAdulto>();
            ExternoClinicoPediatras = new HashSet<ExternoClinicoPediatra>();
            ExternoDiabetologia = new HashSet<ExternoDiabetologium>();
            ExternoEcoCardiografia = new HashSet<ExternoEcoCardiografium>();
            ExternoEcografia = new HashSet<ExternoEcografium>();
            ExternoGastroenterologia = new HashSet<ExternoGastroenterologium>();
            ExternoGinecologia = new HashSet<ExternoGinecologium>();
            ExternoLaboratorios = new HashSet<ExternoLaboratorio>();
            ExternoRayosXes = new HashSet<ExternoRayosX>();
            ExternoTomografia = new HashSet<ExternoTomografium>();
            ExternoTraumatologia = new HashSet<ExternoTraumatologium>();
            ExternoUrologia = new HashSet<ExternoUrologium>();
            IrabHistorialIdDiagPrimNavigations = new HashSet<IrabHistorial>();
            IrabHistorialIdDiagSecNavigations = new HashSet<IrabHistorial>();
            NeonatologiumIdDiagPrimNavigations = new HashSet<Neonatologium>();
            NeonatologiumIdDiagSecNavigations = new HashSet<Neonatologium>();
            ObservacioneIdDiagPrimNavigations = new HashSet<Observacione>();
            ObservacioneIdDiagSecNavigations = new HashSet<Observacione>();
            PediatriaHistorialCeIdDiagPrimNavigations = new HashSet<PediatriaHistorialCe>();
            PediatriaHistorialCeIdDiagSecNavigations = new HashSet<PediatriaHistorialCe>();
            PediatriaHistorialIdDiagPrimNavigations = new HashSet<PediatriaHistorial>();
            PediatriaHistorialIdDiagSecNavigations = new HashSet<PediatriaHistorial>();
            ProcedimientoIdDiagPrimNavigations = new HashSet<Procedimiento>();
            ProcedimientoIdDiagSecNavigations = new HashSet<Procedimiento>();
            ShockRoomIdDiagPrimNavigations = new HashSet<ShockRoom>();
            ShockRoomIdDiagSecNavigations = new HashSet<ShockRoom>();
            TerapiumIdDiagPrimNavigations = new HashSet<Terapium>();
            TerapiumIdDiagSecNavigations = new HashSet<Terapium>();
            TocoginecologiumIdDiagPrimNavigations = new HashSet<Tocoginecologium>();
            TocoginecologiumIdDiagSecNavigations = new HashSet<Tocoginecologium>();
            TraumatologiumIdDiagPrimNavigations = new HashSet<Traumatologium>();
            TraumatologiumIdDiagSecNavigations = new HashSet<Traumatologium>();
        }

        public Guid Orid { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public Guid IdTipoDiagnostico { get; set; }

        public virtual TipoDiagnostico IdTipoDiagnosticoNavigation { get; set; }
        public virtual ICollection<AtencionMedicaHistorialCe> AtencionMedicaHistorialCeIdDiagPrimNavigations { get; set; }
        public virtual ICollection<AtencionMedicaHistorialCe> AtencionMedicaHistorialCeIdDiagSecNavigations { get; set; }
        public virtual ICollection<AtencionMedicaHistorial> AtencionMedicaHistorialIdDiagPrimNavigations { get; set; }
        public virtual ICollection<AtencionMedicaHistorial> AtencionMedicaHistorialIdDiagSecNavigations { get; set; }
        public virtual ICollection<Epicrisis> EpicrisisIdDiagnosticoEgresoNavigations { get; set; }
        public virtual ICollection<Epicrisis> EpicrisisIdDiagnosticoIngresoNavigations { get; set; }
        public virtual ICollection<ExternoCardiologium> ExternoCardiologia { get; set; }
        public virtual ICollection<ExternoClinicoAdulto> ExternoClinicoAdultos { get; set; }
        public virtual ICollection<ExternoClinicoPediatra> ExternoClinicoPediatras { get; set; }
        public virtual ICollection<ExternoDiabetologium> ExternoDiabetologia { get; set; }
        public virtual ICollection<ExternoEcoCardiografium> ExternoEcoCardiografia { get; set; }
        public virtual ICollection<ExternoEcografium> ExternoEcografia { get; set; }
        public virtual ICollection<ExternoGastroenterologium> ExternoGastroenterologia { get; set; }
        public virtual ICollection<ExternoGinecologium> ExternoGinecologia { get; set; }
        public virtual ICollection<ExternoLaboratorio> ExternoLaboratorios { get; set; }
        public virtual ICollection<ExternoRayosX> ExternoRayosXes { get; set; }
        public virtual ICollection<ExternoTomografium> ExternoTomografia { get; set; }
        public virtual ICollection<ExternoTraumatologium> ExternoTraumatologia { get; set; }
        public virtual ICollection<ExternoUrologium> ExternoUrologia { get; set; }
        public virtual ICollection<IrabHistorial> IrabHistorialIdDiagPrimNavigations { get; set; }
        public virtual ICollection<IrabHistorial> IrabHistorialIdDiagSecNavigations { get; set; }
        public virtual ICollection<Neonatologium> NeonatologiumIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Neonatologium> NeonatologiumIdDiagSecNavigations { get; set; }
        public virtual ICollection<Observacione> ObservacioneIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Observacione> ObservacioneIdDiagSecNavigations { get; set; }
        public virtual ICollection<PediatriaHistorialCe> PediatriaHistorialCeIdDiagPrimNavigations { get; set; }
        public virtual ICollection<PediatriaHistorialCe> PediatriaHistorialCeIdDiagSecNavigations { get; set; }
        public virtual ICollection<PediatriaHistorial> PediatriaHistorialIdDiagPrimNavigations { get; set; }
        public virtual ICollection<PediatriaHistorial> PediatriaHistorialIdDiagSecNavigations { get; set; }
        public virtual ICollection<Procedimiento> ProcedimientoIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Procedimiento> ProcedimientoIdDiagSecNavigations { get; set; }
        public virtual ICollection<ShockRoom> ShockRoomIdDiagPrimNavigations { get; set; }
        public virtual ICollection<ShockRoom> ShockRoomIdDiagSecNavigations { get; set; }
        public virtual ICollection<Terapium> TerapiumIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Terapium> TerapiumIdDiagSecNavigations { get; set; }
        public virtual ICollection<Tocoginecologium> TocoginecologiumIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Tocoginecologium> TocoginecologiumIdDiagSecNavigations { get; set; }
        public virtual ICollection<Traumatologium> TraumatologiumIdDiagPrimNavigations { get; set; }
        public virtual ICollection<Traumatologium> TraumatologiumIdDiagSecNavigations { get; set; }
    }
}
