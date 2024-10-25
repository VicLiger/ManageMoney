using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

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
            context.Add(performance);
            context.SaveChanges();
        }

        public void Delete(Performance performance)
        {
            context.Remove(performance);
            context.SaveChanges();
        }

        public void Update(Performance performance)
        {
            context.Update(performance);
            context.SaveChanges();
        }

        public async Task<IEnumerable<Performance>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<Performance>().ToListAsync(cancellationToken);
        }

        public async Task<Performance> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<Performance>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
