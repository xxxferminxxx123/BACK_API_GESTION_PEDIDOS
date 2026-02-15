using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Infraestructura.Data
{
    public class ListarUsuarioDbContext : DbContext
    {
        public ListarUsuarioDbContext(DbContextOptions<ListarUsuarioDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }  // ← Modelo de EF

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>(entity =>
            {
                entity.ToTable("USUARIO");
                entity.HasKey(u => u.IdUsuario);

                entity.Property(u => u.IdUsuario)
                    .HasColumnName("ID_USUARIO");

                entity.Property(u => u.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(25);  // ← Solo esto, sin conversión

                entity.Property(u => u.IdPersona)
                    .HasColumnName("ID_PERSONA");

                entity.Property(u => u.Activo)
                    .HasColumnName("ACTIVO");

                entity.Property(u => u.FechaRegistro)
                    .HasColumnName("FECHA_REGISTRO");
            });
        }
    }
}