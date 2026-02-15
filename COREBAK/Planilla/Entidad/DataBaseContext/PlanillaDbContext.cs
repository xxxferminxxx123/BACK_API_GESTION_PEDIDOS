using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Entidad;
using COREBAK.Planilla.Entidad.Base;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Planilla.Entidad.DataBaseContext
{
    public class PlanillaDbContext : DbContext
    {
        public PlanillaDbContext(DbContextOptions<PlanillaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Planilla_> Planillas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Planilla_>(entity =>
            {
                entity.ToTable("TRC_PLANILLA_CABECERA");

                entity.HasKey(u => u.PlanillaId);
                entity.Property(u => u.PlanillaId)
                    .HasColumnName("PLANILLA_ID")
                    .HasColumnType("UNIQUEIDENTIFIER")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWID()");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(10)
                    .IsRequired();

                entity.Property(e => e.FechaConfiguracion)
                    .HasColumnName("FECHA_CONFIGURACION")
                    .HasColumnType("DATE");

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SUPERVISOR_ID")
                    .IsRequired();

                entity.Property(e => e.FundoId)
                    .HasColumnName("FUNDO_ID")
                    .IsRequired();

                entity.Property(e => e.CultivoId)
                    .HasColumnName("CULTIVO_ID")
                    .IsRequired();

                entity.Property(e => e.AreadId)
                    .HasColumnName("AREA_ID")
                    .IsRequired();

                entity.Property(e => e.GrupoId)
                    .HasColumnName("GRUPO_ID")
                    .IsRequired();

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(1);

                entity.Property(e => e.UsuarioRegistro)
                    .HasColumnName("USUARIO_REGISTO")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasMaxLength(20);
            });
        }
    }
}