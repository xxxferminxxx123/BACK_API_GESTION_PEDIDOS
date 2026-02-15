using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Dominio.Repository;

namespace COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Aplicacion
{
    public class ExisteServicioAplicacion
        (
        IExistePlanillaRepository repository
        )
    {
        private readonly IExistePlanillaRepository _repository = repository;
        public async Task<bool> ExistePlanillaPorId(Guid planillaId)
        {
            bool existe = await _repository.ExistePlanilla(planillaId);
            return existe;
        }
    }
}