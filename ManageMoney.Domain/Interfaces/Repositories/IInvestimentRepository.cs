using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IInvestimentRepository 
    {
        Task<IEnumerable<Investiment>> GetAllAsync(CancellationToken cancellationToken);
        Task<Investiment> GetIdAsync(int id, CancellationToken cancellationToken);
        void Create(Investiment investiment);
        void Delete(Investiment investiment);
        void Update(Investiment investiment);
    }
}
