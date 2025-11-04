using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Servicio;
using COREBAK.Usuario_.Entidad;

namespace COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain
{
    internal class ServicioDominio
        : IServicioDominio

    {
        private readonly IDelegado Delegado;
        public ServicioDominio(IDelegado delegado)
        {
            Delegado = delegado;
        }
        public async Task RegistrarUsuario(Usuario usuario)
        {
            Usuario usuarioNew = new Usuario
            {
                NombreCompleto = usuario.NombreCompleto,
                Estado = usuario.Estado
            };
            await Delegado.RegistrarUsuario(usuarioNew);
        }
    }
}