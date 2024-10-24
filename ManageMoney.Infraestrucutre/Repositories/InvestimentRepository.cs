using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

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
            context.Add(investiment);
        }

        public void Delete(Investiment investiment)
        {
            context.Remove(investiment);
        }

        public void Update(Investiment investiment)
        {
            context.Update(investiment);
        }
        public async Task<IEnumerable<Investiment>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<Investiment>().ToListAsync(cancellationToken);
        }

        public async Task<Investiment> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<Investiment>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

       
    }
}
