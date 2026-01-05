using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion.Dto;

namespace COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion.Repository
{
     public interface IUsuarioRepository
    {
        Task RegistrarUsuario(RegistrarUsuarioDTO usuario);
    }
}