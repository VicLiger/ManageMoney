
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IConsumptionService
    {

        Task<IEnumerable<ConsumptionDTO>> GetConsumptions(CancellationToken cancellationToken);
        Task<ConsumptionDTO> GetConsumption(Guid id, CancellationToken cancellationToken);
        Task Add(ConsumptionDTO consumptionDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(ConsumptionDTO consumptionDTO);
    }
}
