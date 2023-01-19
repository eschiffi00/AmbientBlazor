using System;
using System.Collections.Generic;
using DataLogicLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLogicLibrary;

public partial class AmbientHouseDbContext : DbContext
{
    public AmbientHouseDbContext()
    {
    }

    public AmbientHouseDbContext(DbContextOptions<AmbientHouseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adicionale> Adicionales { get; set; }

    public virtual DbSet<AdicionalesItem> AdicionalesItems { get; set; }

    public virtual DbSet<AmbientacionCi> AmbientacionCis { get; set; }

    public virtual DbSet<AmbientacionSalon> AmbientacionSalons { get; set; }

    public virtual DbSet<AvisosClientesPorFecha> AvisosClientesPorFechas { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Bloqueo> Bloqueos { get; set; }

    public virtual DbSet<Caracteristica> Caracteristicas { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CategoriasArchivo> CategoriasArchivos { get; set; }

    public virtual DbSet<CategoriasItem> CategoriasItems { get; set; }

    public virtual DbSet<CentroCosto> CentroCostos { get; set; }

    public virtual DbSet<Cheque> Cheques { get; set; }

    public virtual DbSet<ChequesPagosProveedore> ChequesPagosProveedores { get; set; }

    public virtual DbSet<Ciudade> Ciudades { get; set; }

    public virtual DbSet<ClientesBi> ClientesBis { get; set; }

    public virtual DbSet<ClientesEventosMovimiento> ClientesEventosMovimientos { get; set; }

    public virtual DbSet<ClientesPrueba> ClientesPruebas { get; set; }

    public virtual DbSet<CobranzasVenta> CobranzasVentas { get; set; }

    public virtual DbSet<CodigoPorRubro> CodigoPorRubros { get; set; }

    public virtual DbSet<Comanda> Comandas { get; set; }

    public virtual DbSet<ComandaDetalle> ComandaDetalles { get; set; }

    public virtual DbSet<Comisione> Comisiones { get; set; }

    public virtual DbSet<ComprobantePagoProveedor> ComprobantePagoProveedors { get; set; }

    public virtual DbSet<ComprobantesPagado> ComprobantesPagados { get; set; }

    public virtual DbSet<ComprobantesProveedore> ComprobantesProveedores { get; set; }

    public virtual DbSet<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; set; }

    public virtual DbSet<CondicionIva> CondicionIvas { get; set; }

    public virtual DbSet<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; set; }

    public virtual DbSet<ControlEventosConfirmado> ControlEventosConfirmados { get; set; }

    public virtual DbSet<ConversionMoneda> ConversionMonedas { get; set; }

    public virtual DbSet<CostoAdicionale> CostoAdicionales { get; set; }

    public virtual DbSet<CostoAmbientacion> CostoAmbientacions { get; set; }

    public virtual DbSet<CostoBarra> CostoBarras { get; set; }

    public virtual DbSet<CostoCanon> CostoCanons { get; set; }

    public virtual DbSet<CostoCatering> CostoCaterings { get; set; }

    public virtual DbSet<CostoLogistica> CostoLogisticas { get; set; }

    public virtual DbSet<CostoSalone> CostoSalones { get; set; }

    public virtual DbSet<CostoTecnica> CostoTecnicas { get; set; }

    public virtual DbSet<CostosPaquetesCiambientacion> CostosPaquetesCiambientacions { get; set; }

    public virtual DbSet<Cuenta> Cuentas { get; set; }

    public virtual DbSet<CuentasLog> CuentasLogs { get; set; }

    public virtual DbSet<Degustacion> Degustacions { get; set; }

    public virtual DbSet<DegustacionDetalle> DegustacionDetalles { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DuracionEvento> DuracionEventos { get; set; }

    public virtual DbSet<EjecucionTareasProgramada> EjecucionTareasProgramadas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EmpleadoDepartamento1> EmpleadoDepartamentos1 { get; set; }

    public virtual DbSet<Empleadodepartamento> Empleadodepartamentos { get; set; }

    public virtual DbSet<EmpleadosPresupuestosAprobado> EmpleadosPresupuestosAprobados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<EventosConfirmadosProveedore> EventosConfirmadosProveedores { get; set; }

    public virtual DbSet<EventosConfirmadosReservadosTodo> EventosConfirmadosReservadosTodos { get; set; }

    public virtual DbSet<Eventostodo> Eventostodos { get; set; }

    public virtual DbSet<FacturaClienteDetalle> FacturaClienteDetalles { get; set; }

    public virtual DbSet<FacturasCliente> FacturasClientes { get; set; }

    public virtual DbSet<Familia> Familias { get; set; }

    public virtual DbSet<FechasBloqueada> FechasBloqueadas { get; set; }

    public virtual DbSet<Feriado> Feriados { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FormasdePago> FormasdePagos { get; set; }

    public virtual DbSet<GastosporPresupuesto> GastosporPresupuestos { get; set; }

    public virtual DbSet<GruposItem> GruposItems { get; set; }

    public virtual DbSet<Herramienta> Herramientas { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Indexacion> Indexacions { get; set; }

    public virtual DbSet<Intermediario> Intermediarios { get; set; }

    public virtual DbSet<InventarioDeposito> InventarioDepositos { get; set; }

    public virtual DbSet<InventarioMovimientoProducto> InventarioMovimientoProductos { get; set; }

    public virtual DbSet<InventarioPedido> InventarioPedidos { get; set; }

    public virtual DbSet<InventarioProducto> InventarioProductos { get; set; }

    public virtual DbSet<InventarioProductoDeposito> InventarioProductoDepositos { get; set; }

    public virtual DbSet<InventarioReceta> InventarioRecetas { get; set; }

    public virtual DbSet<InventarioRequerimiento> InventarioRequerimientos { get; set; }

    public virtual DbSet<InventarioRequerimientoDetalle> InventarioRequerimientoDetalles { get; set; }

    public virtual DbSet<InventarioUnidade> InventarioUnidades { get; set; }

    public virtual DbSet<InventarioUnidadesConversion> InventarioUnidadesConversions { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemDetalle> ItemDetalles { get; set; }

    public virtual DbSet<Items2> Items2s { get; set; }

    public virtual DbSet<Jornada> Jornadas { get; set; }

    public virtual DbSet<LiquidacionHorasPersonal> LiquidacionHorasPersonals { get; set; }

    public virtual DbSet<LiquidacionHorasPersonalDetalle> LiquidacionHorasPersonalDetalles { get; set; }

    public virtual DbSet<Locacione> Locaciones { get; set; }

    public virtual DbSet<LocacionesValorAnio> LocacionesValorAnios { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<MomentosDia> MomentosDias { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<NombreFantasium> NombreFantasia { get; set; }

    public virtual DbSet<NotaCredito> NotaCreditos { get; set; }

    public virtual DbSet<ObjetivosEmpleado> ObjetivosEmpleados { get; set; }

    public virtual DbSet<ObjetivosGrupo> ObjetivosGrupos { get; set; }

    public virtual DbSet<ObtenerAdicione> ObtenerAdiciones { get; set; }

    public virtual DbSet<ObtenerArchivosPorCategoria> ObtenerArchivosPorCategorias { get; set; }

    public virtual DbSet<ObtenerCantidadInvitadosBarra> ObtenerCantidadInvitadosBarras { get; set; }

    public virtual DbSet<ObtenerCantidadInvitadosCatering> ObtenerCantidadInvitadosCaterings { get; set; }

    public virtual DbSet<ObtenerCantidadPersonasAdicionalesCatering> ObtenerCantidadPersonasAdicionalesCaterings { get; set; }

    public virtual DbSet<ObtenerCliente> ObtenerClientes { get; set; }

    public virtual DbSet<ObtenerContactosCliente> ObtenerContactosClientes { get; set; }

    public virtual DbSet<ObtenerDatosParaPresupuesto> ObtenerDatosParaPresupuestos { get; set; }

    public virtual DbSet<ObtenerEvento> ObtenerEventos { get; set; }

    public virtual DbSet<ObtenerEventosNew> ObtenerEventosNews { get; set; }

    public virtual DbSet<ObtenerEventosSeguimiento> ObtenerEventosSeguimientos { get; set; }

    public virtual DbSet<ObtenerFamilia> ObtenerFamilias { get; set; }

    public virtual DbSet<ObtenerGruposconFamilia> ObtenerGruposconFamilias { get; set; }

    public virtual DbSet<ObtenerPrecioCostoBarra> ObtenerPrecioCostoBarras { get; set; }

    public virtual DbSet<ObtenerPrecioCostoCatering> ObtenerPrecioCostoCaterings { get; set; }

    public virtual DbSet<ObtenerPrecioCostoTecnica> ObtenerPrecioCostoTecnicas { get; set; }

    public virtual DbSet<ObtenerPresupuestoAmbientacion> ObtenerPresupuestoAmbientacions { get; set; }

    public virtual DbSet<ObtenerPresupuestoArtistica> ObtenerPresupuestoArtisticas { get; set; }

    public virtual DbSet<ObtenerPresupuestoAudiovisual> ObtenerPresupuestoAudiovisuals { get; set; }

    public virtual DbSet<ObtenerPresupuestoBarra> ObtenerPresupuestoBarras { get; set; }

    public virtual DbSet<ObtenerPresupuestoCatering> ObtenerPresupuestoCaterings { get; set; }

    public virtual DbSet<ObtenerPresupuestoSalon> ObtenerPresupuestoSalons { get; set; }

    public virtual DbSet<ObtenerPresupuestoTecnica> ObtenerPresupuestoTecnicas { get; set; }

    public virtual DbSet<ObtenerUsuario> ObtenerUsuarios { get; set; }

    public virtual DbSet<OrganizacionItem> OrganizacionItems { get; set; }

    public virtual DbSet<OrganizacionPresupuestoDetalle> OrganizacionPresupuestoDetalles { get; set; }

    public virtual DbSet<OrganizacionPresupuestoProveedoresExterno> OrganizacionPresupuestoProveedoresExternos { get; set; }

    public virtual DbSet<OrganizacionPresupuestoTimming> OrganizacionPresupuestoTimmings { get; set; }

    public virtual DbSet<OrganizacionPresupuestosArchivo> OrganizacionPresupuestosArchivos { get; set; }

    public virtual DbSet<PagosCliente> PagosClientes { get; set; }

    public virtual DbSet<PagosProveedore> PagosProveedores { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Parametro1> Parametros1 { get; set; }

    public virtual DbSet<Perfile> Perfiles { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PlanesDePago> PlanesDePagos { get; set; }

    public virtual DbSet<Presupuesto> Presupuestos { get; set; }

    public virtual DbSet<PresupuestoDetalle> PresupuestoDetalles { get; set; }

    public virtual DbSet<PresupuestosAvencer> PresupuestosAvencers { get; set; }

    public virtual DbSet<ProcesoCierre> ProcesoCierres { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosCatering> ProductosCaterings { get; set; }

    public virtual DbSet<ProductosCateringItem> ProductosCateringItems { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<ProveedoresExterno> ProveedoresExternos { get; set; }

    public virtual DbSet<ProveedoresFormasdePago> ProveedoresFormasdePagos { get; set; }

    public virtual DbSet<ProveedoresPago> ProveedoresPagos { get; set; }

    public virtual DbSet<ProveedoresRetencione> ProveedoresRetenciones { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    public virtual DbSet<Ratio> Ratios { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<ReciboEventoPresupuesto> ReciboEventoPresupuestos { get; set; }

    public virtual DbSet<ReporteAdiocionale> ReporteAdiocionales { get; set; }

    public virtual DbSet<ReporteComprobante> ReporteComprobantes { get; set; }

    public virtual DbSet<ReporteEventosCobranza> ReporteEventosCobranzas { get; set; }

    public virtual DbSet<ReporteEventosPorUnidadesdeNegocio> ReporteEventosPorUnidadesdeNegocios { get; set; }

    public virtual DbSet<ResponsablesEvento> ResponsablesEventos { get; set; }

    public virtual DbSet<Retencione> Retenciones { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<RubrosProveedore> RubrosProveedores { get; set; }

    public virtual DbSet<Sectore> Sectores { get; set; }

    public virtual DbSet<SectoresEmpresa> SectoresEmpresas { get; set; }

    public virtual DbSet<Segmento> Segmentos { get; set; }

    public virtual DbSet<SeguimientosEventosClientesEstado> SeguimientosEventosClientesEstados { get; set; }

    public virtual DbSet<TablaRetencione> TablaRetenciones { get; set; }

    public virtual DbSet<TecnicaSalon> TecnicaSalons { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<Tiempo> Tiempos { get; set; }

    public virtual DbSet<TipoBarraCategoriaItem> TipoBarraCategoriaItems { get; set; }

    public virtual DbSet<TipoCatering> TipoCaterings { get; set; }

    public virtual DbSet<TipoCateringAdicional> TipoCateringAdicionals { get; set; }

    public virtual DbSet<TipoCateringFamilium> TipoCateringFamilia { get; set; }

    public virtual DbSet<TipoCateringTiempoProductoItem> TipoCateringTiempoProductoItems { get; set; }

    public virtual DbSet<TipoComprobante> TipoComprobantes { get; set; }

    public virtual DbSet<TipoComprobanteImpuesto> TipoComprobanteImpuestos { get; set; }

    public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }

    public virtual DbSet<TipoEvento> TipoEventos { get; set; }

    public virtual DbSet<TipoLogistica> TipoLogisticas { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

    public virtual DbSet<TipoPagoEmpleado> TipoPagoEmpleados { get; set; }

    public virtual DbSet<TipoServicio> TipoServicios { get; set; }

    public virtual DbSet<TipoServicioAdicional> TipoServicioAdicionals { get; set; }

    public virtual DbSet<TiposBarra> TiposBarras { get; set; }

    public virtual DbSet<Transferencia> Transferencias { get; set; }

    public virtual DbSet<UnidadesNegocio> UnidadesNegocios { get; set; }

    public virtual DbSet<UnidadesNegociosProveedore> UnidadesNegociosProveedores { get; set; }

    public virtual DbSet<UnidadesNegociosTipoMovimiento> UnidadesNegociosTipoMovimientos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuario1> Usuarios1 { get; set; }

    public virtual DbSet<UsuarioPipeDriveAmbient> UsuarioPipeDriveAmbients { get; set; }

    public virtual DbSet<UsuarioRol> UsuarioRols { get; set; }

    public virtual DbSet<UsuariosGrupo> UsuariosGrupos { get; set; }

    public virtual DbSet<UsuariosLocacione> UsuariosLocaciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=w230092_AmbientHouse;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Adicionale>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RequiereCantidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RequiereCantidadRango)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SoloMayores)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Estado).WithMany(p => p.Adicionales)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adicionales_Estados");

            entity.HasOne(d => d.Rubro).WithMany(p => p.Adicionales)
                .HasForeignKey(d => d.RubroId)
                .HasConstraintName("FK_Adicionales_Rubros");
        });

        modelBuilder.Entity<AdicionalesItem>(entity =>
        {
            entity.HasOne(d => d.Adicional).WithMany(p => p.AdicionalesItems)
                .HasForeignKey(d => d.AdicionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdicionalesItems_Adicionales");

            entity.HasOne(d => d.Item).WithMany(p => p.AdicionalesItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdicionalesItems_Items");
        });

        modelBuilder.Entity<AmbientacionCi>(entity =>
        {
            entity.ToTable("AmbientacionCI");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmbientacionSalon>(entity =>
        {
            entity.ToTable("AmbientacionSalon");

            entity.HasOne(d => d.Locacion).WithMany(p => p.AmbientacionSalons)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmbientacionSalon_Locaciones");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.AmbientacionSalons)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmbientacionSalon_Proveedores");
        });

        modelBuilder.Entity<AvisosClientesPorFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AvisosClientesPorFecha");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.FechaAviso).HasColumnType("datetime");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bloqueo>(entity =>
        {
            entity.ToTable("Bloqueo");

            entity.HasIndex(e => e.BloqueoId, "Unique_BloqueoId").IsUnique();

            entity.Property(e => e.Control).HasMaxLength(40);
            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Form).WithMany(p => p.Bloqueos)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Form_Bloqueo");

            entity.HasOne(d => d.Rol).WithMany(p => p.Bloqueos)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Rol_Bloqueo");
        });

        modelBuilder.Entity<Caracteristica>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Categorias_Caracteristicas");

            entity.HasOne(d => d.Locacion).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Categorias_Locaciones");

            entity.HasOne(d => d.Segmento).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Categorias_Segmentos");
        });

        modelBuilder.Entity<CategoriasArchivo>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CategoriasItem>(entity =>
        {
            entity.ToTable("CategoriasItem");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CentroCosto>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cheque>(entity =>
        {
            entity.Property(e => e.EmitidoA)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.NroCheque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.TipoCheque)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Banco).WithMany(p => p.Cheques)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cheques_Bancos");

            entity.HasOne(d => d.Estado).WithMany(p => p.Cheques)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cheques_Estados");
        });

        modelBuilder.Entity<ChequesPagosProveedore>(entity =>
        {
            entity.HasOne(d => d.Cheque).WithMany(p => p.ChequesPagosProveedores)
                .HasForeignKey(d => d.ChequeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChequesPagosProveedores_Cheques");

            entity.HasOne(d => d.PagoProveedor).WithMany(p => p.ChequesPagosProveedores)
                .HasForeignKey(d => d.PagoProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChequesPagosProveedores_PagosProveedores");
        });

        modelBuilder.Entity<Ciudade>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Cp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CP");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Provincia).WithMany(p => p.Ciudades)
                .HasForeignKey(d => d.ProvinciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ciudades_Provincias");
        });

        modelBuilder.Entity<ClientesBi>(entity =>
        {
            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CondicionIva)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuilcuit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUILCUIT");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailContactoAdministracion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailContactoContratacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailContactoOrganizacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailContactoTesoreia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PersonaFisicaJuridica)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TelContactoAdministracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelContactoContratacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelContactoOrganizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelContactoTesoreria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ClientesEventosMovimiento>(entity =>
        {
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.FechaSeguimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClientesPrueba>(entity =>
        {
            entity.ToTable("ClientesPrueba");

            entity.Property(e => e.Mail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Organizacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("organizacion");
            entity.Property(e => e.Persona)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Propietario).HasColumnName("propietario");
            entity.Property(e => e.Tel)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tel");
        });

        modelBuilder.Entity<CobranzasVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CobranzasVentas");

            entity.Property(e => e.Concepto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroRecibo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TipoIndexacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Totalpresupuestosinindexacion).HasColumnName("TOTALPRESUPUESTOSININDEXACION");
        });

        modelBuilder.Entity<CodigoPorRubro>(entity =>
        {
            entity.ToTable("CodigoPorRubro");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Rubro).WithMany(p => p.CodigoPorRubros)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodigoPorRubro_Rubros");
        });

        modelBuilder.Entity<Comanda>(entity =>
        {
            entity.Property(e => e.Coordinador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento)
                .HasColumnType("date")
                .HasColumnName("fechaEvento");
            entity.Property(e => e.HorarioFin)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorarioInicio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorarioLlegada)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JefeProducto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Maitre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Organizador)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoExperiencia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ComandaDetalle>(entity =>
        {
            entity.ToTable("ComandaDetalle");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comisione>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ComprobantePagoProveedor>(entity =>
        {
            entity.ToTable("ComprobantePagoProveedor");

            entity.HasOne(d => d.ComprobanteProveedor).WithMany(p => p.ComprobantePagoProveedors)
                .HasForeignKey(d => d.ComprobanteProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantePagoProveedor_ComprobantesProveedores");

            entity.HasOne(d => d.PagoProveedor).WithMany(p => p.ComprobantePagoProveedors)
                .HasForeignKey(d => d.PagoProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantePagoProveedor_PagosProveedores");
        });

        modelBuilder.Entity<ComprobantesPagado>(entity =>
        {
            entity.Property(e => e.Tmdescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TMDescripcion");
        });

        modelBuilder.Entity<ComprobantesProveedore>(entity =>
        {
            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.GeneraOp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GeneraOP");
            entity.Property(e => e.Iibbarba).HasColumnName("IIBBARBA");
            entity.Property(e => e.Iibbcaba).HasColumnName("IIBBCABA");
            entity.Property(e => e.PercepcionIva).HasColumnName("PercepcionIVA");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Cuenta).WithMany(p => p.ComprobantesProveedores)
                .HasForeignKey(d => d.CuentaId)
                .HasConstraintName("FK_ComprobantesProveedores_Cuentas");

            entity.HasOne(d => d.Estado).WithMany(p => p.ComprobantesProveedores)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_Estados");

            entity.HasOne(d => d.FormadePago).WithMany(p => p.ComprobantesProveedores)
                .HasForeignKey(d => d.FormadePagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_FormasdePago");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ComprobantesProveedores)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_ComprobantesProveedores_Proveedores");

            entity.HasOne(d => d.TipoComprobante).WithMany(p => p.ComprobantesProveedores)
                .HasForeignKey(d => d.TipoComprobanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_TipoComprobantes");
        });

        modelBuilder.Entity<ComprobantesProveedoresDetalle>(entity =>
        {
            entity.ToTable("ComprobantesProveedores_Detalles");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CentroCosto).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.CentroCostoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_CentroCostos");

            entity.HasOne(d => d.ComprobanteProveedor).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.ComprobanteProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_ComprobantesProveedores");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.PresupuestoId)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_Presupuestos");

            entity.HasOne(d => d.TipoImpuesto).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.TipoImpuestoId)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_Impuestos");

            entity.HasOne(d => d.TipoMoviemiento).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.TipoMoviemientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_TipoMovimientos");

            entity.HasOne(d => d.UnidadNegocio).WithMany(p => p.ComprobantesProveedoresDetalles)
                .HasForeignKey(d => d.UnidadNegocioId)
                .HasConstraintName("FK_ComprobantesProveedores_Detalles_UnidadesNegocios");
        });

        modelBuilder.Entity<CondicionIva>(entity =>
        {
            entity.ToTable("CondicionIva");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConfiguracionCateringTecnica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfiguracionCatering");

            entity.ToTable("ConfiguracionCateringTecnica");

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionCatering_Caracteristicas");

            entity.HasOne(d => d.Duracion).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.DuracionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionCateringTecnica_DuracionEvento");

            entity.HasOne(d => d.MomentoDia).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.MomentoDiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionCatering_MomentosDias");

            entity.HasOne(d => d.Segmento).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionCatering_Segmentos");

            entity.HasOne(d => d.TipoCatering).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.TipoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionCatering_TipoCatering");

            entity.HasOne(d => d.TipoServicio).WithMany(p => p.ConfiguracionCateringTecnicas)
                .HasForeignKey(d => d.TipoServicioId)
                .HasConstraintName("FK_ConfiguracionCatering_TipoServicios");
        });

        modelBuilder.Entity<ControlEventosConfirmado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ControlEventosConfirmados");
        });

        modelBuilder.Entity<ConversionMoneda>(entity =>
        {
            entity.Property(e => e.Conversion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MonedaDestino).WithMany(p => p.ConversionMonedaMonedaDestinos)
                .HasForeignKey(d => d.MonedaDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConversionMonedas_Monedas1");

            entity.HasOne(d => d.MonedaOrigen).WithMany(p => p.ConversionMonedaMonedaOrigens)
                .HasForeignKey(d => d.MonedaOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConversionMonedas_Monedas");
        });

        modelBuilder.Entity<CostoAdicionale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CostoAdicional");

            entity.HasOne(d => d.Adicional).WithMany(p => p.CostoAdicionales)
                .HasForeignKey(d => d.AdicionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoAdicionales_Adicional");
        });

        modelBuilder.Entity<CostoAmbientacion>(entity =>
        {
            entity.ToTable("CostoAmbientacion");

            entity.HasOne(d => d.Categoria).WithMany(p => p.CostoAmbientacions)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoAmbientacion_Categorias");
        });

        modelBuilder.Entity<CostoBarra>(entity =>
        {
            entity.ToTable("CostoBarra");

            entity.HasOne(d => d.TipoBarra).WithMany(p => p.CostoBarras)
                .HasForeignKey(d => d.TipoBarraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoBarra_TiposBarras");
        });

        modelBuilder.Entity<CostoCanon>(entity =>
        {
            entity.ToTable("CostoCanon");

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.CostoCanons)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoCanon_Caracteristicas");

            entity.HasOne(d => d.Segmento).WithMany(p => p.CostoCanons)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoCanon_Segmentos");

            entity.HasOne(d => d.TipoCatering).WithMany(p => p.CostoCanons)
                .HasForeignKey(d => d.TipoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoCanon_TipoCatering");
        });

        modelBuilder.Entity<CostoCatering>(entity =>
        {
            entity.ToTable("CostoCatering");

            entity.HasOne(d => d.TipoCatering).WithMany(p => p.CostoCaterings)
                .HasForeignKey(d => d.TipoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoCatering_TipoCatering");
        });

        modelBuilder.Entity<CostoLogistica>(entity =>
        {
            entity.ToTable("CostoLogistica");

            entity.HasOne(d => d.Concepto).WithMany(p => p.CostoLogisticas)
                .HasForeignKey(d => d.ConceptoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoLogistica_TipoLogistica");

            entity.HasOne(d => d.LocalidadNavigation).WithMany(p => p.CostoLogisticas)
                .HasForeignKey(d => d.Localidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoLogistica_Localidades");
        });

        modelBuilder.Entity<CostoSalone>(entity =>
        {
            entity.Property(e => e.Dia)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Jornada).WithMany(p => p.CostoSalones)
                .HasForeignKey(d => d.JornadaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoSalones_Jornadas");

            entity.HasOne(d => d.Locacion).WithMany(p => p.CostoSalones)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoSalones_Locaciones");

            entity.HasOne(d => d.Sector).WithMany(p => p.CostoSalones)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoSalones_Sectores");
        });

        modelBuilder.Entity<CostoTecnica>(entity =>
        {
            entity.ToTable("CostoTecnica");

            entity.Property(e => e.Dia)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Segmento).WithMany(p => p.CostoTecnicas)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoTecnica_Segmentos");

            entity.HasOne(d => d.TipoServicio).WithMany(p => p.CostoTecnicas)
                .HasForeignKey(d => d.TipoServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostoTecnica_TipoServicios");
        });

        modelBuilder.Entity<CostosPaquetesCiambientacion>(entity =>
        {
            entity.ToTable("CostosPaquetesCIAmbientacion");

            entity.Property(e => e.PaqueteCiid).HasColumnName("PaqueteCIID");

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.CostosPaquetesCiambientacions)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostosPaquetesCIAmbientacion_Caracteristicas");

            entity.HasOne(d => d.PaqueteCi).WithMany(p => p.CostosPaquetesCiambientacions)
                .HasForeignKey(d => d.PaqueteCiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostosPaquetesCIAmbientacion_AmbientacionCI");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.CostosPaquetesCiambientacions)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostosPaquetesCIAmbientacion_Proveedores");

            entity.HasOne(d => d.Segmento).WithMany(p => p.CostosPaquetesCiambientacions)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostosPaquetesCIAmbientacion_Segmentos");
        });

        modelBuilder.Entity<Cuenta>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_Cuentas_Empresas");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.MonedaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuentas_Monedas");
        });

        modelBuilder.Entity<CuentasLog>(entity =>
        {
            entity.ToTable("Cuentas_Log");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cuenta).WithMany(p => p.CuentasLogs)
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuentas_Log_Cuentas");
        });

        modelBuilder.Entity<Degustacion>(entity =>
        {
            entity.ToTable("Degustacion");

            entity.Property(e => e.FechaDegustacion).HasColumnType("datetime");
            entity.Property(e => e.HoraCorporativo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HoraSocial)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Estado).WithMany(p => p.Degustacions)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Degustacion_Estados");
        });

        modelBuilder.Entity<DegustacionDetalle>(entity =>
        {
            entity.ToTable("DegustacionDetalle");

            entity.Property(e => e.Comensal)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EstadoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegustacionDetalle_Caracteristicas");

            entity.HasOne(d => d.Degustacion).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.DegustacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegustacionDetalle_Degustacion");

            entity.HasOne(d => d.Empleado).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegustacionDetalle_Empleados");

            entity.HasOne(d => d.Estado).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegustacionDetalle_Estados");

            entity.HasOne(d => d.Locacion).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.LocacionId)
                .HasConstraintName("FK_DegustacionDetalle_Locaciones");

            entity.HasOne(d => d.Segmento).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegustacionDetalle_Segmentos");

            entity.HasOne(d => d.TipoEvento).WithMany(p => p.DegustacionDetalles)
                .HasForeignKey(d => d.TipoEventoId)
                .HasConstraintName("FK_DegustacionDetalle_TipoEventos");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DuracionEvento>(entity =>
        {
            entity.ToTable("DuracionEvento");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EjecucionTareasProgramada>(entity =>
        {
            entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CelularFijoLaboral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CP");
            entity.Property(e => e.Cplegal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CPLegal");
            entity.Property(e => e.Cuil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DireccionLegal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.HorarioDesde)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HorarioHasta)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailLaboral)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroPc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Sac).HasColumnName("SAC");
            entity.Property(e => e.TelefonoFijo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoFijoLaboral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoMovil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CiudadLegal).WithMany(p => p.EmpleadoCiudadLegals)
                .HasForeignKey(d => d.CiudadLegalId)
                .HasConstraintName("FK_Empleados_Ciudades1");

            entity.HasOne(d => d.Estado).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.EstadoId)
                .HasConstraintName("FK_Empleados_Estados");

            entity.HasOne(d => d.Localidad).WithMany(p => p.EmpleadoLocalidads)
                .HasForeignKey(d => d.LocalidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_Ciudades");

            entity.HasOne(d => d.SectorEmpresa).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.SectorEmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_SectoresEmpresa");

            entity.HasOne(d => d.TipoEmpleado).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.TipoEmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_TipoEmpleados");
        });

        modelBuilder.Entity<EmpleadoDepartamento1>(entity =>
        {
            entity.ToTable("EmpleadoDepartamentos");

            entity.HasOne(d => d.Departamento).WithMany(p => p.EmpleadoDepartamento1s)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoDepartamentos_Departamentos");

            entity.HasOne(d => d.Empleado).WithMany(p => p.EmpleadoDepartamento1s)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadoDepartamentos_Empleados");
        });

        modelBuilder.Entity<Empleadodepartamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMPLEADODEPARTAMENTO");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpleadosPresupuestosAprobado>(entity =>
        {
            entity.Property(e => e.HoraIngresoCoordinador1)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HoraIngresoCoordinador2)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.EmpleadosPresupuestosAprobados)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmpleadosPresupuestosAprobados_Presupuestos");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.Property(e => e.CondicionIva)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TipoEmpresa)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entidad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.Property(e => e.ApellidoNombreCliente)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ComprobanteAprovacionExtension)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ComprobanteTransferenciaExtension)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaComprobanteTransSenia).HasColumnType("datetime");
            entity.Property(e => e.FechaSena).HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NroComprobanteTransSenia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoIndexacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ChequeSena).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.ChequeSenaId)
                .HasConstraintName("FK_Eventos_Cheques");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Eventos_Empleados");

            entity.HasOne(d => d.Estado).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Eventos_Estados");

            entity.HasOne(d => d.FormadePago).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.FormadePagoId)
                .HasConstraintName("FK_Eventos_FormasdePago");
        });

        modelBuilder.Entity<EventosConfirmadosProveedore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EventosConfirmadosProveedores");

            entity.Property(e => e.Anioevento).HasColumnName("ANIOEVENTO");
            entity.Property(e => e.Costos).HasColumnName("COSTOS");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Cuit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Diaevento).HasColumnName("DIAEVENTO");
            entity.Property(e => e.Importepagado).HasColumnName("IMPORTEPAGADO");
            entity.Property(e => e.Mesevento).HasColumnName("MESEVENTO");
            entity.Property(e => e.Nropresupuesto).HasColumnName("NROPRESUPUESTO");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventosConfirmadosReservadosTodo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EventosConfirmadosReservadosTODOS");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICA");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Eventostodo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EVENTOSTODOS");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nropresupuesto).HasColumnName("NROPRESUPUESTO");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoEventos)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FacturaClienteDetalle>(entity =>
        {
            entity.ToTable("FacturaClienteDetalle");

            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");

            entity.HasOne(d => d.FacturaCliente).WithMany(p => p.FacturaClienteDetalles)
                .HasForeignKey(d => d.FacturaClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturaClienteDetalle_FacturasCliente");
        });

        modelBuilder.Entity<FacturasCliente>(entity =>
        {
            entity.ToTable("FacturasCliente");

            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Cliente).WithMany(p => p.FacturasClientes)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturasCliente_ClientesBis");

            entity.HasOne(d => d.Empresa).WithMany(p => p.FacturasClientes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturasCliente_Empresas");

            entity.HasOne(d => d.Estado).WithMany(p => p.FacturasClientes)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturasCliente_Estados");

            entity.HasOne(d => d.TipoComprobante).WithMany(p => p.FacturasClientes)
                .HasForeignKey(d => d.TipoComprobanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacturasCliente_TipoComprobantes");
        });

        modelBuilder.Entity<Familia>(entity =>
        {
            entity.HasKey(e => new { e.GrupoId, e.CategoriaItemId });

            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Edad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fantasia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Subtitulo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoriaItem).WithMany(p => p.Familia)
                .HasForeignKey(d => d.CategoriaItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Familias_CategoriasItem");

            entity.HasOne(d => d.Grupo).WithMany(p => p.Familia)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Familias_GruposItems");
        });

        modelBuilder.Entity<FechasBloqueada>(entity =>
        {
            entity.Property(e => e.FechaBloqueada).HasColumnType("datetime");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.SePasaA).HasColumnType("datetime");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.ToTable("Form");

            entity.HasIndex(e => e.FormId, "Unique_FormId").IsUnique();

            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<FormasdePago>(entity =>
        {
            entity.ToTable("FormasdePago");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GastosporPresupuesto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GastosporPresupuestos");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Centrocosto)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CENTROCOSTO");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMPUESTO");
            entity.Property(e => e.Leyenda)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tipomovimiento)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TIPOMOVIMIENTO");
        });

        modelBuilder.Entity<GruposItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GruposItems_1");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Herramienta>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExtencionArchivo)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoriaArchivo).WithMany(p => p.Herramienta)
                .HasForeignKey(d => d.CategoriaArchivoId)
                .HasConstraintName("FK_Herramientas_CategoriasArchivos");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Indexacion>(entity =>
        {
            entity.ToTable("Indexacion");

            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.TipoIndexacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Intermediario>(entity =>
        {
            entity.Property(e => e.TipoComision)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Locacion).WithMany(p => p.Intermediarios)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Intermediarios_Locaciones");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Intermediarios)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Intermediarios_Proveedores");

            entity.HasOne(d => d.UnidadNegocio).WithMany(p => p.Intermediarios)
                .HasForeignKey(d => d.UnidadNegocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Intermediarios_UnidadesNegocios");
        });

        modelBuilder.Entity<InventarioDeposito>(entity =>
        {
            entity.ToTable("INVENTARIO_Depositos");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InventarioMovimientoProducto>(entity =>
        {
            entity.ToTable("INVENTARIO_Movimiento_Producto");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Producto).WithMany(p => p.InventarioMovimientoProductos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Movimiento_Producto_INVENTARIO_Producto");
        });

        modelBuilder.Entity<InventarioPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inventario_Pedido");

            entity.ToTable("INVENTARIO_Pedido");

            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<InventarioProducto>(entity =>
        {
            entity.ToTable("INVENTARIO_Producto");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Rubro).WithMany(p => p.InventarioProductos)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Producto_Rubros");

            entity.HasOne(d => d.Unidad).WithMany(p => p.InventarioProductoUnidads)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Producto_INVENTARIO_Unidades");

            entity.HasOne(d => d.UnidadMedidaConversion).WithMany(p => p.InventarioProductos)
                .HasForeignKey(d => d.UnidadMedidaConversionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Producto_INVENTARIO_UnidadesConversion");

            entity.HasOne(d => d.UnidadPresentacion).WithMany(p => p.InventarioProductoUnidadPresentacions)
                .HasForeignKey(d => d.UnidadPresentacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Producto_INVENTARIO_Unidades1");
        });

        modelBuilder.Entity<InventarioProductoDeposito>(entity =>
        {
            entity.ToTable("INVENTARIO_ProductoDeposito");

            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

            entity.HasOne(d => d.Deposito).WithMany(p => p.InventarioProductoDepositos)
                .HasForeignKey(d => d.DepositoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_ProductoDeposito_INVENTARIO_Depositos");

            entity.HasOne(d => d.Producto).WithMany(p => p.InventarioProductoDepositos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_ProductoDeposito_INVENTARIO_Producto");
        });

        modelBuilder.Entity<InventarioReceta>(entity =>
        {
            entity.ToTable("INVENTARIO_Recetas");

            entity.HasOne(d => d.Ingrediente).WithMany(p => p.InventarioRecetaIngredientes)
                .HasForeignKey(d => d.IngredienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Recetas_INVENTARIO_Producto1");

            entity.HasOne(d => d.Producto).WithMany(p => p.InventarioRecetaProductos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Recetas_INVENTARIO_Producto");

            entity.HasOne(d => d.Unidad).WithMany(p => p.InventarioReceta)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_Recetas_INVENTARIO_Unidades");
        });

        modelBuilder.Entity<InventarioRequerimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INVENTARIO_Requerimiento_1");

            entity.ToTable("INVENTARIO_Requerimiento");

            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.Detalle)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<InventarioRequerimientoDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INVENTARIO_Requerimiento");

            entity.ToTable("INVENTARIO_Requerimiento_Detalle");

            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Pedido).WithMany(p => p.InventarioRequerimientoDetalles)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("FK_INVENTARIO_Requerimiento_Detalle_INVENTARIO_Pedido");

            entity.HasOne(d => d.Requerimiento).WithMany(p => p.InventarioRequerimientoDetalles)
                .HasForeignKey(d => d.RequerimientoId)
                .HasConstraintName("FK_INVENTARIO_Requerimiento_Detalle_INVENTARIO_Requerimiento");
        });

        modelBuilder.Entity<InventarioUnidade>(entity =>
        {
            entity.ToTable("INVENTARIO_Unidades");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InventarioUnidadesConversion>(entity =>
        {
            entity.ToTable("INVENTARIO_UnidadesConversion");

            entity.HasOne(d => d.UnidadDestino).WithMany(p => p.InventarioUnidadesConversionUnidadDestinos)
                .HasForeignKey(d => d.UnidadDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_UnidadesConversion_INVENTARIO_Unidades1");

            entity.HasOne(d => d.UnidadOriginal).WithMany(p => p.InventarioUnidadesConversionUnidadOriginals)
                .HasForeignKey(d => d.UnidadOriginalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTARIO_UnidadesConversion_INVENTARIO_Unidades");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Detalle)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TipoItem)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoriaItem).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoriaItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Items_CategoriasItem");
        });

        modelBuilder.Entity<ItemDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemDetalle");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Items2>(entity =>
        {
            entity.ToTable("Items2");

            entity.Property(e => e.Detalle)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TipoItem)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoriaItem).WithMany(p => p.Items2s)
                .HasForeignKey(d => d.CategoriaItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Items_CategoriasItem2");
        });

        modelBuilder.Entity<Jornada>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LiquidacionHorasPersonal>(entity =>
        {
            entity.ToTable("LiquidacionHorasPersonal");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCreate).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LiquidacionHorasPersonalDetalle>(entity =>
        {
            entity.ToTable("LiquidacionHorasPersonal_Detalle");

            entity.Property(e => e.FechaCreate).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.HoraEntrada)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HoraSalida)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.LiquidacionHorasPersonalDetalles)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiquidacionHorasPersonal_Detalle_Empleados");

            entity.HasOne(d => d.LiquidacionPersonalHora).WithMany(p => p.LiquidacionHorasPersonalDetalles)
                .HasForeignKey(d => d.LiquidacionPersonalHoraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiquidacionHorasPersonal_Detalle_LiquidacionHorasPersonal");

            entity.HasOne(d => d.TipoPago).WithMany(p => p.LiquidacionHorasPersonalDetalles)
                .HasForeignKey(d => d.TipoPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LiquidacionHorasPersonal_Detalle_TipoPagoEmpleados");
        });

        modelBuilder.Entity<Locacione>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AireLibre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Comisiona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estacionamiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TieneLogistica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoCannonAmbientacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCannonBarra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCannonCatering)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoLocacion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Verde)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("web");

            entity.HasOne(d => d.Localidad).WithMany(p => p.Locaciones)
                .HasForeignKey(d => d.LocalidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locaciones_Localidades");
        });

        modelBuilder.Entity<LocacionesValorAnio>(entity =>
        {
            entity.ToTable("LocacionesValorAnio");

            entity.HasOne(d => d.Locacion).WithMany(p => p.LocacionesValorAnios)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocacionesValorAnio_Locaciones");
        });

        modelBuilder.Entity<Localidade>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MomentosDia>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.TipoMoviemiento).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.TipoMoviemientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimientos_TipoMovimientos");
        });

