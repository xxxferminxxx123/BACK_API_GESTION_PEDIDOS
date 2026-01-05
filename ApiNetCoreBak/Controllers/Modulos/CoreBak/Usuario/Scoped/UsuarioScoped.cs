using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Dominio.Interface;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Adaptador;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Scoped
{
    public static class UsuarioScoped
    {
        public static IServiceCollection AddUsuarioServices(this IServiceCollection services)
        {
            services.AddScoped<IRegistrarUsuarioRepository, UsuarioRepository>();

            services.AddScoped<ServicioAplicacion>();

            return services;
        }
    }
}
