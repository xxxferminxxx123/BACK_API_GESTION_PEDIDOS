using COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion.Interfaz;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Servicio;
using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion
{
    internal class ServicioAplicacion
            : IServicioAplicacion
    {
        private readonly IServicioDominio ServicioDominio;

        public ServicioAplicacion(IDelegado delegado)
        {
            ServicioDominio = new ServicioDominio(delegado);
        }

        public async Task RegistrarUsuario(Usuario usuario)
        {
            await ServicioDominio.RegistrarUsuario(usuario);
        }
    }
}