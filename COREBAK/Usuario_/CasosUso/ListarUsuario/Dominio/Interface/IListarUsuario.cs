using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Interface
{
    public interface IListarUsuario
    {
        Task<List<EListarUsuario>> ListarUsuario();
    }
}
