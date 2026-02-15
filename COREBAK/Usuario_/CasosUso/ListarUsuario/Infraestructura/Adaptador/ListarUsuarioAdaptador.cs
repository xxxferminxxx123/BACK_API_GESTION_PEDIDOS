using COREBAK.Usuario_.CasosUso.ListarUsuario.Aplicacion;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Infraestructura.Adaptador
{
    public class ListarUsuarioAdaptador(
            ListarUsuarioDbContext context
        ) : IListarUsuario
    {
        public async Task<List<EListarUsuario>> ListarUsuario()
        {
            var usuariosDb = await context.Usuarios
                .Where(u => u.Activo == true)  
                .ToListAsync();

            return usuariosDb.Select(u => new EListarUsuario(
                u.IdUsuario,
                u.Usuario,
                u.IdPersona,
                u.Activo,
                u.FechaRegistro
            )).ToList();
        }
    }
}