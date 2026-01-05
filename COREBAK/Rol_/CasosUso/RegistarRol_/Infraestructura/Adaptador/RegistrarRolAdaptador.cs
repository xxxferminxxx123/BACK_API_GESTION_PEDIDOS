using COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Data;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Entidad;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Interface;

namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Adaptador
{
    public class RegistrarRolAdaptador
        : IRegistrarRolRepository
    {
        private readonly RolDbContext _context;

        public RegistrarRolAdaptador(RolDbContext context)
        {
            _context = context;
        }
        public async Task RegistrarRol(RegistrarRol rol)
        {
            _context.valor.Add(rol);
            await _context.SaveChangesAsync();
        }
    }
}