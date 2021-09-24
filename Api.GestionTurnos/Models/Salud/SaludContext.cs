using System;
using Api.GestionTurnos.Models.ModelSaludContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Api.GestionTurnos.Models.Salud
{
    public partial class SaludContext : DbContext
    {
        public SaludContext()
        {
        }

        public SaludContext(DbContextOptions<SaludContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TurnosSalud> TurnosSaluds { get; set; }
        public virtual DbSet<AnexoSamo> AnexoSamos { get; set; }
        public virtual DbSet<Antibiotico> Antibioticos { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AtencionMedicaHistorial> AtencionMedicaHistorials { get; set; }
        public virtual DbSet<AtencionMedicaHistorialCe> AtencionMedicaHistorialCes { get; set; }
        public virtual DbSet<BonosAdmision> BonosAdmisions { get; set; }
        public virtual DbSet<BonosAdmisionbak> BonosAdmisionbaks { get; set; }
        public virtual DbSet<BonosTemp> BonosTemps { get; set; }
        public virtual DbSet<Buscador> Buscadors { get; set; }
        public virtual DbSet<Calle> Calles { get; set; }
        public virtual DbSet<Cama> Camas { get; set; }
        public virtual DbSet<CamaEstado> CamaEstados { get; set; }
        public virtual DbSet<CamasHistorial> CamasHistorials { get; set; }
        public virtual DbSet<ClasificacionDeRiesgoHistorial> ClasificacionDeRiesgoHistorials { get; set; }
        public virtual DbSet<ComoLlego> ComoLlegos { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Cultivo> Cultivos { get; set; }
        public virtual DbSet<Dedicacion> Dedicacions { get; set; }
        public virtual DbSet<Derivacion> Derivacions { get; set; }
        public virtual DbSet<Dia> Dias { get; set; }
        public virtual DbSet<Diagnostico> Diagnosticos { get; set; }
        public virtual DbSet<Dieta> Dietas { get; set; }
        public virtual DbSet<Ente> Entes { get; set; }
        public virtual DbSet<EnteEspecialidad> EnteEspecialidads { get; set; }
        public virtual DbSet<Epicrisis> Epicrises { get; set; }
        public virtual DbSet<EpicrisisFinal> EpicrisisFinals { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<EspecialidadQuirurgica> EspecialidadQuirurgicas { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }
        public virtual DbSet<EstadoHistorial> EstadoHistorials { get; set; }
        public virtual DbSet<EstadoHistorialDeleteFacilitadore> EstadoHistorialDeleteFacilitadores { get; set; }
        public virtual DbSet<ExternoCardiologium> ExternoCardiologia { get; set; }
        public virtual DbSet<ExternoClinicoAdulto> ExternoClinicoAdultos { get; set; }
        public virtual DbSet<ExternoClinicoPediatra> ExternoClinicoPediatras { get; set; }
        public virtual DbSet<ExternoDiabetologium> ExternoDiabetologia { get; set; }
        public virtual DbSet<ExternoEcoCardiografium> ExternoEcoCardiografia { get; set; }
        public virtual DbSet<ExternoEcografium> ExternoEcografia { get; set; }
        public virtual DbSet<ExternoElectrocardiograma> ExternoElectrocardiogramas { get; set; }
        public virtual DbSet<ExternoGastroenterologium> ExternoGastroenterologia { get; set; }
        public virtual DbSet<ExternoGinecologium> ExternoGinecologia { get; set; }
        public virtual DbSet<ExternoLaboratorio> ExternoLaboratorios { get; set; }
        public virtual DbSet<ExternoLaboratorioP> ExternoLaboratorioPs { get; set; }
        public virtual DbSet<ExternoLaboratorioPractica> ExternoLaboratorioPracticas { get; set; }
        public virtual DbSet<ExternoRayosPractica> ExternoRayosPracticas { get; set; }
        public virtual DbSet<ExternoRayosX> ExternoRayosXes { get; set; }
        public virtual DbSet<ExternoRayosXp> ExternoRayosXps { get; set; }
        public virtual DbSet<ExternoTomografiaP> ExternoTomografiaPs { get; set; }
        public virtual DbSet<ExternoTomografiaPractica> ExternoTomografiaPracticas { get; set; }
        public virtual DbSet<ExternoTomografium> ExternoTomografia { get; set; }
        public virtual DbSet<ExternoTraumatologium> ExternoTraumatologia { get; set; }
        public virtual DbSet<ExternoUrologium> ExternoUrologia { get; set; }
        public virtual DbSet<FarCapacidad> FarCapacidads { get; set; }
        public virtual DbSet<FarCategorium> FarCategoria { get; set; }
        public virtual DbSet<FarConcentracion> FarConcentracions { get; set; }
        public virtual DbSet<FarContenido> FarContenidos { get; set; }
        public virtual DbSet<FarEmpaque> FarEmpaques { get; set; }
        public virtual DbSet<FarFabricante> FarFabricantes { get; set; }
        public virtual DbSet<FarFarmacium> FarFarmacia { get; set; }
        public virtual DbSet<FarFormaFarmaceutica> FarFormaFarmaceuticas { get; set; }
        public virtual DbSet<FarInsumo> FarInsumos { get; set; }
        public virtual DbSet<FarInsumosVinculado> FarInsumosVinculados { get; set; }
        public virtual DbSet<FarMarca> FarMarcas { get; set; }
        public virtual DbSet<FarPeriodicidad> FarPeriodicidads { get; set; }
        public virtual DbSet<FarPeriodoUnidad> FarPeriodoUnidads { get; set; }
        public virtual DbSet<FarPrescipcionDet> FarPrescipcionDets { get; set; }
        public virtual DbSet<FarPrescripcionCab> FarPrescripcionCabs { get; set; }
        public virtual DbSet<FarPresentacion> FarPresentacions { get; set; }
        public virtual DbSet<FarProveedor> FarProveedors { get; set; }
        public virtual DbSet<FarRemitoCab> FarRemitoCabs { get; set; }
        public virtual DbSet<FarRemitoDet> FarRemitoDets { get; set; }
        public virtual DbSet<FarRemitoEstado> FarRemitoEstados { get; set; }
        public virtual DbSet<FarStock> FarStocks { get; set; }
        public virtual DbSet<Feriado> Feriados { get; set; }
        public virtual DbSet<FichaIngreso> FichaIngresos { get; set; }
        public virtual DbSet<GlasgowHistorico> GlasgowHistoricos { get; set; }
        public virtual DbSet<GrupoAtencionSimultanea> GrupoAtencionSimultaneas { get; set; }
        public virtual DbSet<GrupoSanguineo> GrupoSanguineos { get; set; }
        public virtual DbSet<Imagen> Imagens { get; set; }
        public virtual DbSet<Indicacione> Indicaciones { get; set; }
        public virtual DbSet<Internacione> Internaciones { get; set; }
        public virtual DbSet<InternacionesEnfermerium> InternacionesEnfermeria { get; set; }
        public virtual DbSet<InternacionesTemp> InternacionesTemps { get; set; }
        public virtual DbSet<IrabHistorial> IrabHistorials { get; set; }
        public virtual DbSet<LaboratorioPractica> LaboratorioPracticas { get; set; }
        public virtual DbSet<LaboratorioPracticaSolicitud> LaboratorioPracticaSolicituds { get; set; }
        public virtual DbSet<LaboratorioSolicitudHistorial> LaboratorioSolicitudHistorials { get; set; }
        public virtual DbSet<Llamador> Llamadors { get; set; }
        public virtual DbSet<Localidad> Localidads { get; set; }
        public virtual DbSet<Localidade> Localidades { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Medicamento> Medicamentos { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Modalidad> Modalidads { get; set; }
        public virtual DbSet<MotivoConsultum> MotivoConsulta { get; set; }
        public virtual DbSet<Neonatologium> Neonatologia { get; set; }
        public virtual DbSet<NivelDeConciencium> NivelDeConciencia { get; set; }
        public virtual DbSet<Nn> Nns { get; set; }
        public virtual DbSet<ObraSocial> ObraSocials { get; set; }
        public virtual DbSet<Observacione> Observaciones { get; set; }
        public virtual DbSet<ObservacionesEnfermerium> ObservacionesEnfermeria { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Paralelo> Paralelos { get; set; }
        public virtual DbSet<ParteAnestesistum> ParteAnestesista { get; set; }
        public virtual DbSet<ParteInstrumentador> ParteInstrumentadors { get; set; }
        public virtual DbSet<Partido> Partidos { get; set; }
        public virtual DbSet<PartidosAtendido> PartidosAtendidos { get; set; }
        public virtual DbSet<PediatriaHistorial> PediatriaHistorials { get; set; }
        public virtual DbSet<PediatriaHistorialCe> PediatriaHistorialCes { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaTurno> PersonaTurnos { get; set; }
        public virtual DbSet<PersonaTurnosp> PersonaTurnosps { get; set; }
        public virtual DbSet<Php> Phps { get; set; }
        public virtual DbSet<PracticaEnfermerium> PracticaEnfermeria { get; set; }
        public virtual DbSet<Procedimiento> Procedimientos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Profesion> Profesions { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }
        public virtual DbSet<Puesto> Puestos { get; set; }
        public virtual DbSet<Quirofano> Quirofanos { get; set; }
        public virtual DbSet<Reporte> Reportes { get; set; }
        public virtual DbSet<ReportesRol> ReportesRols { get; set; }
        public virtual DbSet<RespuestasGlasgow> RespuestasGlasgows { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolRule> RolRules { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<RxPractica> RxPracticas { get; set; }
        public virtual DbSet<RxPracticaSolicitud> RxPracticaSolicituds { get; set; }
        public virtual DbSet<RxSolicitudHistorial> RxSolicitudHistorials { get; set; }
        public virtual DbSet<SedacionAnalgesium> SedacionAnalgesia { get; set; }
        public virtual DbSet<Seguimiento> Seguimientos { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<ShockRoom> ShockRooms { get; set; }
        public virtual DbSet<ShockRoomEnfermerium> ShockRoomEnfermeria { get; set; }
        public virtual DbSet<TempHoja20Base> TempHoja20Bases { get; set; }
        public virtual DbSet<TempHoja20TotalesRango> TempHoja20TotalesRangos { get; set; }
        public virtual DbSet<TempHoja21Base> TempHoja21Bases { get; set; }
        public virtual DbSet<TempHoja21TotalesArea> TempHoja21TotalesAreas { get; set; }
        public virtual DbSet<TempHoja21TotalesRango> TempHoja21TotalesRangos { get; set; }
        public virtual DbSet<TerapiaEnfermerium> TerapiaEnfermeria { get; set; }
        public virtual DbSet<Terapium> Terapia { get; set; }
        public virtual DbSet<TipoAtencion> TipoAtencions { get; set; }
        public virtual DbSet<TipoBono> TipoBonos { get; set; }
        public virtual DbSet<TipoCaso> TipoCasos { get; set; }
        public virtual DbSet<TipoClasificacionDeRiesgo> TipoClasificacionDeRiesgos { get; set; }
        public virtual DbSet<TipoContacto> TipoContactos { get; set; }
        public virtual DbSet<TipoDiagnostico> TipoDiagnosticos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoEnte> TipoEntes { get; set; }
        public virtual DbSet<TipoEstado> TipoEstados { get; set; }
        public virtual DbSet<TipoMedicamento> TipoMedicamentos { get; set; }
        public virtual DbSet<TipoNutricion> TipoNutricions { get; set; }
        public virtual DbSet<TipoRecepcion> TipoRecepcions { get; set; }
        public virtual DbSet<TipoRecepcionBono> TipoRecepcionBonos { get; set; }
        public virtual DbSet<TipoSolucion> TipoSolucions { get; set; }
        public virtual DbSet<TipoVacuna> TipoVacunas { get; set; }
        public virtual DbSet<Tocoginecologium> Tocoginecologia { get; set; }
        public virtual DbSet<TomogPractica> TomogPracticas { get; set; }
        public virtual DbSet<TomogPracticaSolicitud> TomogPracticaSolicituds { get; set; }
        public virtual DbSet<TomogSolicitudHistorial> TomogSolicitudHistorials { get; set; }
        public virtual DbSet<Traumatologium> Traumatologia { get; set; }
        public virtual DbSet<TurBono> TurBonos { get; set; }
        public virtual DbSet<TurDedicacion> TurDedicacions { get; set; }
        public virtual DbSet<TurDiasEspeciale> TurDiasEspeciales { get; set; }
        public virtual DbSet<TurDiasNoLaborable> TurDiasNoLaborables { get; set; }
        public virtual DbSet<TurStatus> TurStatuses { get; set; }
        public virtual DbSet<TurTipoTurno> TurTipoTurnos { get; set; }
        public virtual DbSet<TurTurno> TurTurnos { get; set; }
        public virtual DbSet<TurTurnoBk> TurTurnoBks { get; set; }
        public virtual DbSet<TurTurnoCancelado> TurTurnoCancelados { get; set; }
        public virtual DbSet<TurTurnoNoConfirmado> TurTurnoNoConfirmados { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserArea> UserAreas { get; set; }
        public virtual DbSet<UserEspecialidad> UserEspecialidads { get; set; }
        public virtual DbSet<UserRol> UserRols { get; set; }
        public virtual DbSet<Uti> Utis { get; set; }
        public virtual DbSet<UtiCe> UtiCes { get; set; }
        public virtual DbSet<VAtencionHistorial> VAtencionHistorials { get; set; }
        public virtual DbSet<VAtencionHistorialCe> VAtencionHistorialCes { get; set; }
        public virtual DbSet<VAtencionHistorialEx> VAtencionHistorialices { get; set; }
        public virtual DbSet<VEnfermeria> VEnfermerias { get; set; }
        public virtual DbSet<VHistorial> VHistorials { get; set; }
        public virtual DbSet<VInternacionesGle> VInternacionesGles { get; set; }
        public virtual DbSet<VPacientesBaja> VPacientesBajas { get; set; }
        public virtual DbSet<VacunaXdiaBkp> VacunaXdiaBkps { get; set; }
        public virtual DbSet<VacunaXdium> VacunaXdia { get; set; }
        public virtual DbSet<VariablesGlasgow> VariablesGlasgows { get; set; }
        public virtual DbSet<ViewEstadoHistorial> ViewEstadoHistorials { get; set; }
        public virtual DbSet<Visor> Visors { get; set; }
        public virtual DbSet<VisorA> VisorAs { get; set; }
        public virtual DbSet<VisorE> VisorEs { get; set; }
        public virtual DbSet<VisorVicenteLopez> VisorVicenteLopezs { get; set; }
        public virtual DbSet<Vium> Via { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TRJ1ED3\\Localhost;Database=Salud;user id=sa;password=ivan2374");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TurnosSalud>(entity =>
            {
                entity.HasKey(e => e.IdTurno);
            });

            modelBuilder.Entity<AnexoSamo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("AnexoSamo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Antibiotico>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Dosis)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Droga)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Antibioticos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Antibioticos_Area");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Antibioticos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Antibioticos_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Antibioticos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Antibioticos_User");

                entity.HasOne(d => d.IdViaNavigation)
                    .WithMany(p => p.Antibioticos)
                    .HasForeignKey(d => d.IdVia)
                    .HasConstraintName("FK_Antibioticos_Via");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Area");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_Ente");

                entity.HasOne(d => d.IdTipoRecepcionNavigation)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.IdTipoRecepcion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Area_TipoRecepcion");
            });

            modelBuilder.Entity<AtencionMedicaHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_AtencionMedica");

                entity.ToTable("AtencionMedicaHistorial");

                entity.HasIndex(e => e.IdPaciente, "Index_AtencionMedicaHistorial_IdPaciente");

                entity.HasIndex(e => e.IdUsuario, "Index_AtencionMedicaHistorial_IdUsuario");

                entity.HasIndex(e => e.Fecha, "Index_IdDiagPrim_IdPaciente_IdArea");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorial_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_AtencionMedicaHistorial_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.AtencionMedicaHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorial_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AtencionMedicaHistorials)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorial_User");
            });

            modelBuilder.Entity<AtencionMedicaHistorialCe>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_AtencionMedicaCE");

                entity.ToTable("AtencionMedicaHistorialCE");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialCeIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorialCE_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialCeIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_AtencionMedicaHistorialCE_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialCes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorialCE_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AtencionMedicaHistorialCes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AtencionMedicaHistorialCE_User");
            });

            modelBuilder.Entity<BonosAdmision>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("BonosAdmision");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Numero).HasMaxLength(50);

                entity.Property(e => e.Valor).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoBonoNavigation)
                    .WithMany(p => p.BonosAdmisions)
                    .HasForeignKey(d => d.IdTipoBono)
                    .HasConstraintName("FK_BonosAdmision_TipoBono");
            });

            modelBuilder.Entity<BonosAdmisionbak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonosAdmisionbak");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Numero).HasMaxLength(50);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.Valor).HasMaxLength(50);
            });

            modelBuilder.Entity<BonosTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonosTemp");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreNn)
                    .IsUnicode(false)
                    .HasColumnName("NombreNN");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.TipoAdmision)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoBono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Buscador>(entity =>
            {
                entity.ToTable("Buscador");

                entity.Property(e => e.EsVideo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Filtro)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Calle>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.NombreCalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cama>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Camas)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("FK_Camas_Area");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Camas)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Camas_CamaEstado");
            });

            modelBuilder.Entity<CamaEstado>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("CamaEstado");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CamasHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("CamasHistorial");

                entity.HasIndex(e => e.IdPaciente, "Index_PacienteCama");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdCamaNavigation)
                    .WithMany(p => p.CamasHistorials)
                    .HasForeignKey(d => d.IdCama)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CamasHistorial_Camas");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.CamasHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CamasHistorial_Paciente");
            });

            modelBuilder.Entity<ClasificacionDeRiesgoHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ClasificacionDeRiesgoHistorial");

                entity.HasIndex(e => e.IdUsuario, "Index_ClasificacionDeRiesgoHistorial_IdUsuario");

                entity.HasIndex(e => e.Fecha, "Index_FechaIdPaciente");

                entity.HasIndex(e => e.Atendido, "Index_FechaIdPacienteIdTipoClasificacionDeRiesgo");

                entity.HasIndex(e => new { e.IdPaciente, e.Atendido }, "Index_FechaIdTipoClasificacionDeRiesgo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.AlergiasDetalle).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.InyectablesR).IsUnicode(false);

                entity.Property(e => e.Medicamentos).IsUnicode(false);

                entity.Property(e => e.MedicamentosR).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.OtrosDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerimetroCefalico).IsUnicode(false);

                entity.Property(e => e.Sintoma)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.ClasificacionDeRiesgoHistorials)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionDeRiesgoHistorial_Especialidad");

                entity.HasOne(d => d.IdNivelDeConcienciaNavigation)
                    .WithMany(p => p.ClasificacionDeRiesgoHistorials)
                    .HasForeignKey(d => d.IdNivelDeConciencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionDeRiesgoHistorial_NivelDeConciencia");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ClasificacionDeRiesgoHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionDeRiesgoHistorial_Paciente");

                entity.HasOne(d => d.IdTipoClasificacionDeRiesgoNavigation)
                    .WithMany(p => p.ClasificacionDeRiesgoHistorials)
                    .HasForeignKey(d => d.IdTipoClasificacionDeRiesgo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionDeRiesgoHistorial_TipoClasificacionDeRiesgo");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ClasificacionDeRiesgoHistorials)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasificacionDeRiesgoHistorial_User");
            });

            modelBuilder.Entity<ComoLlego>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ComoLlego");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Contacto");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Contactos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacto_Area");

                entity.HasOne(d => d.IdTipoContactoNavigation)
                    .WithMany(p => p.Contactos)
                    .HasForeignKey(d => d.IdTipoContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacto_TipoContacto");
            });

            modelBuilder.Entity<Cultivo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Resultado).IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Cultivos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cultivos_Area");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Cultivos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cultivos_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cultivos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cultivos_User");
            });

            modelBuilder.Entity<Dedicacion>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Dedicacion_1");

                entity.ToTable("Dedicacion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.GrupoAtencionSimultanea)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Derivacion>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_AreaDerivacion");

                entity.ToTable("Derivacion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DescAreaDestino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescAreaOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnte).HasDefaultValueSql("('c83d9976-5d3a-40d9-a04f-9b4642f155f0')");

                entity.HasOne(d => d.IdAreaDestinoNavigation)
                    .WithMany(p => p.DerivacionIdAreaDestinoNavigations)
                    .HasForeignKey(d => d.IdAreaDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Derivacion_Area1");

                entity.HasOne(d => d.IdAreaOrigenNavigation)
                    .WithMany(p => p.DerivacionIdAreaOrigenNavigations)
                    .HasForeignKey(d => d.IdAreaOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Derivacion_Area");

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.Derivacions)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Derivacion_Ente");

                entity.HasOne(d => d.IdTipoEstadoNavigation)
                    .WithMany(p => p.Derivacions)
                    .HasForeignKey(d => d.IdTipoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Derivacion_TipoEstado");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__Dias__A9A8BCD620E2A80C");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnostico>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Diagnostico");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoDiagnosticoNavigation)
                    .WithMany(p => p.Diagnosticos)
                    .HasForeignKey(d => d.IdTipoDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnostico_TipoDiagnostico");
            });

            modelBuilder.Entity<Dieta>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__Dietas__A9A8BCD646BE3831");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ente>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Ente");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('tuvieja.jpg')");

                entity.Property(e => e.Latitud)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitud)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Entes)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ente_Localidad");

                entity.HasOne(d => d.IdTipoEnteNavigation)
                    .WithMany(p => p.Entes)
                    .HasForeignKey(d => d.IdTipoEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ente_TipoEnte");
            });

            modelBuilder.Entity<EnteEspecialidad>(entity =>
            {
                entity.HasKey(e => new { e.IdEspecialidad, e.IdEnte });

                entity.ToTable("EnteEspecialidad");

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.EnteEspecialidads)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnteEspecialidad_Ente");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.EnteEspecialidads)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnteEspecialidad_Especialidad");
            });

            modelBuilder.Entity<Epicrisis>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__Epicrisi__A9A8BCD64A99B60D");

                entity.ToTable("Epicrisis");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.AntecedentesRelevantes)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Destino)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EnfermedadActual).IsUnicode(false);

                entity.Property(e => e.Estudios)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Evolucion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IndicacionesEgreso).IsUnicode(false);

                entity.Property(e => e.Intercurrencias)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoIngreso)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoInternacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TratamientoInstaurado).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoEgresoNavigation)
                    .WithMany(p => p.EpicrisisIdDiagnosticoEgresoNavigations)
                    .HasForeignKey(d => d.IdDiagnosticoEgreso)
                    .HasConstraintName("FK_Epicrisis_DiagnosticoEgreso");

                entity.HasOne(d => d.IdDiagnosticoIngresoNavigation)
                    .WithMany(p => p.EpicrisisIdDiagnosticoIngresoNavigations)
                    .HasForeignKey(d => d.IdDiagnosticoIngreso)
                    .HasConstraintName("FK_Epicrisis_DiagnosticoIngreso");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Epicrises)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Epicrisis_Paciente");
            });

            modelBuilder.Entity<EpicrisisFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Epicrisis_Final");

                entity.Property(e => e.AntecedentesRelevantes).IsUnicode(false);

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.DiagnosticoEgreso).IsUnicode(false);

                entity.Property(e => e.DiagnosticoIngreso).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);

                entity.Property(e => e.Egreso).IsUnicode(false);

                entity.Property(e => e.EnfermedadActual).IsUnicode(false);

                entity.Property(e => e.Estudios).IsUnicode(false);

                entity.Property(e => e.Evolucion).IsUnicode(false);

                entity.Property(e => e.IndicacionesEgreso).IsUnicode(false);

                entity.Property(e => e.Ingreso).IsUnicode(false);

                entity.Property(e => e.Intercurrencias).IsUnicode(false);

                entity.Property(e => e.MotivoIngreso).IsUnicode(false);

                entity.Property(e => e.MotivoInternacion).IsUnicode(false);

                entity.Property(e => e.Nacimiento).IsUnicode(false);

                entity.Property(e => e.ObraSocial).IsUnicode(false);

                entity.Property(e => e.PacienteIndex).IsUnicode(false);

                entity.Property(e => e.Sexo).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Tratamiento).IsUnicode(false);

                entity.Property(e => e.TratamientoInstaurado).IsUnicode(false);
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Especialidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspecialidadQuirurgica>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("EspecialidadQuirurgica");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("EstadoCivil");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("EstadoHistorial");

                entity.HasIndex(e => e.IdPaciente, "Index_Fecha");

                entity.HasIndex(e => e.IdTipoEstado, "Index_FechaPacienteDerivacion");

                entity.HasIndex(e => e.Fecha, "Index_TipoEstadoIdPacienteIdDerivacion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdDerivacionNavigation)
                    .WithMany(p => p.EstadoHistorials)
                    .HasForeignKey(d => d.IdDerivacion)
                    .HasConstraintName("FK_EstadoHistorial_Derivacion");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.EstadoHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_EstadoHistorial_Paciente");

                entity.HasOne(d => d.IdTipoEstadoNavigation)
                    .WithMany(p => p.EstadoHistorials)
                    .HasForeignKey(d => d.IdTipoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstadoHistorial_TipoEstado");
            });

            modelBuilder.Entity<EstadoHistorialDeleteFacilitadore>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("EstadoHistorial_DeleteFacilitadores");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");
            });

            modelBuilder.Entity<ExternoCardiologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoCardiologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoCardiologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoCardiologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoCardiologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoCardiologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoCardiologia_User");
            });

            modelBuilder.Entity<ExternoClinicoAdulto>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoClinicoAdulto");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoClinicoAdultos)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoAdulto_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoClinicoAdultos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoAdulto_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoClinicoAdultos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoAdulto_User");
            });

            modelBuilder.Entity<ExternoClinicoPediatra>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoClinicoPediatra");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoClinicoPediatras)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoPediatra_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoClinicoPediatras)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoPediatra_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoClinicoPediatras)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoClinicoPediatra_User");
            });

            modelBuilder.Entity<ExternoDiabetologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoDiabetologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoDiabetologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoDiabetologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoDiabetologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoDiabetologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoDiabetologia_User");
            });

            modelBuilder.Entity<ExternoEcoCardiografium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoEcoCardiografia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcoCardiografia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoEcoCardiografia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcoCardiografia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoEcoCardiografia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcoCardiografia_User");
            });

            modelBuilder.Entity<ExternoEcografium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoEcografia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcografia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoEcografia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcografia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoEcografia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoEcografia_User");
            });

            modelBuilder.Entity<ExternoElectrocardiograma>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoElectrocardiograma");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoElectrocardiogramas)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoElectrocardiograma_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoElectrocardiogramas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoElectrocardiograma_User");
            });

            modelBuilder.Entity<ExternoGastroenterologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoGastroenterologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGastroenterologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoGastroenterologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGastroenterologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoGastroenterologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGastroenterologia_User");
            });

            modelBuilder.Entity<ExternoGinecologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoGinecologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGinecologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoGinecologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGinecologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoGinecologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoGinecologia_User");
            });

            modelBuilder.Entity<ExternoLaboratorio>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoLaboratorio");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoLaboratorios)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorio_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoLaboratorios)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorio_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoLaboratorios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorio_User");
            });

            modelBuilder.Entity<ExternoLaboratorioP>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoLaboratorioP");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoLaboratorioPs)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorioP_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoLaboratorioPs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorioP_User");
            });

            modelBuilder.Entity<ExternoLaboratorioPractica>(entity =>
            {
                entity.HasKey(e => new { e.IdExterno, e.IdPractica });

                entity.HasOne(d => d.IdExternoNavigation)
                    .WithMany(p => p.ExternoLaboratorioPracticas)
                    .HasForeignKey(d => d.IdExterno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorioPracticas_ExternoLaboratorioP");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.ExternoLaboratorioPracticas)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoLaboratorioPracticas_LaboratorioPractica");
            });

            modelBuilder.Entity<ExternoRayosPractica>(entity =>
            {
                entity.HasKey(e => new { e.IdExterno, e.IdPractica });

                entity.HasOne(d => d.IdExternoNavigation)
                    .WithMany(p => p.ExternoRayosPracticas)
                    .HasForeignKey(d => d.IdExterno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosPracticas_ExternoRayosXP");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.ExternoRayosPracticas)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosPracticas_RxPractica");
            });

            modelBuilder.Entity<ExternoRayosX>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoRayosX");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoRayosXes)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosX_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoRayosXes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosX_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoRayosXes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosX_User");
            });

            modelBuilder.Entity<ExternoRayosXp>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoRayosXP");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoRayosXps)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosXP_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoRayosXps)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoRayosXP_User");
            });

            modelBuilder.Entity<ExternoTomografiaP>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ExternoTomografiaP");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoTomografiaPs)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografiaP_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoTomografiaPs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografiaP_User");
            });

            modelBuilder.Entity<ExternoTomografiaPractica>(entity =>
            {
                entity.HasKey(e => new { e.IdExterno, e.IdPractica });

                entity.HasOne(d => d.IdExternoNavigation)
                    .WithMany(p => p.ExternoTomografiaPracticas)
                    .HasForeignKey(d => d.IdExterno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografiaPracticas_ExternoTomografiaP");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.ExternoTomografiaPracticas)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografiaPracticas_TomogPractica");
            });

            modelBuilder.Entity<ExternoTomografium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoTomografia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoTomografia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoTomografia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTomografia_User");
            });

            modelBuilder.Entity<ExternoTraumatologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoTraumatologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTraumatologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoTraumatologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTraumatologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoTraumatologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoTraumatologia_User");
            });

            modelBuilder.Entity<ExternoUrologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.ExternoUrologia)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoUrologia_Diagnostico");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ExternoUrologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoUrologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ExternoUrologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternoUrologia_User");
            });

            modelBuilder.Entity<FarCapacidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Capacidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCorta)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarCategorium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Categoria");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_FAR_Categoria_FAR_Categoria");
            });

            modelBuilder.Entity<FarConcentracion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Concentracion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.CapacidadValue)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Capacidad_Value");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarContenido>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Contenido");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Receta)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.FarContenidos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_FAR_Contenido_FAR_Categoria");

                entity.HasOne(d => d.IdConcentracionNavigation)
                    .WithMany(p => p.FarContenidos)
                    .HasForeignKey(d => d.IdConcentracion)
                    .HasConstraintName("FK_FAR_Contenido_FAR_Concentracion");
            });

            modelBuilder.Entity<FarEmpaque>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Empaque");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaFarmaceuticaNavigation)
                    .WithMany(p => p.FarEmpaques)
                    .HasForeignKey(d => d.IdFormaFarmaceutica)
                    .HasConstraintName("FK_FAR_Empaque_FAR_FormaFarmaceutica");

                entity.HasOne(d => d.IdPresentacionNavigation)
                    .WithMany(p => p.FarEmpaques)
                    .HasForeignKey(d => d.IdPresentacion)
                    .HasConstraintName("FK_FAR_Empaque_FAR_Presentacion");
            });

            modelBuilder.Entity<FarFabricante>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Fabricante");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarFarmacium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Farmacia");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.FarFarmacia)
                    .HasForeignKey(d => d.IdEnte)
                    .HasConstraintName("FK_FAR_Farmacia_Ente");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_FAR_Farmacia_FAR_Farmacia");
            });

            modelBuilder.Entity<FarFormaFarmaceutica>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_FormaFarmaceutica");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarInsumo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Insumo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoBarras)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContraIndicaciones)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Indicaciones)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.InformacionAlergicos)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdContenidoNavigation)
                    .WithMany(p => p.FarInsumos)
                    .HasForeignKey(d => d.IdContenido)
                    .HasConstraintName("FK_FAR_Insumo_FAR_Contenido");

                entity.HasOne(d => d.IdEmpaqueNavigation)
                    .WithMany(p => p.FarInsumos)
                    .HasForeignKey(d => d.IdEmpaque)
                    .HasConstraintName("FK_FAR_Insumo_FAR_Empaque");
            });

            modelBuilder.Entity<FarInsumosVinculado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FAR_InsumosVinculados");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.IdInsumoPrincipalNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdInsumoPrincipal)
                    .HasConstraintName("FK_FAR_InsumosVinculados_FAR_Insumo");

                entity.HasOne(d => d.IdInsumoRequeridoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdInsumoRequerido)
                    .HasConstraintName("FK_FAR_InsumosVinculados_FAR_Insumo1");
            });

            modelBuilder.Entity<FarMarca>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Marca");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarPeriodicidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Periodicidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarPeriodoUnidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_PeriodoUnidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarPrescipcionDet>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Prescipcion_Det");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.FarPrescipcionDets)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_FAR_Prescipcion_Det_FAR_Insumo");

                entity.HasOne(d => d.IdPeriodicidadNavigation)
                    .WithMany(p => p.FarPrescipcionDets)
                    .HasForeignKey(d => d.IdPeriodicidad)
                    .HasConstraintName("FK_FAR_Prescipcion_Det_FAR_Periodicidad");

                entity.HasOne(d => d.IdPeriodoUnidadNavigation)
                    .WithMany(p => p.FarPrescipcionDets)
                    .HasForeignKey(d => d.IdPeriodoUnidad)
                    .HasConstraintName("FK_FAR_Prescipcion_Det_FAR_PeriodoUnidad");

                entity.HasOne(d => d.IdPrescripcionNavigation)
                    .WithMany(p => p.FarPrescipcionDets)
                    .HasForeignKey(d => d.IdPrescripcion)
                    .HasConstraintName("FK_FAR_Prescipcion_Det_FAR_Prescripcion_Cab");
            });

            modelBuilder.Entity<FarPrescripcionCab>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Prescripcion_Cab");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.FarPrescripcionCabs)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_FAR_Prescripcion_Cab_Paciente");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.FarPrescripcionCabs)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK_FAR_Prescripcion_Cab_Area");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FarPrescripcionCabs)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_FAR_Prescripcion_Cab_User");
            });

            modelBuilder.Entity<FarPresentacion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Presentacion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.CapacidadValue)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Capacidad_Value");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCapacidadNavigation)
                    .WithMany(p => p.FarPresentacions)
                    .HasForeignKey(d => d.IdCapacidad)
                    .HasConstraintName("FK_FAR_Presentacion_FAR_Capacidad");
            });

            modelBuilder.Entity<FarProveedor>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Proveedor");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarRemitoCab>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Remito_Cab");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.FarRemitoCabs)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Remito_Cab_Area");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.FarRemitoCabs)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Remito_Cab_FAR_Remito_Estado");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FarRemitoCabs)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Remito_Cab_User");
            });

            modelBuilder.Entity<FarRemitoDet>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Remito_Det");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.FarRemitoDets)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_FAR_Remito_Det_FAR_Insumo");

                entity.HasOne(d => d.IdRemitoNavigation)
                    .WithMany(p => p.FarRemitoDets)
                    .HasForeignKey(d => d.IdRemito)
                    .HasConstraintName("FK_FAR_Remito_Det_FAR_Remito_Cab");
            });

            modelBuilder.Entity<FarRemitoEstado>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Remito_Estado");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FarStock>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FAR_Stock");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Lote)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroRemito)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFarmaciaNavigation)
                    .WithMany(p => p.FarStocks)
                    .HasForeignKey(d => d.IdFarmacia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Stock_FAR_Farmacia");

                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.FarStocks)
                    .HasForeignKey(d => d.IdInsumo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Stock_FAR_Insumo");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.FarStocks)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAR_Stock_FAR_Proveedor");
            });

            modelBuilder.Entity<Feriado>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<FichaIngreso>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("FichaIngreso");

                entity.HasIndex(e => new { e.Ausente, e.IdArea, e.Atendido }, "Index_FichaIngresoAusenteIdAreaAtendido");

                entity.HasIndex(e => e.IdArea, "Index_IdAreaIdPaciente");

                entity.HasIndex(e => e.IdPaciente, "Index_Paciente");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Parentezco)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAcompananteNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdAcompanante)
                    .HasConstraintName("FK_FichaIngreso_Persona");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_Area");

                entity.HasOne(d => d.IdComoLlegoNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdComoLlego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_ComoLlego");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_Paciente");

                entity.HasOne(d => d.IdPuestoNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_Puesto");

                entity.HasOne(d => d.IdTipoDeRecepcionNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdTipoDeRecepcion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_TipoRecepcion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.FichaIngresos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FichaIngreso_User");
            });

            modelBuilder.Entity<GlasgowHistorico>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("GlasgowHistorico");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.GlasgowHistoricos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GlasgowHistorico_Paciente");
            });

            modelBuilder.Entity<GrupoAtencionSimultanea>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("GrupoAtencionSimultanea");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoSanguineo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("GrupoSanguineo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Imagen>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Imagen");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Indicacione>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Bomba).HasDefaultValueSql("((0))");

                entity.Property(e => e.BombaFrecuencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BombaMedicamento)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dosis)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Frecuencia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Medicamento)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Php)
                    .HasColumnName("PHP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phpvalor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHPValor");

                entity.Property(e => e.Procedimiento).IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Indicaciones)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("FK_Indicaciones_Area");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Indicaciones)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicaciones_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Indicaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Indicaciones_User");

                entity.HasOne(d => d.IdViaNavigation)
                    .WithMany(p => p.Indicaciones)
                    .HasForeignKey(d => d.IdVia)
                    .HasConstraintName("FK_Indicaciones_Via");
            });

            modelBuilder.Entity<Internacione>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.HasIndex(e => e.Fecha, "Index_FechaIdPacienteIdArea");

                entity.HasIndex(e => e.IdPaciente, "Index_PacienteUsuario");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ekg)
                    .IsUnicode(false)
                    .HasColumnName("EKG");

                entity.Property(e => e.EstudiosComplementarios).IsUnicode(false);

                entity.Property(e => e.Evolucion).IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.LaboratorioAnormal).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTerapeutico).IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Sng).HasColumnName("SNG");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Volumen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Internaciones)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Internaciones_Paciente");

                entity.HasOne(d => d.IdTipoNutricionNavigation)
                    .WithMany(p => p.Internaciones)
                    .HasForeignKey(d => d.IdTipoNutricion)
                    .HasConstraintName("FK_Internaciones_Nutricion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Internaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Internaciones_User");
            });

            modelBuilder.Entity<InternacionesEnfermerium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdIndicacionesNavigation)
                    .WithMany(p => p.InternacionesEnfermeria)
                    .HasForeignKey(d => d.IdIndicaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternacionesEnfermeria_Indicaciones");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.InternacionesEnfermeria)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_InternacionesEnfermeria_User");
            });

            modelBuilder.Entity<InternacionesTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InternacionesTEMP");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<IrabHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Irab");

                entity.ToTable("IrabHistorial");

                entity.HasIndex(e => e.IdPaciente, "Index_IrabHistorial_IdPaciente");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.IrabHistorialIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IrabHistorial_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.IrabHistorialIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_IrabHistorial_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.IrabHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IrabHistorial_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.IrabHistorials)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IrabHistorial_User");
            });

            modelBuilder.Entity<LaboratorioPractica>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("LaboratorioPractica");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaboratorioPracticaSolicitud>(entity =>
            {
                entity.HasKey(e => new { e.IdPractica, e.IdLaboratorioSolicitud });

                entity.ToTable("LaboratorioPracticaSolicitud");

                entity.HasOne(d => d.IdLaboratorioSolicitudNavigation)
                    .WithMany(p => p.LaboratorioPracticaSolicituds)
                    .HasForeignKey(d => d.IdLaboratorioSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratorioPracticaSolicitud_LaboratorioSolicitudHistorial");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.LaboratorioPracticaSolicituds)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaboratorioPracticaSolicitud_LaboratorioPractica");
            });

            modelBuilder.Entity<LaboratorioSolicitudHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("LaboratorioSolicitudHistorial");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.ObservacionMedico).IsUnicode(false);

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);
            });

            modelBuilder.Entity<Llamador>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Llamador");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Llamadors)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Llamador_Paciente");

                entity.HasOne(d => d.IdPuestoNavigation)
                    .WithMany(p => p.Llamadors)
                    .HasForeignKey(d => d.IdPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Llamador_Puesto");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Localidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Localidade>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPartidoNavigation)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.IdPartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidades_Partidos");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Login");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Login1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Login");
            });

            modelBuilder.Entity<Medicamento>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Dosis)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Droga)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Medicamentos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicamentos_Area");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Medicamentos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicamentos_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Medicamentos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicamentos_User");

                entity.HasOne(d => d.IdViaNavigation)
                    .WithMany(p => p.Medicamentos)
                    .HasForeignKey(d => d.IdVia)
                    .HasConstraintName("FK_Medicamentos_Via");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Modalidad>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Modalidad");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoConsultum>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Neonatologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.NeonatologiumIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Neonatologia_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.NeonatologiumIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Neonatologia_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Neonatologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Neonatologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Neonatologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Neonatologia_User");
            });

            modelBuilder.Entity<NivelDeConciencium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nn>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("NN");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("orid");

                entity.Property(e => e.Estatura).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.SenasParticulares)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SexoId).HasColumnName("SexoID");

                entity.HasOne(d => d.Sexo)
                    .WithMany(p => p.Nns)
                    .HasForeignKey(d => d.SexoId)
                    .HasConstraintName("FK_NN_Sexo");
            });

            modelBuilder.Entity<ObraSocial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ObraSocial");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Cp).HasColumnName("CP");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio).IsUnicode(false);

                entity.Property(e => e.Loc).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Web).IsUnicode(false);

                entity.HasOne(d => d.IdAnexoSamoNavigation)
                    .WithMany(p => p.ObraSocials)
                    .HasForeignKey(d => d.IdAnexoSamo)
                    .HasConstraintName("FK_ObraSocial_AnexoSamo");
            });

            modelBuilder.Entity<Observacione>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.ObservacioneIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Observaciones_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.ObservacioneIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Observaciones_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Observaciones)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Observaciones_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Observaciones)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Observaciones_User");
            });

            modelBuilder.Entity<ObservacionesEnfermerium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdIndicacionesNavigation)
                    .WithMany(p => p.ObservacionesEnfermeria)
                    .HasForeignKey(d => d.IdIndicaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObservacionesEnfermeria_Indicaciones");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ObservacionesEnfermeria)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ObservacionesEnfermeria_User");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Paciente");

                entity.HasIndex(e => new { e.IdObraSocial, e.IdNn }, "Index_IdObraSocialIdNNEdadIdpersona");

                entity.HasIndex(e => e.IdNn, "Index_IdObraSocial_IdPersona");

                entity.HasIndex(e => e.IdPersona, "Index_IdPersona");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.IdNn).HasColumnName("IdNN");

                entity.Property(e => e.Imc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IMC");

                entity.Property(e => e.Peso).HasColumnType("decimal(4, 1)");

                entity.HasOne(d => d.IdNnNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdNn)
                    .HasConstraintName("FK_Paciente_NN");

                entity.HasOne(d => d.IdObraSocialNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdObraSocial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paciente_ObraSocial");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Paciente_Persona");
            });

            modelBuilder.Entity<Paralelo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Paralelos)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paralelos_Area");

                entity.HasOne(d => d.IdMedicacionNavigation)
                    .WithMany(p => p.Paralelos)
                    .HasForeignKey(d => d.IdMedicacion)
                    .HasConstraintName("FK_Paralelos_TipoMedicamento");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Paralelos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paralelos_Paciente");

                entity.HasOne(d => d.IdSolucionNavigation)
                    .WithMany(p => p.Paralelos)
                    .HasForeignKey(d => d.IdSolucion)
                    .HasConstraintName("FK_Paralelos_TipoSolucion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Paralelos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Paralelos_User");
            });

            modelBuilder.Entity<ParteAnestesistum>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__ParteAne__A9A8BCD66BEFBCE0");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.HasOne(d => d.IdQuirofanoNavigation)
                    .WithMany(p => p.ParteAnestesista)
                    .HasForeignKey(d => d.IdQuirofano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParteAnestesista_Quirofano1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ParteAnestesista)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParteAnestesista_User");
            });

            modelBuilder.Entity<ParteInstrumentador>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__ParteIns__A9A8BCD67390DEA8");

                entity.ToTable("ParteInstrumentador");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Ayudante1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ayudante2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCirujano)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.ProcedimientoQuirurgico)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEspecialidadQuirurgicaNavigation)
                    .WithMany(p => p.ParteInstrumentadors)
                    .HasForeignKey(d => d.IdEspecialidadQuirurgica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParteInstrumentador_EspecialidadQuirurgica1");

                entity.HasOne(d => d.IdQuirofanoNavigation)
                    .WithMany(p => p.ParteInstrumentadors)
                    .HasForeignKey(d => d.IdQuirofano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParteInstrumentador_Quirofano");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ParteInstrumentadors)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParteInstrumentador_User");
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partidos_Provincias");
            });

            modelBuilder.Entity<PartidosAtendido>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PediatriaHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Pediatria");

                entity.ToTable("PediatriaHistorial");

                entity.HasIndex(e => e.Fecha, "Index_IdDiagPrim_IdPaciente_IdArea");

                entity.HasIndex(e => e.IdPaciente, "Index_PediatriaHistorialIdPaciente");

                entity.HasIndex(e => e.IdUsuario, "Index_PediatriaHistorial_IdUsuario");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.PediatriaHistorialIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorial_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.PediatriaHistorialIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_PediatriaHistorial_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.PediatriaHistorials)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorial_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.PediatriaHistorials)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorial_User");
            });

            modelBuilder.Entity<PediatriaHistorialCe>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_PediatriaCE");

                entity.ToTable("PediatriaHistorialCE");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.PediatriaHistorialCeIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorialCE_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.PediatriaHistorialCeIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_PediatriaHistorialCE_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.PediatriaHistorialCes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorialCE_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.PediatriaHistorialCes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PediatriaHistorialCE_User");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Persona");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_EstadoCivil");

                entity.HasOne(d => d.IdGrupoSanguineoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdGrupoSanguineo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_GrupoSanguineo");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Localidad");

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdProfesion)
                    .HasConstraintName("FK_Persona_Profesion");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_Sexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_TipoDocumento");
            });

            modelBuilder.Entity<PersonaTurno>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_EstadoCivil");

                entity.HasOne(d => d.IdGrupoSanguineoNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdGrupoSanguineo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_GrupoSanguineo");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_Localidad");

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdProfesion)
                    .HasConstraintName("FK_PersonaTurnos_Profesion");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_Sexo");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.PersonaTurnos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_TipoDocumento");
            });

            modelBuilder.Entity<PersonaTurnosp>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_PersonaTurnos1");

                entity.ToTable("PersonaTurnosp");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_EstadoCivil1");

                entity.HasOne(d => d.IdGrupoSanguineoNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdGrupoSanguineo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_GrupoSanguineo1");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdLocalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_Localidad1");

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdProfesion)
                    .HasConstraintName("FK_PersonaTurnos_Profesion1");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_Sexo1");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.PersonaTurnosps)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTurnos_TipoDocumento1");
            });

            modelBuilder.Entity<Php>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("PHP");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Phps)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHP_Area");

                entity.HasOne(d => d.IdMedicacionNavigation)
                    .WithMany(p => p.Phps)
                    .HasForeignKey(d => d.IdMedicacion)
                    .HasConstraintName("FK_PHP_TipoMedicamento");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Phps)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHP_Paciente");

                entity.HasOne(d => d.IdSolucionNavigation)
                    .WithMany(p => p.Phps)
                    .HasForeignKey(d => d.IdSolucion)
                    .HasConstraintName("FK_PHP_TipoSolucion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Phps)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHP_User");
            });

            modelBuilder.Entity<PracticaEnfermerium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Procedimiento>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.ProcedimientoIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procedimientos_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.ProcedimientoIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Procedimientos_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Procedimientos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procedimientos_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Procedimientos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procedimientos_User");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Profesion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Profesion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Puesto");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quirofano>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Quirofano");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.AreaProcedenciaNavigation)
                    .WithMany(p => p.Quirofanos)
                    .HasForeignKey(d => d.AreaProcedencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quirofano_Area");

                entity.HasOne(d => d.CirujanoNavigation)
                    .WithMany(p => p.Quirofanos)
                    .HasForeignKey(d => d.Cirujano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quirofano_User");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Quirofanos)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quirofano_Paciente");
            });

            modelBuilder.Entity<Reporte>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportesRol>(entity =>
            {
                entity.HasKey(e => new { e.IdReporte, e.IdRol });

                entity.ToTable("ReportesRol");
            });

            modelBuilder.Entity<RespuestasGlasgow>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdVariablesGlasgow });

                entity.ToTable("RespuestasGlasgow");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdVariablesGlasgowNavigation)
                    .WithMany(p => p.RespuestasGlasgows)
                    .HasForeignKey(d => d.IdVariablesGlasgow)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RespuestasGlasgow_VariablesGlasgow");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolRule>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RolId });

                entity.ToTable("RolRule");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolRules)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolRule_Rol");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RolRules)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolRule_Rules");
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Definicion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RxPractica>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("RxPractica");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RxPracticaSolicitud>(entity =>
            {
                entity.HasKey(e => new { e.IdPractica, e.IdRxSolicitud })
                    .HasName("PK_RxPaciente");

                entity.ToTable("RxPracticaSolicitud");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.RxPracticaSolicituds)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RxPracticaSolicitud_RxPractica");

                entity.HasOne(d => d.IdRxSolicitudNavigation)
                    .WithMany(p => p.RxPracticaSolicituds)
                    .HasForeignKey(d => d.IdRxSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RxPracticaSolicitud_RxSolicitudHistorial");
            });

            modelBuilder.Entity<RxSolicitudHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("RxSolicitudHistorial");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasDefaultValueSql("((1))");

                entity.Property(e => e.ObservacionMedico).IsUnicode(false);

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);
            });

            modelBuilder.Entity<SedacionAnalgesium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.SedacionAnalgesia)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SedacionAnalgesia_Area");

                entity.HasOne(d => d.IdMedicacionNavigation)
                    .WithMany(p => p.SedacionAnalgesia)
                    .HasForeignKey(d => d.IdMedicacion)
                    .HasConstraintName("FK_SedacionAnalgesia_TipoMedicamento");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.SedacionAnalgesia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SedacionAnalgesia_Paciente");

                entity.HasOne(d => d.IdSolucionNavigation)
                    .WithMany(p => p.SedacionAnalgesia)
                    .HasForeignKey(d => d.IdSolucion)
                    .HasConstraintName("FK_SedacionAnalgesia_TipoSolucion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.SedacionAnalgesia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SedacionAnalgesia_User");
            });

            modelBuilder.Entity<Seguimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Seguimiento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("Sexo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShockRoom>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("ShockRoom");

                entity.HasIndex(e => e.IdPaciente, "Index_IdUsuario");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.ShockRoomIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShockRoom_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.ShockRoomIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_ShockRoom_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.ShockRooms)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShockRoom_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ShockRooms)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShockRoom_User");
            });

            modelBuilder.Entity<ShockRoomEnfermerium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdIndicacionesNavigation)
                    .WithMany(p => p.ShockRoomEnfermeria)
                    .HasForeignKey(d => d.IdIndicaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShockRoomEnfermeria_Indicaciones");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ShockRoomEnfermeria)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ShockRoomEnfermeria_User");
            });

            modelBuilder.Entity<TempHoja20Base>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Hoja20_Base");

                entity.Property(e => e.ApellidoNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Año)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEstablecimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPartido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoServicio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Establecimiento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M10a14).HasColumnName("M_10A14");

                entity.Property(e => e.M15a19).HasColumnName("M_15A19");

                entity.Property(e => e.M1a4).HasColumnName("M_1A4");

                entity.Property(e => e.M20a34).HasColumnName("M_20A34");

                entity.Property(e => e.M35a49).HasColumnName("M_35A49");

                entity.Property(e => e.M50a64).HasColumnName("M_50A64");

                entity.Property(e => e.M5a9).HasColumnName("M_5A9");

                entity.Property(e => e.M65).HasColumnName("M_65");

                entity.Property(e => e.MMen1).HasColumnName("M_MEN1");

                entity.Property(e => e.Mes)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OsNo).HasColumnName("OS_No");

                entity.Property(e => e.OsSi).HasColumnName("OS_Si");

                entity.Property(e => e.Partido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerVisita)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionSanitaria)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.V10a14).HasColumnName("V_10A14");

                entity.Property(e => e.V15a19).HasColumnName("V_15A19");

                entity.Property(e => e.V1a4).HasColumnName("V_1A4");

                entity.Property(e => e.V20a34).HasColumnName("V_20A34");

                entity.Property(e => e.V35a49).HasColumnName("V_35A49");

                entity.Property(e => e.V50a64).HasColumnName("V_50A64");

                entity.Property(e => e.V5a9).HasColumnName("V_5A9");

                entity.Property(e => e.V65).HasColumnName("V_65");

                entity.Property(e => e.VMen1).HasColumnName("V_MEN1");
            });

            modelBuilder.Entity<TempHoja20TotalesRango>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Hoja20_TotalesRango");

                entity.Property(e => e.TotM10a14).HasColumnName("TOT_M_10A14");

                entity.Property(e => e.TotM15a19).HasColumnName("TOT_M_15A19");

                entity.Property(e => e.TotM1a4).HasColumnName("TOT_M_1A4");

                entity.Property(e => e.TotM20a34).HasColumnName("TOT_M_20A34");

                entity.Property(e => e.TotM35a49).HasColumnName("TOT_M_35A49");

                entity.Property(e => e.TotM50a64).HasColumnName("TOT_M_50A64");

                entity.Property(e => e.TotM5a9).HasColumnName("TOT_M_5A9");

                entity.Property(e => e.TotM65).HasColumnName("TOT_M_65");

                entity.Property(e => e.TotMMen1).HasColumnName("TOT_M_MEN1");

                entity.Property(e => e.TotOsNo).HasColumnName("TOT_OS_No");

                entity.Property(e => e.TotOsSi).HasColumnName("TOT_OS_Si");

                entity.Property(e => e.TotV10a14).HasColumnName("TOT_V_10A14");

                entity.Property(e => e.TotV15a19).HasColumnName("TOT_V_15A19");

                entity.Property(e => e.TotV1a4).HasColumnName("TOT_V_1A4");

                entity.Property(e => e.TotV20a34).HasColumnName("TOT_V_20A34");

                entity.Property(e => e.TotV35a49).HasColumnName("TOT_V_35A49");

                entity.Property(e => e.TotV50a64).HasColumnName("TOT_V_50A64");

                entity.Property(e => e.TotV5a9).HasColumnName("TOT_V_5A9");

                entity.Property(e => e.TotV65).HasColumnName("TOT_V_65");

                entity.Property(e => e.TotVMen1).HasColumnName("TOT_V_MEN1");
            });

            modelBuilder.Entity<TempHoja21Base>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Hoja21_Base");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.M10a14).HasColumnName("M_10A14");

                entity.Property(e => e.M15a19).HasColumnName("M_15A19");

                entity.Property(e => e.M1a4).HasColumnName("M_1A4");

                entity.Property(e => e.M20a34).HasColumnName("M_20A34");

                entity.Property(e => e.M35a49).HasColumnName("M_35A49");

                entity.Property(e => e.M50a64).HasColumnName("M_50A64");

                entity.Property(e => e.M5a9).HasColumnName("M_5A9");

                entity.Property(e => e.M65).HasColumnName("M_65");

                entity.Property(e => e.MMen1).HasColumnName("M_MEN1");

                entity.Property(e => e.OsNo).HasColumnName("OS_No");

                entity.Property(e => e.OsSi).HasColumnName("OS_Si");

                entity.Property(e => e.Servicio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.V10a14).HasColumnName("V_10A14");

                entity.Property(e => e.V15a19).HasColumnName("V_15A19");

                entity.Property(e => e.V1a4).HasColumnName("V_1A4");

                entity.Property(e => e.V20a34).HasColumnName("V_20A34");

                entity.Property(e => e.V35a49).HasColumnName("V_35A49");

                entity.Property(e => e.V50a64).HasColumnName("V_50A64");

                entity.Property(e => e.V5a9).HasColumnName("V_5A9");

                entity.Property(e => e.V65).HasColumnName("V_65");

                entity.Property(e => e.VMen1).HasColumnName("V_MEN1");
            });

            modelBuilder.Entity<TempHoja21TotalesArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Hoja21_TotalesArea");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OsNo).HasColumnName("OS_No");

                entity.Property(e => e.OsSi).HasColumnName("OS_Si");

                entity.Property(e => e.Servicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempHoja21TotalesRango>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Hoja21_TotalesRango");

                entity.Property(e => e.TotGrandTotal).HasColumnName("TOT_GrandTotal");

                entity.Property(e => e.TotM10a14).HasColumnName("TOT_M_10A14");

                entity.Property(e => e.TotM15a19).HasColumnName("TOT_M_15A19");

                entity.Property(e => e.TotM1a4).HasColumnName("TOT_M_1A4");

                entity.Property(e => e.TotM20a34).HasColumnName("TOT_M_20A34");

                entity.Property(e => e.TotM35a49).HasColumnName("TOT_M_35A49");

                entity.Property(e => e.TotM50a64).HasColumnName("TOT_M_50A64");

                entity.Property(e => e.TotM5a9).HasColumnName("TOT_M_5A9");

                entity.Property(e => e.TotM65).HasColumnName("TOT_M_65");

                entity.Property(e => e.TotMMen1).HasColumnName("TOT_M_MEN1");

                entity.Property(e => e.TotOsNo).HasColumnName("TOT_OS_No");

                entity.Property(e => e.TotOsSi).HasColumnName("TOT_OS_Si");

                entity.Property(e => e.TotV10a14).HasColumnName("TOT_V_10A14");

                entity.Property(e => e.TotV15a19).HasColumnName("TOT_V_15A19");

                entity.Property(e => e.TotV1a4).HasColumnName("TOT_V_1A4");

                entity.Property(e => e.TotV20a34).HasColumnName("TOT_V_20A34");

                entity.Property(e => e.TotV35a49).HasColumnName("TOT_V_35A49");

                entity.Property(e => e.TotV50a64).HasColumnName("TOT_V_50A64");

                entity.Property(e => e.TotV5a9).HasColumnName("TOT_V_5A9");

                entity.Property(e => e.TotV65).HasColumnName("TOT_V_65");

                entity.Property(e => e.TotVMen1).HasColumnName("TOT_V_MEN1");
            });

            modelBuilder.Entity<TerapiaEnfermerium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdIndicacionesNavigation)
                    .WithMany(p => p.TerapiaEnfermeria)
                    .HasForeignKey(d => d.IdIndicaciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerapiaEnfermeria_Indicaciones");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TerapiaEnfermeria)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_TerapiaEnfermeria_User");
            });

            modelBuilder.Entity<Terapium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.TerapiumIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terapia_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.TerapiumIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Terapia_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Terapia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terapia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Terapia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terapia_User");
            });

            modelBuilder.Entity<TipoAtencion>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK__TipoAten__A9A8BCD6703F70B1");

                entity.ToTable("TipoAtencion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Informacion)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.RequisitosHtml)
                    .IsUnicode(false)
                    .HasColumnName("RequisitosHTML");
            });

            modelBuilder.Entity<TipoBono>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoBono");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoCaso>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoCaso");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoClasificacionDeRiesgo>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoClasificacionDeRiesgo");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoContacto>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoContacto");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDiagnostico>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoDiagnostico");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEnte>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoEnte");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEstado>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoEstado");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMedicamento>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoMedicamento");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndicacionDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoNutricion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoNutricion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoRecepcion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoRecepcion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdEntidad).HasDefaultValueSql("('C83D9976-5D3A-40D9-A04F-9B4642F155F0')");
            });

            modelBuilder.Entity<TipoRecepcionBono>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSolucion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoSolucion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoVacuna>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TipoVacuna");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Informacion).IsUnicode(false);
            });

            modelBuilder.Entity<Tocoginecologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.TocoginecologiumIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tocoginecologia_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.TocoginecologiumIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Tocoginecologia_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Tocoginecologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tocoginecologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Tocoginecologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tocoginecologia_User");
            });

            modelBuilder.Entity<TomogPractica>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TomogPractica");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TomogPracticaSolicitud>(entity =>
            {
                entity.HasKey(e => new { e.IdPractica, e.IdTomogSolicitud })
                    .HasName("PK_TomogPaciente");

                entity.ToTable("TomogPracticaSolicitud");

                entity.HasOne(d => d.IdPracticaNavigation)
                    .WithMany(p => p.TomogPracticaSolicituds)
                    .HasForeignKey(d => d.IdPractica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TomogPracticaSolicitud_TomogPractica");

                entity.HasOne(d => d.IdTomogSolicitudNavigation)
                    .WithMany(p => p.TomogPracticaSolicituds)
                    .HasForeignKey(d => d.IdTomogSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TomogPracticaSolicitud_TomogSolicitudHistorial");
            });

            modelBuilder.Entity<TomogSolicitudHistorial>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TomogSolicitudHistorial");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasDefaultValueSql("((1))");

                entity.Property(e => e.ObservacionMedico).IsUnicode(false);

                entity.Property(e => e.ObservacionTecnico).IsUnicode(false);
            });

            modelBuilder.Entity<Traumatologium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.HasIndex(e => e.Fecha, "Index_IdDiagPrim_IdPaciente_IdArea");

                entity.HasIndex(e => e.IdPaciente, "Index_Traumatologia_IdPeciente");

                entity.HasIndex(e => e.IdUsuario, "Index_Traumatologia_IdUsuario");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.HasOne(d => d.IdDiagPrimNavigation)
                    .WithMany(p => p.TraumatologiumIdDiagPrimNavigations)
                    .HasForeignKey(d => d.IdDiagPrim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traumatologia_Diagnostico");

                entity.HasOne(d => d.IdDiagSecNavigation)
                    .WithMany(p => p.TraumatologiumIdDiagSecNavigations)
                    .HasForeignKey(d => d.IdDiagSec)
                    .HasConstraintName("FK_Traumatologia_Diagnostico1");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Traumatologia)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traumatologia_Paciente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Traumatologia)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traumatologia_User");
            });

            modelBuilder.Entity<TurBono>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");
            });

            modelBuilder.Entity<TurDedicacion>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Dedicacion");

                entity.ToTable("TurDedicacion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.TurDedicacions)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dedicacion_Ente");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.TurDedicacions)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dedicacion_Especialidad");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TurDedicacions)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dedicacion_User");
            });

            modelBuilder.Entity<TurDiasEspeciale>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurDiasNoLaborable>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdCarga).HasColumnName("UserID_Carga");

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.TurDiasNoLaborables)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurDiasNoLaborables_Ente");
            });

            modelBuilder.Entity<TurStatus>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Status");

                entity.ToTable("TurStatus");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurTipoTurno>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_TipoTurno");

                entity.ToTable("TurTipoTurno");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurTurno>(entity =>
            {
                entity.HasKey(e => e.Orid)
                    .HasName("PK_Turno_1");

                entity.ToTable("TurTurno");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.TurTurnos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurTurno_PersonaTurnos");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.TurTurnos)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_Status");

                entity.HasOne(d => d.IdTipoTurnoNavigation)
                    .WithMany(p => p.TurTurnos)
                    .HasForeignKey(d => d.IdTipoTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turno_TipoTurno");
            });

            modelBuilder.Entity<TurTurnoBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TurTurnoBk");

                entity.Property(e => e.Orid).HasColumnName("ORID");
            });

            modelBuilder.Entity<TurTurnoCancelado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Orid).HasColumnName("ORID");
            });

            modelBuilder.Entity<TurTurnoNoConfirmado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TurTurnoNoConfirmado");

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.TipoVacunacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEnte).HasDefaultValueSql("('c83d9976-5d3a-40d9-a04f-9b4642f155f0')");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEnteNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdEnte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Ente");
            });

            modelBuilder.Entity<UserArea>(entity =>
            {
                entity.HasKey(e => new { e.Orid, e.UserId });

                entity.ToTable("UserArea");

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Or)
                    .WithMany(p => p.UserAreas)
                    .HasForeignKey(d => d.Orid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserArea_Area1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAreas)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserArea_User");
            });

            modelBuilder.Entity<UserEspecialidad>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.IdEspecialidad });

                entity.ToTable("UserEspecialidad");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.UserEspecialidads)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEspecialidad_Especialidad");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEspecialidads)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEspecialidad_User");
            });

            modelBuilder.Entity<UserRol>(entity =>
            {
                entity.HasKey(e => new { e.RolId, e.UserId });

                entity.ToTable("UserRol");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UserRols)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRol_Rol");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRols)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRol_User");
            });

            modelBuilder.Entity<Uti>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("UTI");

                entity.HasIndex(e => new { e.IdArea, e.IdPaciente, e.Fecha }, "Index_IdAreaIdPacienteFecha");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoActual).IsUnicode(false);

                entity.Property(e => e.Ekg)
                    .IsUnicode(false)
                    .HasColumnName("EKG");

                entity.Property(e => e.EstudiosComplementarios).IsUnicode(false);

                entity.Property(e => e.Evolucion).IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.LaboratorioAnormal).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTerapeutico).IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Sng).HasColumnName("SNG");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Volumen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Utis)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UTI_Paciente");

                entity.HasOne(d => d.IdTipoNutricionNavigation)
                    .WithMany(p => p.Utis)
                    .HasForeignKey(d => d.IdTipoNutricion)
                    .HasConstraintName("FK_UTI_TipoNutricion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Utis)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UTI_User");
            });

            modelBuilder.Entity<UtiCe>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("UtiCE");

                entity.HasIndex(e => new { e.IdArea, e.IdPaciente, e.Fecha }, "Index_IdAreaIdPacienteFecha");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.DiagnosticoActual).IsUnicode(false);

                entity.Property(e => e.Ekg)
                    .IsUnicode(false)
                    .HasColumnName("EKG");

                entity.Property(e => e.EstudiosComplementarios).IsUnicode(false);

                entity.Property(e => e.Evolucion).IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.LaboratorioAnormal).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTerapeutico).IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Sng).HasColumnName("SNG");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Volumen)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.UtiCes)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UtiCE_Paciente");

                entity.HasOne(d => d.IdTipoNutricionNavigation)
                    .WithMany(p => p.UtiCes)
                    .HasForeignKey(d => d.IdTipoNutricion)
                    .HasConstraintName("FK_UtiCE_TipoNutricion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UtiCes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UtiCE_User");
            });

            modelBuilder.Entity<VAtencionHistorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AtencionHistorial");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoPresuntivo).IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<VAtencionHistorialCe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AtencionHistorialCE");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<VAtencionHistorialEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AtencionHistorialEx");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");
            });

            modelBuilder.Entity<VEnfermeria>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Enfermerias");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");
            });

            modelBuilder.Entity<VHistorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Historial");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Diagnostico)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdNn).HasColumnName("IdNN");

                entity.Property(e => e.Medico)
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");
            });

            modelBuilder.Entity<VInternacionesGle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_InternacionesGles");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CodeArea)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoActual).IsUnicode(false);

                entity.Property(e => e.DiagnosticoPresuntivo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ekg)
                    .IsUnicode(false)
                    .HasColumnName("EKG");

                entity.Property(e => e.EstudiosComplementarios).IsUnicode(false);

                entity.Property(e => e.Evolucion).IsUnicode(false);

                entity.Property(e => e.Hgt).HasColumnName("HGT");

                entity.Property(e => e.HistoriaClinica).IsUnicode(false);

                entity.Property(e => e.Indicaciones).IsUnicode(false);

                entity.Property(e => e.LaboratorioAnormal).IsUnicode(false);

                entity.Property(e => e.MotivoConsulta).IsUnicode(false);

                entity.Property(e => e.Obito).IsUnicode(false);

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.OtraInstitucion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanTerapeutico).IsUnicode(false);

                entity.Property(e => e.ProlongacionEstadia).IsUnicode(false);

                entity.Property(e => e.Sng).HasColumnName("SNG");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.Temperatura).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Volumen)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPacientesBaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Pacientes_baja");
            });

            modelBuilder.Entity<VacunaXdiaBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VacunaXDia_BKP");

                entity.Property(e => e.Orid).HasColumnName("ORID");
            });

            modelBuilder.Entity<VacunaXdium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VacunaXDia");

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.Registro).HasColumnType("datetime");
            });

            modelBuilder.Entity<VariablesGlasgow>(entity =>
            {
                entity.ToTable("VariablesGlasgow");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEstadoHistorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewEstadoHistorial");

                entity.Property(e => e.Destino)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paciente)
                    .IsRequired()
                    .HasMaxLength(151)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEstado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Visor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Visor");

                entity.Property(e => e.Hora)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Paciente).IsUnicode(false);

                entity.Property(e => e.Puesto).IsUnicode(false);
            });

            modelBuilder.Entity<VisorA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VisorA");

                entity.Property(e => e.Hora)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Paciente).IsUnicode(false);

                entity.Property(e => e.Puesto).IsUnicode(false);
            });

            modelBuilder.Entity<VisorE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VisorE");

                entity.Property(e => e.Hora)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Paciente).IsUnicode(false);

                entity.Property(e => e.Puesto).IsUnicode(false);
            });

            modelBuilder.Entity<VisorVicenteLopez>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VisorVicenteLopez");

                entity.Property(e => e.Hora)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Paciente).IsUnicode(false);

                entity.Property(e => e.Puesto).IsUnicode(false);
            });

            modelBuilder.Entity<Vium>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
