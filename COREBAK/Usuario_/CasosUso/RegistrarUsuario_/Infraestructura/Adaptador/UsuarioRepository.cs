using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Data;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Adaptador
{
    public class UsuarioRepository 
        : IRegistrarUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task RegistrarUsuario(RegistrarUsuario usuario)
        {
            _context.Valor.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}