using ManageMoney.Domain.Entities;
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

        public void Create(FinancialObjective financialObjective)
        {
            throw new NotImplementedException();
        }

        public void Delete(FinancialObjective financialObjective)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FinancialObjective>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<FinancialObjective> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Update(FinancialObjective financialObjective)
        {
            throw new NotImplementedException();
        }
    }
}
