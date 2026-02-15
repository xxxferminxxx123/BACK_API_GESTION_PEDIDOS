using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Dto;

namespace COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Repository
{
    public interface RegistarPlanillaRepository
    {
        public Task RegistrarPlanilla(RegistrarPlanillaDTO planilla);
    }
}