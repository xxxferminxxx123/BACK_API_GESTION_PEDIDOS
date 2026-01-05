using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion.Dto;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Entidad;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Interface;

namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion
{
    public class ServicioAplicacion
    {
        private readonly IRegistrarRolRepository _repository;

        public ServicioAplicacion(IRegistrarRolRepository repository)
        {
            _repository = repository;
        }

        public async Task RegistrarRol(RegistrarRolDTO dto)
        {
            var rolId = Guid.NewGuid();
            var FechaRegistro = DateTime.UtcNow;
            var UsuarioRegistro = "JDEPAZE";

            var rol = new RegistrarRol(
                rolId,      
                dto.Descripcion,
                dto.Codigo,
                dto.Activo,
                FechaRegistro,      
                UsuarioRegistro
            );

            await _repository.RegistrarRol(rol);
        }
    }
}