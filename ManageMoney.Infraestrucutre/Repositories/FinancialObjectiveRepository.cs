using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class FinancialObjectiveRepository : IFinancialObjectiveRepository
    {
        private readonly AppDbContext context;
        public FinancialObjectiveRepository(AppDbContext _context)
        {
            context = _context;
        }
    }
}
