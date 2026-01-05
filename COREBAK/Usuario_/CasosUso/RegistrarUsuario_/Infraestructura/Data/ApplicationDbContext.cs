using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Data
{
    public class ApplicationDbContext 
        : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RegistrarUsuario> Valor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RegistrarUsuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasKey(u => u.IdUsuario);
                entity.Property(u => u.IdUsuario)
                    .HasColumnName("ID_USUARIO")
                    .IsRequired()
                    .ValueGeneratedOnAdd() 
                    .HasDefaultValueSql("NEWID()");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(25)
                    .IsRequired()
                    .HasConversion(
                        v => v.Value,
                        v => new UsuarioVO(v)
                    );

                entity.Property(e => e.IdPersona)
                    .HasColumnName("ID_PERSONA")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWID()");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .IsRequired();


                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()"); 
            });
        }
    }
}   