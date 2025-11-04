using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados;
using COREBAK.Usuario_.Entidad;
using System.Data;
using COREBAK.BDAdapter;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Persistencia
{
    public class BaseDatosSQL
        : IDelegado
    {
        public readonly DBAdaptador _dbAdaptador;

        public BaseDatosSQL(DBAdaptador dbAdaptador)
        {
            _dbAdaptador = dbAdaptador;
        }
        public async Task RegistrarUsuario(Usuario usuario)
        {
            Dictionary<string, dynamic> parametros = new()
            {
                 { "@NOMBRES" , usuario.NombreCompleto}
                ,{ "@USUARIO" , usuario.Estado }
            };

            await _dbAdaptador!.SpManipulacionDatos("TRZ_API_CONFIGURACION_REGISTRAR_SECCION", parametros);
        }
    }
}