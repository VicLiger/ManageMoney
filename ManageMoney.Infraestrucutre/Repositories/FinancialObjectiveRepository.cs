using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class FinancialObjectiveRepository : IFinancialObjectiveRepository
    {
        private readonly AppDbContext context;

        public FinancialObjectiveRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void Create(FinancialObjective financialObjective)
        {
             context.AddAsync(financialObjective);
             context.SaveChangesAsync(); 
        }

        public void Delete(FinancialObjective financialObjective)
        {
            context.Remove(financialObjective);
             context.SaveChangesAsync(); 
        }

        public void Update(FinancialObjective financialObjective)
        {
            context.Update(financialObjective);
             context.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<FinancialObjective>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<FinancialObjective>().ToListAsync(cancellationToken);
        }

        public async Task<FinancialObjective> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<FinancialObjective>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
