using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class ConsumptionRepository : IConsumptionRepository
    {
        private readonly AppDbContext context;

        public ConsumptionRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public async Task<Consumption> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<Consumption>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Consumption>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<Consumption>().ToListAsync(cancellationToken);
        }

        public void Create(Consumption consumption)
        {
            context.Add(consumption);
            context.SaveChanges();
        }

        public void Delete(Consumption consumption)
        {
            context.Remove(consumption);
            context.SaveChanges();
        }

        public void Update(Consumption consumption)
        {
            context.Update(consumption);
            context.SaveChanges();
        }
    }
}
