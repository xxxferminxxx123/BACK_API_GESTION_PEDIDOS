using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Servicio
{
    internal interface IServicioDominio
    {
        Task RegistrarUsuario(Usuario usuario);
    }
}
