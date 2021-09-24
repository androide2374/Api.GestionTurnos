using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class SiteMLZContext : DbContext
    {
        public SiteMLZContext()
        {
        }

        public SiteMLZContext(DbContextOptions<SiteMLZContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppComentario> AppComentarios { get; set; }
        public virtual DbSet<AreasDeGestion> AreasDeGestions { get; set; }
        public virtual DbSet<AreasSite> AreasSites { get; set; }
        public virtual DbSet<AreasTematica> AreasTematicas { get; set; }
        public virtual DbSet<AudiNoticia> AudiNoticias { get; set; }
        public virtual DbSet<BoletinOficial> BoletinOficials { get; set; }
        public virtual DbSet<Buscador> Buscadors { get; set; }
        public virtual DbSet<Calle> Calles { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Cartelera> Carteleras { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<CategoriasGaleria> CategoriasGalerias { get; set; }
        public virtual DbSet<Cementerio> Cementerios { get; set; }
        public virtual DbSet<Colonium> Colonia { get; set; }
        public virtual DbSet<CorCorte> CorCortes { get; set; }
        public virtual DbSet<CorCorteCancelado> CorCorteCancelados { get; set; }
        public virtual DbSet<CorCorteRechazado> CorCorteRechazados { get; set; }
        public virtual DbSet<CorHorario> CorHorarios { get; set; }
        public virtual DbSet<CorSolicitante> CorSolicitantes { get; set; }
        public virtual DbSet<CorStatus> CorStatuses { get; set; }
        public virtual DbSet<CorTipoCorte> CorTipoCortes { get; set; }
        public virtual DbSet<CorTipoSolicitante> CorTipoSolicitantes { get; set; }
        public virtual DbSet<CorTipoSolicitud> CorTipoSolicituds { get; set; }
        public virtual DbSet<Cud> Cuds { get; set; }
        public virtual DbSet<Cudnuevo> Cudnuevos { get; set; }
        public virtual DbSet<CuposDelegacion> CuposDelegacions { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<DatosLaborale> DatosLaborales { get; set; }
        public virtual DbSet<DefensaConsumidor> DefensaConsumidors { get; set; }
        public virtual DbSet<DelegacionColonium> DelegacionColonia { get; set; }
        public virtual DbSet<Delegacione> Delegaciones { get; set; }
        public virtual DbSet<DenunciaEmpleadosPublico> DenunciaEmpleadosPublicos { get; set; }
        public virtual DbSet<Denunciado> Denunciados { get; set; }
        public virtual DbSet<Difunto> Difuntos { get; set; }
        public virtual DbSet<DynamicQr> DynamicQrs { get; set; }
        public virtual DbSet<Emprendimiento> Emprendimientos { get; set; }
        public virtual DbSet<EmprendimientoRubro> EmprendimientoRubros { get; set; }
        public virtual DbSet<EmprendimientosSolicitude> EmprendimientosSolicitudes { get; set; }
        public virtual DbSet<Ente> Entes { get; set; }
        public virtual DbSet<EnteEspecialidad> EnteEspecialidads { get; set; }
        public virtual DbSet<Entidade> Entidades { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }
        public virtual DbSet<EstudiosCursado> EstudiosCursados { get; set; }
        public virtual DbSet<FechasJornadum> FechasJornada { get; set; }
        public virtual DbSet<Galerium> Galeria { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<GrupoG> GrupoGs { get; set; }
        public virtual DbSet<HorariosAudienciaDc> HorariosAudienciaDcs { get; set; }
        public virtual DbSet<Html> Htmls { get; set; }
        public virtual DbSet<Imagene> Imagenes { get; set; }
        public virtual DbSet<InscripcionDiaMonumento> InscripcionDiaMonumentos { get; set; }
        public virtual DbSet<InscripcionRsc> InscripcionRscs { get; set; }
        public virtual DbSet<InscripcionTeatro> InscripcionTeatros { get; set; }
        public virtual DbSet<Inscripto> Inscriptos { get; set; }
        public virtual DbSet<InscriptosProcrear> InscriptosProcrears { get; set; }
        public virtual DbSet<InscriptosProcrearStatus> InscriptosProcrearStatuses { get; set; }
        public virtual DbSet<JornadaEmergencium> JornadaEmergencia { get; set; }
        public virtual DbSet<Localidad> Localidads { get; set; }
        public virtual DbSet<Luminaria> Luminarias { get; set; }
        public virtual DbSet<LuminariasFoto> LuminariasFotos { get; set; }
        public virtual DbSet<LuminariasTipo> LuminariasTipos { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu2> Menu2s { get; set; }
        public virtual DbSet<Noticia> Noticias { get; set; }
        public virtual DbSet<ObraSocial> ObraSocials { get; set; }
        public virtual DbSet<PediTuSemilla> PediTuSemillas { get; set; }
        public virtual DbSet<PediTuSemillaPrueba> PediTuSemillaPruebas { get; set; }
        public virtual DbSet<Perfile> Perfiles { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaChk> PersonaChks { get; set; }
        public virtual DbSet<PersonaTemp> PersonaTemps { get; set; }
        public virtual DbSet<Piletum> Pileta { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Prueba> Pruebas { get; set; }
        public virtual DbSet<Reclamo> Reclamos { get; set; }
        public virtual DbSet<ReclamosFoto> ReclamosFotos { get; set; }
        public virtual DbSet<ReclamosPrueba> ReclamosPruebas { get; set; }
        public virtual DbSet<Renta> Rentas { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolRule> RolRules { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Rubro> Rubros { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<SemanasColonium> SemanasColonia { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SubSeccione> SubSecciones { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoEntidad> TipoEntidads { get; set; }
        public virtual DbSet<TipoPersona> TipoPersonas { get; set; }
        public virtual DbSet<TipoSolicitud> TipoSolicituds { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public virtual DbSet<TiposImagen> TiposImagens { get; set; }
        public virtual DbSet<TiposNoticium> TiposNoticia { get; set; }
        public virtual DbSet<ToProfesion> ToProfesions { get; set; }
        public virtual DbSet<ToProfesional> ToProfesionals { get; set; }
        public virtual DbSet<ToSolicitude> ToSolicitudes { get; set; }
        public virtual DbSet<ToStatus> ToStatuses { get; set; }
        public virtual DbSet<ToTipoProfesional> ToTipoProfesionals { get; set; }
        public virtual DbSet<Transparencium> Transparencia { get; set; }
        public virtual DbSet<TurDedicacion> TurDedicacions { get; set; }
        public virtual DbSet<TurDedicacion1> TurDedicacions1 { get; set; }
        public virtual DbSet<TurDiaNoLaborablexProfesional> TurDiaNoLaborablexProfesionals { get; set; }
        public virtual DbSet<TurDiasEspeciale> TurDiasEspeciales { get; set; }
        public virtual DbSet<TurDiasNoLaborable> TurDiasNoLaborables { get; set; }
        public virtual DbSet<TurDiasNoLaborable1> TurDiasNoLaborables1 { get; set; }
        public virtual DbSet<TurHorariosAp> TurHorariosAps { get; set; }
        public virtual DbSet<TurJunta> TurJuntas { get; set; }
        public virtual DbSet<TurStatus> TurStatuses { get; set; }
        public virtual DbSet<TurStatusNuevo> TurStatusNuevos { get; set; }
        public virtual DbSet<TurStatusProtocolo> TurStatusProtocolos { get; set; }
        public virtual DbSet<TurTipoDiscapacidade> TurTipoDiscapacidades { get; set; }
        public virtual DbSet<TurTipoTurno> TurTipoTurnos { get; set; }
        public virtual DbSet<TurTurno> TurTurnos { get; set; }
        public virtual DbSet<TurTurnoCancelado> TurTurnoCancelados { get; set; }
        public virtual DbSet<TurTurnoCanceladoNuevo> TurTurnoCanceladoNuevos { get; set; }
        public virtual DbSet<TurTurnoNoConfirmado> TurTurnoNoConfirmados { get; set; }
        public virtual DbSet<TurTurnoNuevo> TurTurnoNuevos { get; set; }
        public virtual DbSet<TurTurnoPresencial> TurTurnoPresencials { get; set; }
        public virtual DbSet<TurTurnoRechazado> TurTurnoRechazados { get; set; }
        public virtual DbSet<TurTurnoRechazadoNuevo> TurTurnoRechazadoNuevos { get; set; }
        public virtual DbSet<UnidadesSanitaria> UnidadesSanitarias { get; set; }
        public virtual DbSet<UnidadesSanitariasNuevo> UnidadesSanitariasNuevos { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRol> UserRols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioEnte> UsuarioEntes { get; set; }
        public virtual DbSet<UsuariosWeb> UsuariosWebs { get; set; }
        public virtual DbSet<VehiculosCompactado> VehiculosCompactados { get; set; }
        public virtual DbSet<VehiculosCompactadosActa> VehiculosCompactadosActas { get; set; }
        public virtual DbSet<VehiculosCompactadosStatus> VehiculosCompactadosStatuses { get; set; }
        public virtual DbSet<VoluntariosCovid> VoluntariosCovids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TRJ1ED3\\Localhost;Database=SiteMLZ;user id=sa;password=ivan2374");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AppComentario>(entity =>
            {
                entity.ToTable("AppComentario");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreasDeGestion>(entity =>
            {
                entity.HasKey(e => e.AgesId);

                entity.ToTable("AreasDeGestion");

                entity.Property(e => e.AgesId)
                    .ValueGeneratedNever()
                    .HasColumnName("AGES_Id");

                entity.Property(e => e.AgesDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGES_Descripcion");
            });

            modelBuilder.Entity<AreasSite>(entity =>
            {
                entity.ToTable("AreasSite");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreasTematica>(entity =>
            {
                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AudiNoticia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AUDI_Noticias");

                entity.Property(e => e.AudiAccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUDI_Accion");

                entity.Property(e => e.AudiFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("AUDI_Fecha");

                entity.Property(e => e.DelId).HasColumnName("DEL_Id");

                entity.Property(e => e.GestId).HasColumnName("GEST_Id");

                entity.Property(e => e.NotBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("NOT_BajaLogica");

                entity.Property(e => e.NotDescripcion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("NOT_Descripcion");

                entity.Property(e => e.NotFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("NOT_Fecha");

                entity.Property(e => e.NotFoto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Foto");

                entity.Property(e => e.NotId).HasColumnName("NOT_Id");

                entity.Property(e => e.NotPrincipal).HasColumnName("NOT_Principal");

                entity.Property(e => e.NotTema)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Tema");

                entity.Property(e => e.NotTitulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Titulo");

                entity.Property(e => e.TnotId).HasColumnName("TNOT_Id");

                entity.Property(e => e.UsrId).HasColumnName("USR_Id");
            });

            modelBuilder.Entity<BoletinOficial>(entity =>
            {
                entity.ToTable("BoletinOficial");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.SubId).HasColumnName("Sub_Id");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsrId).HasColumnName("Usr_Id");
            });

            modelBuilder.Entity<Buscador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Buscador");

                entity.Property(e => e.BusFiltro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUS_Filtro");

                entity.Property(e => e.BusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BUS_Id");

                entity.Property(e => e.BusLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BUS_Link");

                entity.Property(e => e.BusOrden).HasColumnName("BUS_Orden");

                entity.Property(e => e.BusTema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUS_Tema");

                entity.Property(e => e.BusTitulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BUS_Titulo");
            });

            modelBuilder.Entity<Calle>(entity =>
            {
                entity.Property(e => e.NombreCalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CarDescripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CAR_descripcion");

                entity.Property(e => e.CarId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CAR_Id");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cartelera>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("Cartelera");

                entity.Property(e => e.CarId).HasColumnName("CAR_Id");

                entity.Property(e => e.CarDescripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CAR_Descripcion");

                entity.Property(e => e.CarFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("CAR_Fecha");

                entity.Property(e => e.CarFoto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CAR_Foto");

                entity.Property(e => e.CarTitulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAR_Titulo");

                entity.Property(e => e.GenId).HasColumnName("GEN_Id");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CAT_Id");

                entity.Property(e => e.CatDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAT_Descripcion");
            });

            modelBuilder.Entity<CategoriasGaleria>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId).HasColumnName("CAT_Id");

                entity.Property(e => e.CatDescripcion)
                    .IsUnicode(false)
                    .HasColumnName("CAT_Descripcion");

                entity.Property(e => e.CatFiltro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CAT_Filtro");

                entity.Property(e => e.CatFoto)
                    .IsUnicode(false)
                    .HasColumnName("CAT_Foto");

                entity.Property(e => e.GruId).HasColumnName("GRU_Id");
            });

            modelBuilder.Entity<Cementerio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cementerio");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaEstado).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TipoRenovacion).IsUnicode(false);
            });

            modelBuilder.Entity<Colonium>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AutorizacionPadres).IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MadreTutora)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nacionalidad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PadreTutor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoPadreTutor)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorCorte>(entity =>
            {
                entity.ToTable("CorCorte");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmacion).HasColumnType("datetime");

                entity.Property(e => e.CorreoEnviado).IsUnicode(false);

                entity.Property(e => e.Derivado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalle1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 1");

                entity.Property(e => e.EntreCalle2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 2");

                entity.Property(e => e.FechaDeSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Solicitud");

                entity.Property(e => e.FechaDelCorte)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha del Corte");

                entity.Property(e => e.OtroHorario)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorCorteCancelado>(entity =>
            {
                entity.ToTable("CorCorteCancelado");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cancelado).HasColumnType("datetime");

                entity.Property(e => e.Confirmacion).HasColumnType("datetime");

                entity.Property(e => e.CorreoEnviado)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Derivado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalle1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 1");

                entity.Property(e => e.EntreCalle2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 2");

                entity.Property(e => e.FechaDeSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Solicitud");

                entity.Property(e => e.FechaDelCorte)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha del Corte");

                entity.Property(e => e.OtroHorario)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorCorteRechazado>(entity =>
            {
                entity.ToTable("CorCorteRechazado");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmacion).HasColumnType("datetime");

                entity.Property(e => e.CorreoEnviado)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Derivado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalle1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 1");

                entity.Property(e => e.EntreCalle2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Entre Calle 2");

                entity.Property(e => e.FechaDeSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha de Solicitud");

                entity.Property(e => e.FechaDelCorte)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha del Corte");

                entity.Property(e => e.OtroHorario)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorHorario>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Rango)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorSolicitante>(entity =>
            {
                entity.ToTable("CorSolicitante");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Institucion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaMunicipal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Matricula Municipal");

                entity.Property(e => e.MatriculaProfesional)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Matricula Profesional");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroExpediente)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Numero Expediente");

                entity.Property(e => e.Padron)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAlternativo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Telefono Alternativo");
            });

            modelBuilder.Entity<CorStatus>(entity =>
            {
                entity.ToTable("CorStatus");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorTipoCorte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CorTipoCorte");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorTipoSolicitante>(entity =>
            {
                entity.ToTable("CorTipoSolicitante");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorTipoSolicitud>(entity =>
            {
                entity.ToTable("CorTipoSolicitud");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cud>(entity =>
            {
                entity.ToTable("CUD");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo11)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo8)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo9)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEnviado).IsUnicode(false);

                entity.Property(e => e.Discapacidad).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cudnuevo>(entity =>
            {
                entity.ToTable("CUDNuevo");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo10)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo11)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo7)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo8)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo9)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEnviado).IsUnicode(false);

                entity.Property(e => e.Discapacidad).IsUnicode(false);

                entity.Property(e => e.EsReingresoXprot).HasColumnName("EsReingresoXProt");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<CuposDelegacion>(entity =>
            {
                entity.ToTable("CuposDelegacion");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosLaborale>(entity =>
            {
                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefensaConsumidor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DefensaConsumidor");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoEnviado).IsUnicode(false);

                entity.Property(e => e.DenunciadosDeAudiencia).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaAudiencia).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEstado).HasColumnType("datetime");

                entity.Property(e => e.Hecho).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NumExpediente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Pretension).IsUnicode(false);

                entity.Property(e => e.TutDocumento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TutNombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DelegacionColonium>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Delegacione>(entity =>
            {
                entity.HasKey(e => e.DelId);

                entity.Property(e => e.DelId).HasColumnName("DEL_Id");

                entity.Property(e => e.DelBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("DEL_BajaLogica");

                entity.Property(e => e.DelDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEL_Descripcion");
            });

            modelBuilder.Entity<DenunciaEmpleadosPublico>(entity =>
            {
                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Denunciado).IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Resumen)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Denunciado>(entity =>
            {
                entity.ToTable("Denunciado");

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Difunto>(entity =>
            {
                entity.Property(e => e.Acta)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Folio)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistroCivil)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Tomo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DynamicQr>(entity =>
            {
                entity.ToTable("DynamicQR");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tema)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emprendimiento>(entity =>
            {
                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Emprendedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logo5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Partido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Web2)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmprendimientoRubro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmprendimientoRubro");
            });

            modelBuilder.Entity<EmprendimientosSolicitude>(entity =>
            {
                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ente>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnteEspecialidad>(entity =>
            {
                entity.HasKey(e => new { e.IdEspecialidad, e.IdEnte });

                entity.ToTable("EnteEspecialidad");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.EnteEspecialidads)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnteEspecialidad_Especialidad");
            });

            modelBuilder.Entity<Entidade>(entity =>
            {
                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lat).IsUnicode(false);

                entity.Property(e => e.Long).IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidad");

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

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.ToTable("EstadoCivil");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstudiosCursado>(entity =>
            {
                entity.Property(e => e.Distrito)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Escuela)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaLegalizado).HasColumnType("datetime");

                entity.Property(e => e.NumeroRegistro)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RcescolarNturno).HasColumnName("RCEscolarNTurno");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FechasJornadum>(entity =>
            {
                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Galerium>(entity =>
            {
                entity.HasKey(e => e.GalId);

                entity.Property(e => e.GalId).HasColumnName("GAL_ID");

                entity.Property(e => e.CatId).HasColumnName("CAT_Id");

                entity.Property(e => e.GalFull)
                    .IsUnicode(false)
                    .HasColumnName("GAL_Full");

                entity.Property(e => e.GalPreview)
                    .IsUnicode(false)
                    .HasColumnName("GAL_Preview");

                entity.Property(e => e.GalTitulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GAL_Titulo");

                entity.Property(e => e.VidId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VID_Id");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("Genero");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoG>(entity =>
            {
                entity.HasKey(e => e.GruId);

                entity.ToTable("GrupoG");

                entity.Property(e => e.GruId).HasColumnName("GRU_Id");

                entity.Property(e => e.GruDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRU_Descripcion");
            });

            modelBuilder.Entity<HorariosAudienciaDc>(entity =>
            {
                entity.ToTable("HorariosAudienciaDC");
            });

            modelBuilder.Entity<Html>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTMLs");

                entity.Property(e => e.CatId).HasColumnName("CAT_Id");

                entity.Property(e => e.DelId).HasColumnName("DEL_Id");

                entity.Property(e => e.HtmAlias)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HTM_Alias");

                entity.Property(e => e.HtmBody)
                    .IsUnicode(false)
                    .HasColumnName("HTM_Body");

                entity.Property(e => e.HtmId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HTM_Id");

                entity.Property(e => e.HtmStatus).HasColumnName("HTM_Status");

                entity.Property(e => e.HtmTitulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HTM_Titulo");

                entity.Property(e => e.SubId).HasColumnName("SUB_Id");

                entity.Property(e => e.UsrId).HasColumnName("USR_Id");
            });

            modelBuilder.Entity<Imagene>(entity =>
            {
                entity.HasKey(e => e.ImgId);

                entity.Property(e => e.ImgId).HasColumnName("IMG_Id");

                entity.Property(e => e.DelId).HasColumnName("DEL_Id");

                entity.Property(e => e.GestId).HasColumnName("GEST_Id");

                entity.Property(e => e.ImgDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMG_Descripcion");

                entity.Property(e => e.ImgIframe).HasColumnName("IMG_Iframe");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMG_Path");

                entity.Property(e => e.ImgPrincipal).HasColumnName("IMG_Principal");

                entity.Property(e => e.ImgTipo).HasColumnName("IMG_Tipo");
            });

            modelBuilder.Entity<InscripcionDiaMonumento>(entity =>
            {
                entity.Property(e => e.Comentario)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EspacioAvisitar)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("EspacioAVisitar");
            });

            modelBuilder.Entity<InscripcionRsc>(entity =>
            {
                entity.ToTable("InscripcionRSC");

                entity.Property(e => e.Anotaciones).IsUnicode(false);

                entity.Property(e => e.CantidadMenores)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.NombreInstitucion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAlt)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InscripcionTeatro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InscripcionTeatro");

                entity.Property(e => e.Archivo).IsUnicode(false);

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Padron).IsUnicode(false);
            });

            modelBuilder.Entity<Inscripto>(entity =>
            {
                entity.Property(e => e.Alta).HasColumnType("datetime");

                entity.Property(e => e.FechaAprobado).HasColumnType("datetime");
            });

            modelBuilder.Entity<InscriptosProcrear>(entity =>
            {
                entity.ToTable("InscriptosProcrear");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaAprobado).HasColumnType("datetime");

                entity.Property(e => e.IngresosAproximados)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InscriptosProcrearStatus>(entity =>
            {
                entity.ToTable("InscriptosProcrearStatus");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JornadaEmergencium>(entity =>
            {
                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OcupacionInfo).IsUnicode(false);
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.ToTable("Localidad");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Luminaria>(entity =>
            {
                entity.HasKey(e => e.LumId);

                entity.Property(e => e.LumId).HasColumnName("LUM_Id");

                entity.Property(e => e.LumAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("LUM_Alta");

                entity.Property(e => e.LumApellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Apellido");

                entity.Property(e => e.LumCalle1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Calle1");

                entity.Property(e => e.LumCalle2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Calle2");

                entity.Property(e => e.LumCalleL)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_CalleL");

                entity.Property(e => e.LumCalleL1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_CalleL1");

                entity.Property(e => e.LumCalleL2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_CalleL2");

                entity.Property(e => e.LumCorreo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Correo");

                entity.Property(e => e.LumDni).HasColumnName("LUM_DNI");

                entity.Property(e => e.LumDomicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Domicilio");

                entity.Property(e => e.LumLocalidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Localidad");

                entity.Property(e => e.LumNombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Nombres");

                entity.Property(e => e.LumPadron)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Padron");

                entity.Property(e => e.LumSugerencia)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Sugerencia");

                entity.Property(e => e.LumTelefono)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Telefono");

                entity.Property(e => e.TlumId).HasColumnName("TLUM_Id");
            });

            modelBuilder.Entity<LuminariasFoto>(entity =>
            {
                entity.HasKey(e => e.FotId);

                entity.Property(e => e.FotId).HasColumnName("FOT_Id");

                entity.Property(e => e.FotAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("FOT_Alta");

                entity.Property(e => e.FotDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOT_Descripcion");

                entity.Property(e => e.LumId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LUM_Id");
            });

            modelBuilder.Entity<LuminariasTipo>(entity =>
            {
                entity.HasKey(e => e.TlumId);

                entity.ToTable("LuminariasTipo");

                entity.Property(e => e.TlumId).HasColumnName("TLUM_Id");

                entity.Property(e => e.TlumBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("TLUM_BajaLogica");

                entity.Property(e => e.TlumDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TLUM_Descripcion");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu");

                entity.Property(e => e.MnuClase)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Clase")
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.MnuDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Descripcion")
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.MnuId).HasColumnName("MNU_Id");

                entity.Property(e => e.MnuNivel).HasColumnName("MNU_Nivel");

                entity.Property(e => e.MnuOrden).HasColumnName("MNU_Orden");

                entity.Property(e => e.MnuPadre).HasColumnName("MNU_Padre");

                entity.Property(e => e.MnuSistema).HasColumnName("MNU_Sistema");

                entity.Property(e => e.MnuTarget)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Target")
                    .UseCollation("Traditional_Spanish_CI_AS");

                entity.Property(e => e.MnuUrl)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Url")
                    .UseCollation("Traditional_Spanish_CI_AS");
            });

            modelBuilder.Entity<Menu2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu2");

                entity.Property(e => e.MnuBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("MNU_BajaLogica");

                entity.Property(e => e.MnuClase)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Clase");

                entity.Property(e => e.MnuDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Descripcion");

                entity.Property(e => e.MnuId).HasColumnName("MNU_Id");

                entity.Property(e => e.MnuNivel).HasColumnName("MNU_Nivel");

                entity.Property(e => e.MnuOrden).HasColumnName("MNU_Orden");

                entity.Property(e => e.MnuPadre).HasColumnName("MNU_Padre");

                entity.Property(e => e.MnuSistema).HasColumnName("MNU_Sistema");

                entity.Property(e => e.MnuTarget)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Target");

                entity.Property(e => e.MnuUrl)
                    .IsUnicode(false)
                    .HasColumnName("MNU_Url");
            });

            modelBuilder.Entity<Noticia>(entity =>
            {
                entity.HasKey(e => e.NotId);

                entity.Property(e => e.NotId).HasColumnName("NOT_Id");

                entity.Property(e => e.DelId).HasColumnName("DEL_Id");

                entity.Property(e => e.GestId).HasColumnName("GEST_Id");

                entity.Property(e => e.NotBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("NOT_BajaLogica");

                entity.Property(e => e.NotDescripcion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("NOT_Descripcion");

                entity.Property(e => e.NotFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("NOT_Fecha");

                entity.Property(e => e.NotFoto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Foto");

                entity.Property(e => e.NotPrincipal).HasColumnName("NOT_Principal");

                entity.Property(e => e.NotTema)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Tema");

                entity.Property(e => e.NotTitulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOT_Titulo");

                entity.Property(e => e.TnotId).HasColumnName("TNOT_Id");

                entity.Property(e => e.UsrId).HasColumnName("USR_Id");
            });

            modelBuilder.Entity<ObraSocial>(entity =>
            {
                entity.ToTable("ObraSocial");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
            });

            modelBuilder.Entity<PediTuSemilla>(entity =>
            {
                entity.ToTable("PediTuSemilla");

                entity.Property(e => e.ConocePuntoVerde)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConoceReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConocerResiduosReciclables)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DondeConsigueSemillas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.InformacionCompostaje)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparCompostComunitario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QhacesConMaterialReciclable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QHacesConMaterialReciclable");

                entity.Property(e => e.QueEspecieEs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealizaCompost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeparaResiduos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneArbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitoReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PediTuSemillaPrueba>(entity =>
            {
                entity.ToTable("PediTuSemillaPrueba");

                entity.Property(e => e.ConocePuntoVerde)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConoceReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConocerResiduosReciclables)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DondeConsigueSemillas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.InformacionCompostaje)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparCompostComunitario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QhacesConMaterialReciclable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QHacesConMaterialReciclable");

                entity.Property(e => e.QueEspecieEs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealizaCompost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeparaResiduos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneArbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitoReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Perfile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgesId).HasColumnName("AGES_Id");

                entity.Property(e => e.CarId).HasColumnName("CAR_Id");

                entity.Property(e => e.PerDescripcion)
                    .HasMaxLength(100)
                    .HasColumnName("PER_Descripcion")
                    .IsFixedLength(true);

                entity.Property(e => e.PerDescripcionBreve)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PER_DescripcionBreve");

                entity.Property(e => e.PerHtml)
                    .IsUnicode(false)
                    .HasColumnName("PER_Html");

                entity.Property(e => e.PerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PER_Id");

                entity.Property(e => e.PerImagen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PER_Imagen");

                entity.Property(e => e.PerNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PER_Nombre");

                entity.Property(e => e.PerOrden).HasColumnName("PER_Orden");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MnuId).HasColumnName("MNU_Id");

                entity.Property(e => e.PerBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("PER_BajaLogica");

                entity.Property(e => e.PerFechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("PER_FechaAlta");

                entity.Property(e => e.PerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PER_Id");

                entity.Property(e => e.PerPermiso).HasColumnName("PER_Permiso");

                entity.Property(e => e.RolId).HasColumnName("ROL_Id");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Calle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Depto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Padron)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonaChk>(entity =>
            {
                entity.ToTable("PersonaChk");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo5)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo6)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalle1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntreCalle2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Padron)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAlternativo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonaTemp>(entity =>
            {
                entity.ToTable("PersonaTemp");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Calle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Depto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Padron)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Piletum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FechaCupo).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.ToTable("Prueba");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConocePuntoVerde)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConoceReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConocerResiduosReciclables)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DondeConsigueSemillas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformacionCompostaje)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparCompostComunitario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParticiparHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QhacesConMaterialReciclable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QHacesConMaterialReciclable");

                entity.Property(e => e.QueEspecieEs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RealizaCompost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeparaResiduos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneArbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TieneHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoHuerta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitoReserva)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reclamo>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.RecId).HasColumnName("REC_Id");

                entity.Property(e => e.RecAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("REC_Alta");

                entity.Property(e => e.RecApellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Apellido");

                entity.Property(e => e.RecCalle1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Calle1");

                entity.Property(e => e.RecCalle2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Calle2");

                entity.Property(e => e.RecCalleR)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_CalleR");

                entity.Property(e => e.RecCalleR1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_CalleR1");

                entity.Property(e => e.RecCalleR2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_CalleR2");

                entity.Property(e => e.RecCorreo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Correo");

                entity.Property(e => e.RecDni).HasColumnName("REC_DNI");

                entity.Property(e => e.RecDomicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Domicilio");

                entity.Property(e => e.RecLocalidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Localidad");

                entity.Property(e => e.RecNombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Nombres");

                entity.Property(e => e.RecPadron)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Padron");

                entity.Property(e => e.RecSugerencia)
                    .IsUnicode(false)
                    .HasColumnName("REC_Sugerencia");

                entity.Property(e => e.RecTelefono)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Telefono");
            });

            modelBuilder.Entity<ReclamosFoto>(entity =>
            {
                entity.HasKey(e => e.FotId);

                entity.Property(e => e.FotId).HasColumnName("FOT_Id");

                entity.Property(e => e.FotAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("FOT_Alta");

                entity.Property(e => e.FotDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOT_Descripcion");

                entity.Property(e => e.RecId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REC_Id");
            });

            modelBuilder.Entity<ReclamosPrueba>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("ReclamosPrueba");

                entity.Property(e => e.RecId).HasColumnName("REC_Id");

                entity.Property(e => e.RecAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("REC_Alta");

                entity.Property(e => e.RecApellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Apellido");

                entity.Property(e => e.RecCalle1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Calle1");

                entity.Property(e => e.RecCalle2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Calle2");

                entity.Property(e => e.RecCalleP1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_CalleP1");

                entity.Property(e => e.RecCalleP2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_CalleP2");

                entity.Property(e => e.RecCorreo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Correo");

                entity.Property(e => e.RecDni).HasColumnName("REC_DNI");

                entity.Property(e => e.RecDomicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Domicilio");

                entity.Property(e => e.RecDomicilioP)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_DomicilioP");

                entity.Property(e => e.RecLocalidad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Localidad");

                entity.Property(e => e.RecNombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Nombres");

                entity.Property(e => e.RecPadron)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Padron");

                entity.Property(e => e.RecSugerencia)
                    .IsUnicode(false)
                    .HasColumnName("REC_Sugerencia");

                entity.Property(e => e.RecTelefono)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REC_Telefono");
            });

            modelBuilder.Entity<Renta>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApellidoYNombre)
                    .HasMaxLength(255)
                    .HasColumnName("Apellido y Nombre");

                entity.Property(e => e.Calle).HasMaxLength(255);

                entity.Property(e => e.DocuDescripcion).HasMaxLength(255);

                entity.Property(e => e.DocuNumero).HasMaxLength(255);

                entity.Property(e => e.DocuPersona).HasColumnName("DocuPersona ");

                entity.Property(e => e.Dpto).HasMaxLength(255);

                entity.Property(e => e.Localidad).HasMaxLength(255);

                entity.Property(e => e.Piso).HasMaxLength(255);

                entity.Property(e => e.Tasa).HasMaxLength(255);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolRule>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.RolId });

                entity.ToTable("RolRule");

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

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RolDescripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROL_Descripcion");

                entity.Property(e => e.RolId).HasColumnName("ROL_Id");
            });

            modelBuilder.Entity<Rubro>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
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

            modelBuilder.Entity<SemanasColonium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Semana)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.ToTable("Sexo");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Slider");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActivoD).HasColumnType("datetime");

                entity.Property(e => e.FechaActivoH).HasColumnType("datetime");

                entity.Property(e => e.FechaHabilitado).HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagenXs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImagenXS");

                entity.Property(e => e.Orid).HasColumnName("ORID");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<SubSeccione>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.Property(e => e.SubId).HasColumnName("SUB_Id");

                entity.Property(e => e.AgesId).HasColumnName("AGES_Id");

                entity.Property(e => e.SubDescripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SUB_Descripcion");

                entity.Property(e => e.SubStatus).HasColumnName("SUB_Status");

                entity.Property(e => e.SubTarget)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUB_Target");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TipoDocumento");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEntidad>(entity =>
            {
                entity.ToTable("TipoEntidad");

                entity.Property(e => e.Descripciion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPersona>(entity =>
            {
                entity.ToTable("TipoPersona");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSolicitud>(entity =>
            {
                entity.ToTable("TipoSolicitud");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.ToTable("TipoVehiculo");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposImagen>(entity =>
            {
                entity.HasKey(e => e.TimgId)
                    .HasName("PK_Tipo_Imagen");

                entity.ToTable("TiposImagen");

                entity.Property(e => e.TimgId).HasColumnName("TIMG_id");

                entity.Property(e => e.TimgDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIMG_Descripcion");
            });

            modelBuilder.Entity<TiposNoticium>(entity =>
            {
                entity.HasKey(e => e.TnotId);

                entity.Property(e => e.TnotId).HasColumnName("TNOT_Id");

                entity.Property(e => e.TnotDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TNOT_Descripcion")
                    .UseCollation("Traditional_Spanish_CI_AS");
            });

            modelBuilder.Entity<ToProfesion>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TO_Profesion");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToProfesional>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TO_Profesional");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.MatriculaMunicipal)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaProfesional)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.ToProfesionals)
                    .HasForeignKey(d => d.IdProfesion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TO_Profesional_TO_Profesion");

                entity.HasOne(d => d.IdTipoProfesionalNavigation)
                    .WithMany(p => p.ToProfesionals)
                    .HasForeignKey(d => d.IdTipoProfesional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TO_Profesional_TO_TipoProfesional");
            });

            modelBuilder.Entity<ToSolicitude>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TO_Solicitudes");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.FechaAprobacionDocumentacion).HasColumnType("datetime");

                entity.Property(e => e.FechaArchivado).HasColumnType("datetime");

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionMatriculaMunicipal).HasColumnType("datetime");

                entity.Property(e => e.FechaEmisionMatriculaProfesional).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistroComprobantePago).HasColumnType("datetime");

                entity.Property(e => e.MatriculaMunicipal)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaProfesional)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).ValueGeneratedOnAdd();

                entity.Property(e => e.ScanDniDorso)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ScanDNI_Dorso");

                entity.Property(e => e.ScanDniFrente)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ScanDNI_Frente");

                entity.Property(e => e.ScanPagoMatricula)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScanPagoRegistro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScanTituloHabilitante)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.ToSolicitudes)
                    .HasForeignKey(d => d.IdProfesion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TO_Solicitudes_TO_Profesion");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.ToSolicitudes)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TO_Solicitudes_TO_Status");

                entity.HasOne(d => d.IdTipoProfesionalNavigation)
                    .WithMany(p => p.ToSolicitudes)
                    .HasForeignKey(d => d.IdTipoProfesional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TO_Solicitudes_TO_TipoProfesional");
            });

            modelBuilder.Entity<ToStatus>(entity =>
            {
                entity.ToTable("TO_Status");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToTipoProfesional>(entity =>
            {
                entity.HasKey(e => e.Orid);

                entity.ToTable("TO_TipoProfesional");

                entity.Property(e => e.Orid)
                    .ValueGeneratedNever()
                    .HasColumnName("ORID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transparencium>(entity =>
            {
                entity.Property(e => e.Contestado).HasColumnType("datetime");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(900)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurDedicacion>(entity =>
            {
                entity.ToTable("...TurDedicacion");
            });

            modelBuilder.Entity<TurDedicacion1>(entity =>
            {
                entity.ToTable("TurDedicacion");
            });

            modelBuilder.Entity<TurDiaNoLaborablexProfesional>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TurDiaNoLaborablexProfesional");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Registro).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurDiasEspeciale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurDiasNoLaborable>(entity =>
            {
                entity.ToTable("_TurDiasNoLaborables");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurDiasNoLaborable1>(entity =>
            {
                entity.ToTable("TurDiasNoLaborables");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurHorariosAp>(entity =>
            {
                entity.ToTable("TurHorariosAP");

                entity.Property(e => e.CuposXhorario).HasColumnName("CuposXHorario");
            });

            modelBuilder.Entity<TurStatus>(entity =>
            {
                entity.ToTable("TurStatus");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurStatusNuevo>(entity =>
            {
                entity.ToTable("TurStatusNuevo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurStatusProtocolo>(entity =>
            {
                entity.ToTable("TurStatusProtocolo");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurTipoDiscapacidade>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TurTipoTurno>(entity =>
            {
                entity.ToTable("TurTipoTurno");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurTurno>(entity =>
            {
                entity.ToTable("TurTurno");

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaPresente).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoCancelado>(entity =>
            {
                entity.ToTable("TurTurnoCancelado");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cancelado).HasColumnType("datetime");

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaPresente).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoCanceladoNuevo>(entity =>
            {
                entity.ToTable("TurTurnoCanceladoNuevo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cancelado).HasColumnType("datetime");

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.ObservacionJun).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoNoConfirmado>(entity =>
            {
                entity.ToTable("TurTurnoNoConfirmado");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaPresente).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoNuevo>(entity =>
            {
                entity.ToTable("TurTurnoNuevo");

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.ObservacionJun).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoPresencial>(entity =>
            {
                entity.ToTable("TurTurnoPresencial");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);
            });

            modelBuilder.Entity<TurTurnoRechazado>(entity =>
            {
                entity.ToTable("TurTurnoRechazado");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FechaPresente).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<TurTurnoRechazadoNuevo>(entity =>
            {
                entity.ToTable("TurTurnoRechazadoNuevo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Confirmado).HasColumnType("datetime");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.ObservacionJun).IsUnicode(false);

                entity.Property(e => e.Registrado).HasColumnType("datetime");
            });

            modelBuilder.Entity<UnidadesSanitaria>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UniBarrio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Barrio");

                entity.Property(e => e.UniDireccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Direccion");

                entity.Property(e => e.UniEstablecimiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Establecimiento");

                entity.Property(e => e.UniId).HasColumnName("UNI_Id");

                entity.Property(e => e.UniTelefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Telefono");
            });

            modelBuilder.Entity<UnidadesSanitariasNuevo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UnidadesSanitariasNuevo");

                entity.Property(e => e.UniAtencion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Atencion");

                entity.Property(e => e.UniBarrio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Barrio");

                entity.Property(e => e.UniDireccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Direccion");

                entity.Property(e => e.UniEstablecimiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Establecimiento");

                entity.Property(e => e.UniId).HasColumnName("UNI_Id");

                entity.Property(e => e.UniTelefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNI_Telefono");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
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
            });

            modelBuilder.Entity<UserRol>(entity =>
            {
                entity.HasKey(e => new { e.RolId, e.UserId });

                entity.ToTable("UserRol");

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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsrId);

                entity.Property(e => e.UsrId).HasColumnName("USR_Id");

                entity.Property(e => e.RolId).HasColumnName("ROL_Id");

                entity.Property(e => e.UsrApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_Apellido");

                entity.Property(e => e.UsrBajaLogica)
                    .HasColumnType("datetime")
                    .HasColumnName("USR_BajaLogica");

                entity.Property(e => e.UsrFechaAlta)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("USR_Fecha_Alta")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrHabilitado).HasColumnName("USR_Habilitado");

                entity.Property(e => e.UsrMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_Mail");

                entity.Property(e => e.UsrNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_Nombre");

                entity.Property(e => e.UsrPassword)
                    .IsRequired()
                    .HasColumnName("USR_Password");

                entity.Property(e => e.UsrUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USR_Usuario");
            });

            modelBuilder.Entity<UsuarioEnte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsuarioEnte");
            });

            modelBuilder.Entity<UsuariosWeb>(entity =>
            {
                entity.ToTable("UsuariosWeb");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CP");

                entity.Property(e => e.Depto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Movil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiculosCompactado>(entity =>
            {
                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaVigencia).HasColumnType("datetime");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiculosCompactadosActa>(entity =>
            {
                entity.Property(e => e.ApellidoNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Chasis)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dominio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActa).HasColumnType("datetime");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MarcaModelo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Motor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroActa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehiculosCompactadosStatus>(entity =>
            {
                entity.ToTable("VehiculosCompactadosStatus");

                entity.Property(e => e.BajaLogica).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VoluntariosCovid>(entity =>
            {
                entity.ToTable("VoluntariosCovid");

                entity.Property(e => e.Carrera)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispHoraria).IsUnicode(false);

                entity.Property(e => e.Embarazo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.Materias)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.OtraCar)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
