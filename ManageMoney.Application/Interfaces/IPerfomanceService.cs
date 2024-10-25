
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IPerfomanceService
    {
        Task<IEnumerable<PerfomanceDTO>> GetPerfomances(CancellationToken cancellationToken);
        Task<PerfomanceDTO> GetPerfomance(int id, CancellationToken cancellationToken);
        Task Add(PerfomanceDTO perfomanceDTO);
        Task Delete(int id);
        Task Update(PerfomanceDTO perfomanceDTO);
    }
}
