using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Entidad;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Data
{
    public class RolDbContext
         : DbContext
    {
        public RolDbContext(DbContextOptions<RolDbContext> options)
            : base(options)
        {
        }
        public DbSet<RegistrarRol> valor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RegistrarRol>(entity =>
            {
                entity.ToTable("TRC_ROL");

                entity.HasKey(u => u.RolId);
                entity.Property(u => u.RolId)
                    .HasColumnName("ROL_ID")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWID()");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(25)
                    .IsRequired();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(25)
                    .IsRequired();

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .IsRequired();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.UsuarioRegistro)
                    .HasColumnName("USUARIO_REGISTO")
                    .HasMaxLength(20);
            });
        }
    }
}