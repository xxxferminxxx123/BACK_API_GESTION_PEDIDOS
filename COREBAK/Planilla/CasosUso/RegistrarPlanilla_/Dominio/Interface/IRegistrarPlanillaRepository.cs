using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Entidad;
using COREBAK.Planilla.Entidad.Base;

namespace COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Interface
{
    public interface IRegistrarPlanillaRepository
    {
        public Task RegistrarPlanilla(Planilla_ planill);
    }
}