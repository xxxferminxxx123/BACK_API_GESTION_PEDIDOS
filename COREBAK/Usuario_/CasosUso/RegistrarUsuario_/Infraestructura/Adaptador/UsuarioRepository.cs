using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Data;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Adaptador
{
    public class UsuarioRepository 
        (
            ApplicationDbContext context
        ) : IRegistrarUsuarioRepository
    {
        public async Task RegistrarUsuario(RegistrarUsuario usuario)
        {
            context.Valor.Add(usuario);
            await context.SaveChangesAsync();
        }
    }
}