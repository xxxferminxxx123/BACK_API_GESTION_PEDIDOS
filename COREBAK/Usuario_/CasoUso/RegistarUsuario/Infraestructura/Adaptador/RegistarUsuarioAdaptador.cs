using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion.Interfaz;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Persistencia;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Puerto;
using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Adaptador
{
    public class RegistarUsuarioAdaptador
        : IRegistrarUsuarioPuerto
    {
        private readonly IDelegado? Repositorio;
        private readonly IServicioAplicacion? Servicio;
        private readonly IJsonAdaptador _jsonAdaptador;

        public RegistarUsuarioAdaptador(DBAdaptador _dbAdaptador, IJsonAdaptador jsonAdaptador)
        {
            Repositorio = new BaseDatosSQL(_dbAdaptador);
            Servicio = new ServicioAplicacion(Repositorio);
            _jsonAdaptador = jsonAdaptador;
        }
        public async Task RegistrarUsuario(string usuarioJson, string jsonLogAplicacion)
        {
            Usuario usuario = _jsonAdaptador.Deserializar<Usuario>(usuarioJson);
            await Servicio!.RegistrarUsuario(usuario);
        }
    }
}