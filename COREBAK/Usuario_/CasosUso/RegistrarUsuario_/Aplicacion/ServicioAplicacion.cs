using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion.Dto;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion
{
    public class ServicioAplicacion
    {
        private readonly IRegistrarUsuarioRepository _repository;

        public ServicioAplicacion(IRegistrarUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task RegistrarUsuario(RegistrarUsuarioDTO dto)
        {
            var idUsuario = Guid.NewGuid();           
            var idPersona = Guid.NewGuid();           
            var fechaRegistro = DateTime.UtcNow;     
            var usuarioVO = new UsuarioVO(dto.Usuario);

            var usuario = new RegistrarUsuario(
                idUsuario,        // Generado aquí
                usuarioVO,        // Del DTO
                idPersona,        // Generado aquí
                dto.Activo,       // Del DTO
                fechaRegistro     // Generado aquí
            );

            await _repository.RegistrarUsuario(usuario);
        }
    }
}  