using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Interface;
using COREBAK.Planilla.Entidad.Base;
using COREBAK.Planilla.Entidad.DataBaseContext;

namespace COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Infraestructura.Adaptador
{
    public class RegistrarPlanillaAdaptader
        : IRegistrarPlanillaRepository
    {
        private readonly PlanillaDbContext _context;


        public RegistrarPlanillaAdaptader(PlanillaDbContext context)
        {
            _context = context;
        }
        public async Task RegistrarPlanilla(Planilla_ planilla)
        {
            _context.Planillas.Add(planilla);
            await _context.SaveChangesAsync();
        }
    }
}