using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados
{
    public interface IDelegado
    {
        Task RegistrarUsuario(Usuario usuario);
    }
}
