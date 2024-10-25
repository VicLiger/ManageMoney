
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IFinancialObjective
    {
        Task<IEnumerable<FinancialObjectiveDTO>> GetFinancialObjectives(CancellationToken cancellationToken);
        Task<FinancialObjectiveDTO> GetFinancialObjective(Guid id, CancellationToken cancellationToken);
        Task Add(FinancialObjectiveDTO financialObjectiveDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(FinancialObjectiveDTO financialObjectiveDTO);
    }
}
