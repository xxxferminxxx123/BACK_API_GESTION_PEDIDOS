using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion.Interfaz
{
    internal interface IServicioAplicacion
    {
        Task RegistrarUsuario(Usuario usuario);
    }
}
