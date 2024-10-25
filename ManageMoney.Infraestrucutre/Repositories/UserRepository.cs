using ManageMoney.Domain.Entities;
using ManageMoney.Domain.Interfaces.Repositories;
using ManageMoney.Infraestrucutre.Context;
using Microsoft.EntityFrameworkCore;

namespace ManageMoney.Infraestrucutre.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void Create(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public void Delete(User user)
        {
            context.Remove(user);
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.Update(user);
            context.SaveChanges();
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context.Set<User>().ToListAsync(cancellationToken);
        }

        public async Task<User> GetIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<User>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}
