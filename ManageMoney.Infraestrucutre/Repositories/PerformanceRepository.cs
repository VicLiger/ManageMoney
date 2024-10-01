using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class PerformanceRepository : IPerfomanceRepository
    {
        private readonly AppDbContext context;
        public PerformanceRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void Create(Performance performance)
        {
            throw new NotImplementedException();
        }

        public void Delete(Performance performance)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Performance>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Performance> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Update(Performance performance)
        {
            throw new NotImplementedException();
        }
    }
}
