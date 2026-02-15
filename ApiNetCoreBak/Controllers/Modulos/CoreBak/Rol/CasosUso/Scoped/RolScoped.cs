using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Interface;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Adaptador;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.Scoped
{
    public static class RolScoped
    {
        public static void AddRolServices(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<RolDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Registra servicios
            services.AddScoped<IRegistrarRolRepository, RegistrarRolAdaptador>();
            services.AddScoped<ServicioAplicacion>();

        }
    }
}
