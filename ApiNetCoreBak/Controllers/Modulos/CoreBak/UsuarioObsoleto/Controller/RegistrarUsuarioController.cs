//using COREBAK.JsonAdaptor;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using ApiNetCoreBak.Controllers.Modulos.CoreBak.UsuarioObsoleto.Infraestructura;

//namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.UsuarioObsoleto.Controller
//{
//    [ApiController]
//    [Route("api/usuario")]
//    public class UsuarioController(
//            IRegistrarUsuarioPuerto registrarUsuarioAdaptador,
//            IJsonAdaptador jsonAdaptador) : ControllerBase  
//    {


//        private readonly Adaptador Adaptador = new(registrarUsuarioAdaptador, jsonAdaptador );


//        [HttpPost("registrar")]
//        public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDto usuario)
//        {
//            string jsonLog = "";
//            try
//            {
//                return await Adaptador.RegistarUsuario(usuario);

//            }
//            catch (Exception ex)
//            {
//                return BadRequest(new
//                {
//                    success = false,
//                    message = ex.Message
//                });
//            }
//        }
//    }
//}