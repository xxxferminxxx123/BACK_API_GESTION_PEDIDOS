using ApiNetCoreBak.Controllers.Modulos.JWT.IJwtTokenService_;
using ApiNetCoreBak.Controllers.Modulos.JWT.JwtTokenService_;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Login.Scoped
{
    public static class JwtServiciosScoped
    {
        public static void AgregarJwtServiciosScoped(this IServiceCollection services)
        {
            services.AddScoped<IJwtTokenService, JwtTokenService>();
            // Agrega aquí otros servicios JWT si los tienes
        }
    }
}
