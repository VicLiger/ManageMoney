using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class InvestimentRepository : IInvestimentRepository
    {

        private readonly AppDbContext context;
        public InvestimentRepository(AppDbContext _context)
        {
            context = _context;
        }
        public void Create(Investiment investiment)
        {
            throw new NotImplementedException();
        }

        public void Delete(Investiment investiment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Investiment>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Investiment> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Update(Investiment investiment)
        {
            throw new NotImplementedException();
        }
    }
}
