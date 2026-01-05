using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Entidad;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Interface
{
    public interface IRegistrarUsuarioRepository
    {
        Task RegistrarUsuario(RegistrarUsuario registrarUsuario);
    }
}
