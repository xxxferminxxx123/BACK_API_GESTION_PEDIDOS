using COREBAK.Usuario_.CasosUso.ListarUsuario.Aplicacion;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.ListarUsuario.Infraestructura.Adaptador;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Scoped
{
    public static class UsuarioScoped
    {
        public static IServiceCollection AddUsuarioServices(this IServiceCollection services)
        {

            services.AddScoped<IListarUsuario, ListarUsuarioAdaptador>();
            services.AddScoped<ServicioAplicacion>();

            return services;
        }
    }
}
