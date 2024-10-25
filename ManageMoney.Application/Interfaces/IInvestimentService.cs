
using ManageMoney.Application.DTOs;

namespace ManageMoney.Application.Interfaces
{
    public interface IInvestimentService
    {
        Task<IEnumerable<InvestimentDTO>> GetInvestiments(CancellationToken cancellationToken);
        Task<InvestimentDTO> GetInvestiment(Guid id, CancellationToken cancellationToken);
        Task Add(InvestimentDTO investimentDTO);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(InvestimentDTO investimentDTO   );
    }
}
