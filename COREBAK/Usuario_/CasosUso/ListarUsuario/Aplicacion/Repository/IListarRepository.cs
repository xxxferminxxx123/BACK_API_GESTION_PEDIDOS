using COREBAK.Usuario_.CasosUso.ListarUsuario.Dominio.Entidad;

namespace COREBAK.Usuario_.CasosUso.ListarUsuario.Aplicacion.Repository
{
    internal interface IListarRepository
    {
        Task <List<EListarUsuario>> ListarUsuario();
    }
}
