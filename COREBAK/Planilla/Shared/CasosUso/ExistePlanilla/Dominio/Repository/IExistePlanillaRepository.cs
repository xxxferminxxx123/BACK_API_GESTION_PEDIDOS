using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Dominio.Repository
{
    public interface IExistePlanillaRepository
    {
        Task<bool> ExistePlanilla(Guid planillaId);
    }
}
