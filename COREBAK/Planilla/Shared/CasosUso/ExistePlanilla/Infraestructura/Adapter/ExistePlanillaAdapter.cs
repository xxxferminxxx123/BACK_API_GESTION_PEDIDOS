using COREBAK.Planilla.Entidad.DataBaseContext;
using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Dominio.Repository;
using Microsoft.EntityFrameworkCore;

namespace COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Infraestructura.Adapter
{
    public class ExistePlanillaAdapter : IExistePlanillaRepository
    {
        private readonly PlanillaDbContext _context;

        public ExistePlanillaAdapter(PlanillaDbContext context)
        {
            _context = context;
        }
        public async Task<bool> ExistePlanilla(Guid planillaId)
        {
            return await _context.Planillas
                .AnyAsync(p => p.PlanillaId == planillaId);
        }
    }
}