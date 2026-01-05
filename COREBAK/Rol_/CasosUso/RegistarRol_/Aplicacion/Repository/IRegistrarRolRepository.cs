using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion.Dto;

namespace COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion.Repository
{
    public interface IRegistrarRolRepository
    {
        Task RegistrarRol(RegistrarRolDTO usuario);
    }
}