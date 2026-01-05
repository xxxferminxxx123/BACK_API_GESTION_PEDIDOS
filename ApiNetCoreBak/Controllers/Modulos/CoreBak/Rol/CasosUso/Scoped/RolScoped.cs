using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Interface;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Adaptador;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.Scoped
{
    public static class RolScoped
    {
        public static IServiceCollection AddRolServices(this IServiceCollection services)
        {
            services.AddScoped<IRegistrarRolRepository, RegistrarRolAdaptador>();

            services.AddScoped<ServicioAplicacion>();

            return services;
        }
    }
}
