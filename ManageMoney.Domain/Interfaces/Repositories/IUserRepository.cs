using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IUserRepository 
    {
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken);
        Task<User> GetIdAsync(Guid id, CancellationToken cancellationToken);
        void Create(User user);
        void Delete(User user);
        void Update(User user);
    }
}
