using ManageMoney.Domain.Entities;

namespace ManageMoney.Domain.Interfaces.Repositories
{
    public interface IAccountCashRepository 
    {
        IEnumerable<Task<AccountCash>> GetAllAsync(CancellationToken cancellationToken);
        Task<AccountCash> GetIdAsync(int id, CancellationToken cancellationToken);
        void Create(AccountCash accountCash);
        void Delete(AccountCash accountCash);
        void Update(AccountCash accountCash);
    }
}
