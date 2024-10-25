
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IPerfomanceService
    {
        Task<IEnumerable<PerfomanceDTO>> GetPerfomances(CancellationToken cancellationToken);
        Task<PerfomanceDTO> GetPerfomance(Guid id, CancellationToken cancellationToken);
        Task Add(PerfomanceDTO perfomanceDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(PerfomanceDTO perfomanceDTO);
    }
}
