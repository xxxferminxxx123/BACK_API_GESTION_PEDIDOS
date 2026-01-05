using COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Entidad;

namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Dominio.Interface
{
    public interface IRegistrarRolRepository
    {
        Task RegistrarRol(RegistrarRol registrar);
    }
}
