using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IFinancialObjectiveRepository
    {
        Task<IEnumerable<FinancialObjective>> GetAllAsync(CancellationToken cancellationToken);
        Task<FinancialObjective> GetIdAsync(Guid id, CancellationToken cancellationToken);
        void Create(FinancialObjective financialObjective);
        void Delete(FinancialObjective financialObjective);
        void Update(FinancialObjective financialObjective);
    }
}