        modelBuilder.Entity<NombreFantasium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<NotaCredito>(entity =>
        {
            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<ObjetivosEmpleado>(entity =>
        {
            entity.HasOne(d => d.Empleado).WithMany(p => p.ObjetivosEmpleados)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjetivosEmpleados_Empleados");
        });

        modelBuilder.Entity<ObjetivosGrupo>(entity =>
        {
            entity.HasOne(d => d.Grupo).WithMany(p => p.ObjetivosGrupos)
                .HasForeignKey(d => d.GrupoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjetivosGrupos_UsuariosGrupos");
        });

        modelBuilder.Entity<ObtenerAdicione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerAdiciones");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.EstadoDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequiereCantidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rubro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerArchivosPorCategoria>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerArchivosPorCategorias");

            entity.Property(e => e.Carpeta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExtencionArchivo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerCantidadInvitadosBarra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerCantidadInvitadosBarras");
        });

        modelBuilder.Entity<ObtenerCantidadInvitadosCatering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerCantidadInvitadosCatering");
        });

        modelBuilder.Entity<ObtenerCantidadPersonasAdicionalesCatering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerCantidadPersonasAdicionalesCatering");
        });

        modelBuilder.Entity<ObtenerCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerClientes");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.ComoLlegoOtro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaContacto).HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ObtenerContactosCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerContactosClientes");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoyNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerDatosParaPresupuesto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerDatosParaPresupuesto");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioPresupuesto)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaContacto).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaPresupuesto).HasColumnType("datetime");
            entity.Property(e => e.HoraFinalizado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorarioArmado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocacionOtra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Segmento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoLocacion)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ObtenerEvento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerEventos");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(401)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPresupuesto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaSena).HasColumnType("datetime");
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerEventosNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerEventosNew");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(401)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPresupuesto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaSena).HasColumnType("datetime");
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.TipoBarra)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoExperiencia)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerEventosSeguimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerEventosSeguimiento");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoNombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerFamilia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerFamilias");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Edad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fantasia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Subtitulo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerGruposconFamilia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerGruposconFamilias");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPrecioCostoBarra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPrecioCostoBarra");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPrecioCostoCatering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPrecioCostoCatering");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPrecioCostoTecnica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPrecioCostoTecnica");

            entity.Property(e => e.Dia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Segmento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoAmbientacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoAmbientacion");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristicas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Segmento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoArtistica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoArtistica");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoAudiovisual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoAudiovisual");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoBarra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoBarra");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalonInOut)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoCatering>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoCatering");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoSalon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoSalon");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerPresupuestoTecnica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerPresupuestoTecnica");

            entity.Property(e => e.Adjunto)
                .HasMaxLength(5000)
                .IsFixedLength();
            entity.Property(e => e.AdjuntoExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObtenerUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObtenerUsuarios");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrganizacionItem>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RequiereCantidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrganizacionPresupuestoDetalle>(entity =>
        {
            entity.ToTable("OrganizacionPresupuestoDetalle");

            entity.HasIndex(e => e.PresupuestoId, "UQ__Organiza__E2E362FE424FBD49").IsUnique();

            entity.Property(e => e.Acreditaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlfombraRoja)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Anexo7)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Bocados)
                .HasMaxLength(1200)
                .IsUnicode(false);
            entity.Property(e => e.CantPersonasAfectadasArmado)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ContactoResponsableLugar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CumpleaniosEnEvento)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Entrada)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.EnvioMailPresentacion)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Escenario)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaArmadoLogistica)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaArmadoSalon)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaDesarmadoSalon)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaMailPresentacion).HasColumnType("datetime");
            entity.Property(e => e.FinFiesta)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.HoraArmadoLogistica)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HoraArmadoSalon)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HoraDesarmadoSalon)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IngresoProveedoresLugar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InvitadosDespues00)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Islas)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Layout)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ListaCocheras)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ListaInvitados)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LleganAlSalon)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LocacionOtra)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Manteleria)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MesaDulce)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.MesaPrincipal)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MotivoFestejo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionAmbientacion)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionBarras)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionCatering)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionParticulares)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionTecnica)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesAdicionales)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesHielo)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesLogistica)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesManteleria)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesMoviliario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.PlatosEspeciales)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.PostreAdultosAdolescentes)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.PostreChicos)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.PrincipalAdolescentes)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.PrincipalAdultos)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.PrincipalChicos)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Ramo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RealizoReunionConCliente)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ServiciodeVinoChampagne)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Servilletas)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sillas)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoResponsableLugar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TortaAlegorica)
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.HasOne(d => d.Presupuesto).WithOne(p => p.OrganizacionPresupuestoDetalle)
                .HasForeignKey<OrganizacionPresupuestoDetalle>(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizacionPresupuestoDetalle_Presupuestos");
        });

        modelBuilder.Entity<OrganizacionPresupuestoProveedoresExterno>(entity =>
        {
            entity.Property(e => e.Contacto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ProveedorExterno)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Rubro)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.OrganizacionPresupuestoProveedoresExternos)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizacionPresupuestoProveedoresExternos_Presupuestos");
        });

        modelBuilder.Entity<OrganizacionPresupuestoTimming>(entity =>
        {
            entity.ToTable("OrganizacionPresupuestoTimming");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.OrganizacionPresupuestoTimmings)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizacionPresupuestoTimming_Presupuestos");
        });

        modelBuilder.Entity<OrganizacionPresupuestosArchivo>(entity =>
        {
            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.Desripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.OrganizacionPresupuestosArchivos)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizacionPresupuestosArchivos_Empleados");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.OrganizacionPresupuestosArchivos)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizacionPresupuestosArchivos_Presupuestos");
        });

        modelBuilder.Entity<PagosCliente>(entity =>
        {
            entity.Property(e => e.Concepto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreate).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.NroRecibo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoPago)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa).WithMany(p => p.PagosClientes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosClientes_Empresas");

            entity.HasOne(d => d.Estado).WithMany(p => p.PagosClientes)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosClientes_Estados");

            entity.HasOne(d => d.FormadePago).WithMany(p => p.PagosClientes)
                .HasForeignKey(d => d.FormadePagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosClientes_FormasdePago");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.PagosClientes)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosClientes_Presupuestos");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.PagosClientes)
                .HasForeignKey(d => d.TipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosClientes_TipoMovimientos");
        });

        modelBuilder.Entity<PagosProveedore>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaTransferencia).HasColumnType("datetime");
            entity.Property(e => e.NroComprobanteTransferencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroOrdenPago)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cuenta).WithMany(p => p.PagosProveedores)
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagosProveedores_Cuentas");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.ToTable("Parametro");

            entity.HasIndex(e => e.ParametroId, "Unique_ParametroId").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Parametro1>(entity =>
        {
            entity.ToTable("Parametros");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Perfile>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.ToTable("Permiso");

            entity.HasIndex(e => e.PermisoId, "Unique_PermisoId").IsUnique();

            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Form).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Form_Permiso");

            entity.HasOne(d => d.Rol).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Rol_Permiso");
        });

        modelBuilder.Entity<PlanesDePago>(entity =>
        {
            entity.ToTable("PlanesDePago");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Presupuesto>(entity =>
        {
            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DireccionOtra)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaPresupuesto).HasColumnType("datetime");
            entity.Property(e => e.HoraFinalizado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorarioArmado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocacionOtra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MomentoDiaId).HasColumnName("MomentoDiaID");
            entity.Property(e => e.TipoEventoOtro)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Caracteristica).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.CaracteristicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Caracteristicas");

            entity.HasOne(d => d.Duracion).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.DuracionId)
                .HasConstraintName("FK_Presupuestos_DuracionEvento");

            entity.HasOne(d => d.Estado).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Estados");

            entity.HasOne(d => d.Evento).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Eventos");

            entity.HasOne(d => d.Jornada).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.JornadaId)
                .HasConstraintName("FK_Presupuestos_Jornadas");

            entity.HasOne(d => d.Locacion).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Locaciones");

            entity.HasOne(d => d.MomentoDia).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.MomentoDiaId)
                .HasConstraintName("FK_Presupuestos_MomentosDias");

            entity.HasOne(d => d.Segmento).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_Segmentos");

            entity.HasOne(d => d.TipoEvento).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.TipoEventoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuestos_TipoEventos");
        });

        modelBuilder.Entity<PresupuestoDetalle>(entity =>
        {
            entity.ToTable("PresupuestoDetalle");

            entity.Property(e => e.CodigoItem)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ComentarioProveedor)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Delete).HasDefaultValueSql("((0))");
            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCobroItem).HasColumnType("datetime");
            entity.Property(e => e.FechaCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.PrecioSeleccionado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.PresupuestoDetalles)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoDetalle_Presupuestos");
        });

        modelBuilder.Entity<PresupuestosAvencer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PresupuestosAVencer");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICA");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPresupuesto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaPresupuesto).HasColumnType("datetime");
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcesoCierre>(entity =>
        {
            entity.ToTable("ProcesoCierre");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Dia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVendimiento).HasColumnType("datetime");

            entity.HasOne(d => d.Perfil).WithMany(p => p.Productos)
                .HasForeignKey(d => d.PerfilId)
                .HasConstraintName("FK_Productos_Perfiles");

            entity.HasOne(d => d.UnidadNegocio).WithMany(p => p.Productos)
                .HasForeignKey(d => d.UnidadNegocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_UnidadesNegocios");
        });

        modelBuilder.Entity<ProductosCatering>(entity =>
        {
            entity.ToTable("ProductosCatering");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductosCateringItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ProductosCateringItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductosCateringItems_Items");

            entity.HasOne(d => d.ProductoCatering).WithMany(p => p.ProductosCateringItems)
                .HasForeignKey(d => d.ProductoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductosCateringItems_ProductosCatering");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.Property(e => e.Cbu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CBU");
            entity.Property(e => e.Cuit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreFantasia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NroCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroIibb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NroIIBB");
            entity.Property(e => e.Propio)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CondicionIva).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.CondicionIvaId)
                .HasConstraintName("FK_Proveedores_CondicionIva");
        });

        modelBuilder.Entity<ProveedoresExterno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProveedoresExternos");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.HoraFinalizado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Rubro)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalInvitados).HasColumnName("Total Invitados");
        });

        modelBuilder.Entity<ProveedoresFormasdePago>(entity =>
        {
            entity.ToTable("ProveedoresFormasdePago");

            entity.HasOne(d => d.FormadePago).WithMany(p => p.ProveedoresFormasdePagos)
                .HasForeignKey(d => d.FormadePagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedoresFormasdePago_FormasdePago");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedoresFormasdePagos)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedoresFormasdePago_Proveedores");
        });

        modelBuilder.Entity<ProveedoresPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProveedoresPagos");

            entity.Property(e => e.CuentaContable)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cuit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FechaSena).HasColumnType("datetime");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UnidadNegocio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProveedoresRetencione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProveedoresRetenciones_1");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedoresRetenciones)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedoresRetenciones_Proveedores1");

            entity.HasOne(d => d.TablaRetencion).WithMany(p => p.ProveedoresRetenciones)
                .HasForeignKey(d => d.TablaRetencionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProveedoresRetenciones_TABLA_Retenciones");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Prueba");

            entity.Property(e => e.Fecha)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.Importe)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("importe");
            entity.Property(e => e.PresupuestoId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("presupuestoId");
        });

        modelBuilder.Entity<Ratio>(entity =>
        {
            entity.Property(e => e.ExperienciaBarra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoRatio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Recibo>(entity =>
        {
            entity.Property(e => e.Concepto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreate).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaRecibo).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.NroRecibo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.FormadePago).WithMany(p => p.Recibos)
                .HasForeignKey(d => d.FormadePagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recibos_FormasdePago");
        });

        modelBuilder.Entity<ReciboEventoPresupuesto>(entity =>
        {
            entity.ToTable("ReciboEventoPresupuesto");

            entity.HasOne(d => d.Evento).WithMany(p => p.ReciboEventoPresupuestos)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReciboEventoPresupuesto_Eventos");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.ReciboEventoPresupuestos)
                .HasForeignKey(d => d.PresupuestoId)
                .HasConstraintName("FK_ReciboEventoPresupuesto_Presupuestos");

            entity.HasOne(d => d.Recibo).WithMany(p => p.ReciboEventoPresupuestos)
                .HasForeignKey(d => d.ReciboId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReciboEventoPresupuesto_Recibos");
        });

        modelBuilder.Entity<ReporteAdiocionale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReporteAdiocionales");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Fechaevento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FECHAEVENTO");
            entity.Property(e => e.Nroevento).HasColumnName("NROEVENTO");
            entity.Property(e => e.Nropresupuesto).HasColumnName("NROPRESUPUESTO");
            entity.Property(e => e.Rubro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReporteComprobante>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReporteComprobantes");

            entity.Property(e => e.Cc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CC");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(551)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FormadePago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Impuesto).HasColumnName("IMPUESTO");
            entity.Property(e => e.Impuestointerno).HasColumnName("IMPUESTOINTERNO");
            entity.Property(e => e.Leyenda)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Neto).HasColumnName("NETO");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReporteEventosCobranza>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReporteEventosCobranzas");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Aniosenia).HasColumnName("ANIOSENIA");
            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CostoTotal).HasColumnName("COSTO TOTAL");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Diasenia).HasColumnName("DIASENIA");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Messenia).HasColumnName("MESSENIA");
            entity.Property(e => e.PrecioSeleccionado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioTotal).HasColumnName("PRECIO TOTAL");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalInvitados).HasColumnName("Total Invitados");
            entity.Property(e => e.TotalPagado).HasColumnName("TOTAL PAGADO");
            entity.Property(e => e.TotalPresupuestoSinIndexacion).HasColumnName("TOTAL PRESUPUESTO SIN INDEXACION");
            entity.Property(e => e.UnidadDeNegocio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Unidad de Negocio");
            entity.Property(e => e.UnidadNegocioAdicional)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorComisionable).HasColumnName("VALOR COMISIONABLE");
        });

        modelBuilder.Entity<ReporteEventosPorUnidadesdeNegocio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReporteEventosPorUnidadesdeNegocios");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICA");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComoLlego)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPresupuesto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEnvioPresupuesto).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JORNADA");
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Segmento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoBarra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoCatering)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTecnica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoAmbientacion)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoArtistica)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoAudiovisual)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoBarra)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoCatering)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoSalon)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ValorVendidoTecnica)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResponsablesEvento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ResponsablesEventos");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Coordinador1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coordinador 1");
            entity.Property(e => e.Coordinador2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coordinador 2");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.HoraFinalizado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraIngresoCoordinador1)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HoraIngresoCoordinador2)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.HorarioEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCACION");
            entity.Property(e => e.Organizador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RespBarra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Barra");
            entity.Property(e => e.RespCocina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Cocina");
            entity.Property(e => e.RespLogistica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Logistica");
            entity.Property(e => e.RespLogisticaArmado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Logistica Armado");
            entity.Property(e => e.RespLogisticaDesarmado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Logistica Desarmado");
            entity.Property(e => e.RespOperaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Operaciones");
            entity.Property(e => e.RespSalon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Resp. Salon");
            entity.Property(e => e.Segmento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalInvitados).HasColumnName("Total Invitados");
        });

        modelBuilder.Entity<Retencione>(entity =>
        {
            entity.Property(e => e.CreateFecha).HasColumnType("datetime");
            entity.Property(e => e.DeleteFecha).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NroCertificado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateFecha).HasColumnType("datetime");

            entity.HasOne(d => d.PagoCliente).WithMany(p => p.Retenciones)
                .HasForeignKey(d => d.PagoClienteId)
                .HasConstraintName("FK_Retenciones_PagosClientes");

            entity.HasOne(d => d.PagoProveedor).WithMany(p => p.Retenciones)
                .HasForeignKey(d => d.PagoProveedorId)
                .HasConstraintName("FK_Retenciones_PagosProveedores");

            entity.HasOne(d => d.TipoMovimimiento).WithMany(p => p.Retenciones)
                .HasForeignKey(d => d.TipoMovimimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Retenciones_TipoMovimientos");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol");

            entity.HasIndex(e => e.RolId, "Unique_RolId").IsUnique();

            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre).HasMaxLength(40);
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.RubroId).HasName("PK_Rubros_1");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LetraCodigo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RubrosProveedore>(entity =>
        {
            entity.ToTable("Rubros_Proveedores");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.RubrosProveedores)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rubros_Proveedores_Proveedores");

            entity.HasOne(d => d.Rubro).WithMany(p => p.RubrosProveedores)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rubros_Proveedores_Rubros");
        });

        modelBuilder.Entity<Sectore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SectorId");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Locacion).WithMany(p => p.Sectores)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sectores_Locaciones");
        });

        modelBuilder.Entity<SectoresEmpresa>(entity =>
        {
            entity.ToTable("SectoresEmpresa");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Departamento).WithMany(p => p.SectoresEmpresas)
                .HasForeignKey(d => d.DepartamentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SectoresEmpresa_Departamentos");
        });

        modelBuilder.Entity<Segmento>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SeguimientosEventosClientesEstado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SeguimientosEventosClientesEstados");

            entity.Property(e => e.ApellidoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoNombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Caracteristica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPresupuesto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaSeguimiento).HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TablaRetencione>(entity =>
        {
            entity.ToTable("TABLA_Retenciones");

            entity.Property(e => e.Concepto)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TecnicaSalon>(entity =>
        {
            entity.ToTable("TecnicaSalon");

            entity.HasOne(d => d.Locacion).WithMany(p => p.TecnicaSalons)
                .HasForeignKey(d => d.LocacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TecnicaSalon_Locaciones");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.TecnicaSalons)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TecnicaSalon_Proveedores");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp");

            entity.Property(e => e.Campo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("campo1");
        });

        modelBuilder.Entity<Tiempo>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImagenMarcoSuperiorExtension)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoBarraCategoriaItem>(entity =>
        {
            entity.ToTable("TipoBarraCategoriaItem");

            entity.HasOne(d => d.CategoriaItem).WithMany(p => p.TipoBarraCategoriaItems)
                .HasForeignKey(d => d.CategoriaItemId)
                .HasConstraintName("FK_TipoBarraCategoriaItem_CategoriasItem");

            entity.HasOne(d => d.TipoBarra).WithMany(p => p.TipoBarraCategoriaItems)
                .HasForeignKey(d => d.TipoBarraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoBarraCategoriaItem_TiposBarras");
        });

        modelBuilder.Entity<TipoCatering>(entity =>
        {
            entity.ToTable("TipoCatering");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.EsAdicional)
                .HasMaxLength(1)
                .IsFixedLength();

            entity.HasOne(d => d.Rubro).WithMany(p => p.TipoCaterings)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoCatering_Rubros");
        });

        modelBuilder.Entity<TipoCateringAdicional>(entity =>
        {
            entity.ToTable("TipoCateringAdicional");

            entity.HasOne(d => d.Adicional).WithMany(p => p.TipoCateringAdicionals)
                .HasForeignKey(d => d.AdicionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoCateringAdicional_Adicionales");

            entity.HasOne(d => d.TipoCatering).WithMany(p => p.TipoCateringAdicionals)
                .HasForeignKey(d => d.TipoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoCateringAdicional_TipoCatering");
        });

        modelBuilder.Entity<TipoCateringFamilium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TipoCateringFamilia_1");
        });

        modelBuilder.Entity<TipoCateringTiempoProductoItem>(entity =>
        {
            entity.ToTable("TipoCateringTiempoProductoItem");

            entity.HasOne(d => d.CategoriaItem).WithMany(p => p.TipoCateringTiempoProductoItems)
                .HasForeignKey(d => d.CategoriaItemId)
                .HasConstraintName("FK_TipoCateringTiempoProductoItem_CategoriasItem");

            entity.HasOne(d => d.ProductoCatering).WithMany(p => p.TipoCateringTiempoProductoItems)
                .HasForeignKey(d => d.ProductoCateringId)
                .HasConstraintName("FK_TipoCateringTiempoProductoItem_ProductosCatering");

            entity.HasOne(d => d.Tiempo).WithMany(p => p.TipoCateringTiempoProductoItems)
                .HasForeignKey(d => d.TiempoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoCateringTiempoProductoItem_Tiempos");

            entity.HasOne(d => d.TipoCatering).WithMany(p => p.TipoCateringTiempoProductoItems)
                .HasForeignKey(d => d.TipoCateringId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoCateringTiempoProductoItem_TipoCatering");
        });

        modelBuilder.Entity<TipoComprobante>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.CondicionIva).WithMany(p => p.TipoComprobantes)
                .HasForeignKey(d => d.CondicionIvaId)
                .HasConstraintName("FK_TipoComprobantes_CondicionIva");
        });

        modelBuilder.Entity<TipoComprobanteImpuesto>(entity =>
        {
            entity.ToTable("TipoComprobante_Impuestos");

            entity.HasOne(d => d.Impuesto).WithMany(p => p.TipoComprobanteImpuestos)
                .HasForeignKey(d => d.ImpuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoComprobante_Impuestos_Impuestos");

            entity.HasOne(d => d.TipoComprobante).WithMany(p => p.TipoComprobanteImpuestos)
                .HasForeignKey(d => d.TipoComprobanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoComprobante_Impuestos_TipoComprobantes");
        });

        modelBuilder.Entity<TipoEmpleado>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.SectorEmpresa).WithMany(p => p.TipoEmpleados)
                .HasForeignKey(d => d.SectorEmpresaId)
                .HasConstraintName("FK_TipoEmpleados_SectoresEmpresa");
        });

        modelBuilder.Entity<TipoEvento>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoLogistica>(entity =>
        {
            entity.ToTable("TipoLogistica");

            entity.Property(e => e.Concepto)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CuentasGastos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoGasto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Visible)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoPagoEmpleado>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoServicio>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Rubro).WithMany(p => p.TipoServicios)
                .HasForeignKey(d => d.RubroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoServicios_Rubros");
        });

        modelBuilder.Entity<TipoServicioAdicional>(entity =>
        {
            entity.ToTable("TipoServicioAdicional");

            entity.HasOne(d => d.Adicional).WithMany(p => p.TipoServicioAdicionals)
                .HasForeignKey(d => d.AdicionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoServicioAdicional_Adicionales");

            entity.HasOne(d => d.TipoServicio).WithMany(p => p.TipoServicioAdicionals)
                .HasForeignKey(d => d.TipoServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoServicioAdicional_TipoServicios");
        });

        modelBuilder.Entity<TiposBarra>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RangoEtareo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Duracion).WithMany(p => p.TiposBarras)
                .HasForeignKey(d => d.DuracionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TiposBarras_DuracionEvento");

            entity.HasOne(d => d.Segmento).WithMany(p => p.TiposBarras)
                .HasForeignKey(d => d.SegmentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TiposBarras_Segmentos");
        });

        modelBuilder.Entity<Transferencia>(entity =>
        {
            entity.Property(e => e.ComprobanteExtension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreate).HasColumnType("datetime");
            entity.Property(e => e.FechaDelete).HasColumnType("datetime");
            entity.Property(e => e.FechaTransferencia).HasColumnType("datetime");
            entity.Property(e => e.FechaUpdate).HasColumnType("datetime");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.NroTransferencia)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Banco).WithMany(p => p.Transferencia)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transferencias_Bancos");
        });

        modelBuilder.Entity<UnidadesNegocio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Rubros");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnidadesNegociosProveedore>(entity =>
        {
            entity.ToTable("UnidadesNegocios_Proveedores");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.UnidadesNegociosProveedores)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadesNegocios_Proveedores_Proveedores");

            entity.HasOne(d => d.UnidadNegocio).WithMany(p => p.UnidadesNegociosProveedores)
                .HasForeignKey(d => d.UnidadNegocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadesNegocios_Proveedores_UnidadesNegocios");
        });

        modelBuilder.Entity<UnidadesNegociosTipoMovimiento>(entity =>
        {
            entity.ToTable("UnidadesNegocios_TipoMovimientos");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.UnidadesNegociosTipoMovimientos)
                .HasForeignKey(d => d.TipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadesNegocios_TipoMovimientos_TipoMovimientos");

            entity.HasOne(d => d.UnidadNegocio).WithMany(p => p.UnidadesNegociosTipoMovimientos)
                .HasForeignKey(d => d.UnidadNegocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadesNegocios_TipoMovimientos_UnidadesNegocios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.HasIndex(e => e.UsuarioId, "Unique_UsuarioId").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");
            entity.Property(e => e.FeCreacion).HasColumnType("datetime");
            entity.Property(e => e.LoginName).HasMaxLength(40);
            entity.Property(e => e.Nombre).HasMaxLength(60);
            entity.Property(e => e.Password).HasMaxLength(40);
        });

        modelBuilder.Entity<Usuario1>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId);

            entity.ToTable("Usuarios");

            entity.Property(e => e.EmpleadoId).ValueGeneratedNever();
            entity.Property(e => e.CodigoSeguridad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RutaCodigoSeguridad)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithOne(p => p.Usuario1)
                .HasForeignKey<Usuario1>(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Empleados");

            entity.HasOne(d => d.Estado).WithMany(p => p.Usuario1s)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Estados");

            entity.HasOne(d => d.Perfil).WithMany(p => p.Usuario1s)
                .HasForeignKey(d => d.PerfilId)
                .HasConstraintName("FK_Usuarios_Perfiles");
        });

        modelBuilder.Entity<UsuarioPipeDriveAmbient>(entity =>
        {
            entity.ToTable("UsuarioPipeDrive_Ambient");
        });

        modelBuilder.Entity<UsuarioRol>(entity =>
        {
            entity.ToTable("UsuarioRol");

            entity.HasIndex(e => e.UsuarioRolId, "Unique_UsuarioRolId").IsUnique();

            entity.Property(e => e.EstadoId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Rol_UsuarioRol");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_Usuario_UsuarioRol");
        });

        modelBuilder.Entity<UsuariosGrupo>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
