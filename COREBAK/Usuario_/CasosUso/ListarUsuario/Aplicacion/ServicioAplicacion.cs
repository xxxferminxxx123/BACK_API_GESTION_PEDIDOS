using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.ValueObjects;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Aplicacion
{
    public class ServicioAplicacion
    {
        private readonly IListarUsuario _repository;

        public ServicioAplicacion(IListarUsuario repository)
        {
            _repository = repository;
        }

        public async Task<List<EListarUsuario>> ListarUsuario()
        {
            return await _repository.ListarUsuario();
        }
    }
}  