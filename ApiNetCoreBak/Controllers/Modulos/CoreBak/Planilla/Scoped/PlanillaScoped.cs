using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion;
using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Interface;
using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Infraestructura.Adaptador;
using COREBAK.Planilla.Entidad.DataBaseContext;
using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Aplicacion;
using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Dominio.Repository;
using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Infraestructura.Adapter;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Planilla.Scoped
{
    public static class RolScoped
    {
        public static void AddPlanillaServices(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<PlanillaDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRegistrarPlanillaRepository, RegistrarPlanillaAdaptader>();
            services.AddScoped<IExistePlanillaRepository, ExistePlanillaAdapter>(); 

            services.AddScoped<ServicioAplicacion>();
            services.AddScoped<ExisteServicioAplicacion>();

        }
    }
}