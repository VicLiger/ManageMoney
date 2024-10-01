using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IPerfomanceRepository 
    {
        Task<IEnumerable<Performance>> GetAllAsync(CancellationToken cancellationToken);
        Task<Performance> GetIdAsync(int id, CancellationToken cancellationToken);
        void Create(Performance performance);
        void Delete(Performance performance);
        void Update(Performance performance);
    }
}
