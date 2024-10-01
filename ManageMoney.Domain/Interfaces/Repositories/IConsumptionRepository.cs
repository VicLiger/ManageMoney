using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IConsumptionRepository 
    {
        Task<IEnumerable<Consumption>> GetAllAsync(CancellationToken cancellationToken);
        Task<Consumption> GetIdAsync(int id, CancellationToken cancellationToken);
        void Create(Consumption consumption);
        void Delete(Consumption consumption);
        void Update(Consumption consumption);
    }
}
