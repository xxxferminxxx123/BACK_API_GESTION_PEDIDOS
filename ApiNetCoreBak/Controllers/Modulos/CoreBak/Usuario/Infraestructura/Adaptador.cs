using COREBAK.JsonAdaptor;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Puerto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Infraestructura
{
    public class Adaptador(
                IRegistrarUsuarioPuerto servicio
              , IJsonAdaptador jsonAdaptador
        )
    {
        private readonly IRegistrarUsuarioPuerto RegistrarUsuarioAdaptador = servicio;
        private readonly IJsonAdaptador? JsonAdaptador = jsonAdaptador;

        public async Task<IActionResult> RegistarUsuario(UsuarioDto usuario)
        {
            string jsonLog = "";
            try
            {
                string jsonUsuario = JsonAdaptador!.Serializar(usuario);

                 await RegistrarUsuarioAdaptador.RegistrarUsuario(jsonUsuario, jsonLog);

                return new ObjectResult(new
                {
                    success = true,
                    message = "Usuario registrado exitosamente",
                    data = usuario
                })
                {
                    StatusCode = 200
                };

            }
            catch (Exception ex)
            {
                return new ObjectResult(new
                {
                    success = false,
                    message = ex.Message
                })
                {
                    StatusCode = 400
                };
            }
        }
    }

}